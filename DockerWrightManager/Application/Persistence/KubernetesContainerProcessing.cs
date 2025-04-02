using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DockerWrightManager.Models;
using DockerWrightManager.Models.Kubernetes;
using DockerWrightManager.Models.Kubernetes.Images;
using DockerWrightManager.Models.Settings;
using k8s;
using k8s.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using k8Deployment = DockerWrightManager.Models.Kubernetes.Deployment;
using k8Job = DockerWrightManager.Models.Kubernetes.Jobs;

namespace DockerWrightManager.Persistence
{
    public class KubernetesContainerProcessing 
    {
        readonly string _host;
        readonly string _namespace;
        readonly string _serviceDefaultNamespace;
        readonly string _jobDefaultNamespace;
        readonly HttpHelper _httpHelper;
        readonly AppSetting _appSetting;

        public KubernetesContainerProcessing(HttpHelper httpHelper,
            AppSetting appSetting)
        {
            _httpHelper = httpHelper;
            _host = appSetting.KubernetesHost;
            _namespace = appSetting.KubernetesDefaultNamespace;
            _serviceDefaultNamespace = appSetting.ServiceDefaultNamespace;
            _jobDefaultNamespace = appSetting.JobDefaultNamespace;
            _appSetting = appSetting;
        }

        public async Task<object> ApplyJob(string yaml)
        {
            return await ApplyJob(yaml, _jobDefaultNamespace);
        }

        public async Task<object> ApplyJob(string yaml, string namespc)
        {
            var result = await _httpHelper.SendPostAsync<object>(
                $"{_host}/apis/batch/v1/namespaces/{namespc}/jobs",
                 JsonConvert.DeserializeObject<object>(yaml));
            return await Task.FromResult(result);
        }

        public async Task<object> ApplyPersistentVolume(string yaml)
        {
            var result = await _httpHelper.SendPostAsync<object>(
                $"{_host}/api/v1/persistentvolumes",
                JsonConvert.DeserializeObject<object>(yaml));
            return await Task.FromResult(result);
        }

        public async Task<object> ApplyPersistentVolumeClaim(string yaml)
        {
            var result = await _httpHelper.SendPostAsync<object>(
                $"{_host}/api/v1/persistentvolumeclaims",
                JsonConvert.DeserializeObject<object>(yaml));
            return await Task.FromResult(result);
        }

        public async Task<object> RemoveJob(string job)
        {
            return await RemoveJob(job, _jobDefaultNamespace);
        }

        public async Task<object> RemoveJob(string job, string namespc)
        {
            var body = new { propagationPolicy = "Background" };
            var result = await _httpHelper.SendDeleteAsync<object>(
     $"{_host}/apis/batch/v1/namespaces/{namespc}/jobs/{job}", body);
            return await Task.FromResult(result);
        }

        public async Task<object> GetJob(string job, string namespc)
        {
            var body = new { propagationPolicy = "Background" };
            var result = await _httpHelper.SendAsync<object>(
     $"{_host}/apis/batch/v1/namespaces/{namespc}/jobs/{job}");
            return await Task.FromResult(result);
        }

