using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWrightManager.Models.Settings
{
    public class AppSetting
    {
        const string KUBERNETES_BEARER_TOKEN = "/var/run/secrets/kubernetes.io/serviceaccount/token";
        public const string KUBERNETES_CA = "/var/run/secrets/kubernetes.io/serviceaccount/ca.crt";
        string _bearerToken;
        public string InfrastructureSecret { get; set; }
        public string DockerAPI { get; set; }
        public string KubernetesHost { get; set; }
        public string KubernetesDefaultNamespace { get; set; }
        public string Image { get; set; }
        public string ImagePullSecret { get; set; }
        public string BearerToken { get => _bearerToken; }
        public string ServiceDefaultNamespace { get; set; }
        public string JobDefaultNamespace { get; set; }
        public string NodeselectorLabelJob { get; set; }
        public string NodeselctorLobelBot { get; set; }
        public string NodeselectorLabelDeployment { get; set; }
        public string JobTrainerRequestMemory { get; set; }
        public string JobTrainerRequestCPU { get; set; }
        public string JobDefaultRequestMemory { get; set; }
        public string JobDefaultRequestCPU { get; set; }
        public string URL { get; set; }
        public string PageURL { get; set; }


        public InfrstructureEnvironment InfrstructureEnvironment { get; set; }
        public ContainerVolume ResultVolume { get; set; }

        public string NodeselectorLabelJobJson()
        {     
            return SplitNodeSelectionOptions(NodeselectorLabelJob);
        }

        public string NodeselctorLobelBotJson()
        {         
            return SplitNodeSelectionOptions(NodeselctorLobelBot);
        }

        public string NodeselectorLabelDeploymentJson()
        {         
            return SplitNodeSelectionOptions(NodeselectorLabelDeployment);
        }
        public string TolerationsJobJson()
        {            
            return SplitTolerationsOptions(NodeselectorLabelJob);
        }
        public string SplitNodeSelectionOptions(string options)
        {
            var result = new List<string>();
            if (string.IsNullOrEmpty(options))
            {
                return "{}";
            }

            var settings = options.Split(" ");
            foreach (var setting in settings)
            {
                var entity = setting.Split("=");
                result.Add($" \"{entity[0]}\":\"{entity[1]}\"");
            }
            var jsonResult = $"{{ {String.Join(",", result)} }}";
            return jsonResult;
        }
        public string SplitTolerationsOptions(string options)
        {
            if (string.IsNullOrEmpty(options))
            {
                // If options is empty or null, return an empty JSON array
                return "[]";
            }

            var result = new List<string>();

            var settings = options.Split(' ');
            foreach (var setting in settings)
            {
                var entity = setting.Split('=');
                if (entity.Length != 2)
                {
                    // Skip invalid settings that do not contain exactly one '=' separator
                    continue;
                }

                // Construct a JSON object string for each setting
                var jsonObject = new
                {
                    key = entity[0],
                    @operator = "Equal",
                    value = entity[1],
                    effect = "NoSchedule"
                };

                // Serialize the JSON object to string and add to the result list
                var jsonSetting = JsonConvert.SerializeObject(jsonObject);
                result.Add(jsonSetting);
            }

            // Join the individual JSON objects into a JSON array string
            var jsonArrayResult = $"[{string.Join(",", result)}]";

            return jsonArrayResult;
        }



        public void SetBearerToken()
        {
            try
            {
                using (var sr = new StreamReader(KUBERNETES_BEARER_TOKEN))
                {
                    _bearerToken = (sr.ReadToEnd());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LogSettings()
        {
       
        }
    }

    public class ContainerVolume
    {
        public string Volume { get; set; }
        public string MountPath { get; set; }
        public string VolumeClaim { get; set; }
    }

    public enum InfrstructureEnvironment
    {
        Docker = 1,
        Swarm = 2,
        Kubernetes = 3,
        Azure = 4
    }


}