        public async Task<ContainerLaunchResult> StartJob(ContainerParameters containerParams)
        {
            string template = System.IO.File.ReadAllText("Templates/Job.json");

            var command = JsonConvert.DeserializeObject<k8Job.JobDTO>(template);
            command.metadata.name = containerParams.Service;


            var container = new k8Job.Container();
            container.name = containerParams.Service;            
            container.image = containerParams.Image;
            container.imagePullPolicy = "Always";
            container.command = containerParams.Command.ToArray();
            container.resources = new k8Job.Recourses();
            container.resources.requests = new k8Job.RecourceObj()
            {
                cpu = string.IsNullOrEmpty(containerParams.RequestCPU) ? _appSetting.JobDefaultRequestCPU : containerParams.RequestCPU,
                memory = string.IsNullOrEmpty(containerParams.RequestMemory) ? _appSetting.JobDefaultRequestMemory : containerParams.RequestMemory
            };

            container.env = containerParams.Env.Select(x =>
                    new k8Job.Env()
                    {
                        name = x.Name,
                        value = x.Value
                    }).ToArray();

            if (!string.IsNullOrEmpty(containerParams.Volume))
            {
                container.volumeMounts = new k8Job.Volumemount[]{
                    new k8Job.Volumemount()
                    {
                        mountPath =  GetVolume(containerParams.Volume).MountPath,
                        name =  GetVolume(containerParams.Volume).Volume
                    }
                };
                command.spec.template.spec.volumes = new k8Job.Volume[] {
                    new k8Job.Volume()
                    {
                        name =  GetVolume(containerParams.Volume).Volume,
                        persistentVolumeClaim = new k8Job.Persistentvolumeclaim()
                        {
                            claimName =  GetVolume(containerParams.Volume).VolumeClaim
                        }
                    }
                };
            }

            command.spec.ttlSecondsAfterFinished = 60;
            command.spec.template.spec.containers = new k8Job.Container[] { container };

            command.spec.template.spec.imagePullSecrets = new k8Job.Imagepullsecret[] {
                new k8Job.Imagepullsecret()
                {
                    name =    _appSetting.ImagePullSecret
                }
            };
            var execCommand = JsonConvert.SerializeObject(command);
            execCommand = AddNodeSelector(execCommand, _appSetting.NodeselectorLabelJobJson());
            execCommand = AddTolerations(execCommand, _appSetting.TolerationsJobJson());
            var result = await ApplyJob(execCommand);
            return new ContainerLaunchResult()
            {
                Command = execCommand,
                Status = true,
                Message = JsonConvert.SerializeObject(result)
            };
        }


        public ContainerVolume GetVolume(string volume)
        {
            switch (volume)
            {
                case "ResultVolume":
                    {
                        return _appSetting.ResultVolume;
                    }
                default: throw new Exception($"Volume '{volume}' doesn't exist");
            }
        }

        public async Task<object> Ping()
        {
            var result = await _httpHelper.SendAsync<object>(
               $"{_host}/version");
            return result;
        }      

        public async Task<ContainerLaunchResult> DeleteJob(ContainerParameters containerParams)
        {
            var result = new ContainerLaunchResult()
            {
                Command = $"Remove Job: {containerParams.Service}",
                Status = true
            };

            try
            {
                var response = await RemoveJob(containerParams.Service, _jobDefaultNamespace);
            }
            catch (HttpRequestException ex)
            {
                result.Message = ex.Message;
                result.Status = false;
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        private string AddNodeSelector(string json, string nodeSelectors)
        {
            var jObj = JObject.Parse(json);
            var selectionNodeList = JObject.Parse(nodeSelectors);
            var selectionNodesObj = new JProperty("nodeSelector", selectionNodeList);
            jObj.SelectToken("spec.template.spec.volumes").Parent.AddAfterSelf(selectionNodesObj);
            var resposne = jObj.ToString();
            return resposne;
        }
        private string AddTolerations(string json, string nodeSelectors)
        {
            if (string.IsNullOrEmpty(nodeSelectors) || nodeSelectors == "[]")
            {
                // If nodeSelectors is empty or "[]", simply return the original JSON string
                return json;
            }

            // Parse the input JSON string into a JObject
            var jObj = JObject.Parse(json);

            // Parse the nodeSelectors JSON string into a JObject
            var selectionNodeList = JArray.Parse(nodeSelectors);

            // Create a new JProperty "tolerations" with the nodeSelectors array as its value
            var tolerationsProperty = new JProperty("tolerations", selectionNodeList);

            // Navigate to the correct location in the JSON structure and add the new property
            var volumesToken = jObj.SelectToken("spec.template.spec.volumes");
            volumesToken.Parent.AddAfterSelf(tolerationsProperty);

            // Serialize the modified JObject back to a JSON string
            var updatedJson = jObj.ToString();


            return updatedJson;
        }
    }
}
