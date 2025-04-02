using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWrightManager.Models.Kubernetes.Deployment
{
    public partial class IDeploymentDTO
    {
        public string apiVersion { get; set; }
        public string kind { get; set; }
        public Metadata metadata { get; set; }
        public virtual ISpec spec { get; set; }
    }

    public class Metadata
    {
        public string name { get; set; }  
        public string resourceVersion { get; set; }
        public Annotations annotations { get; set; }
    }

    public class Annotations
    {
        [JsonProperty(PropertyName = "serving.knative.dev/creator")]
        public string creator { get; set; }
        [JsonProperty(PropertyName = "serving.knative.dev/lastModifier")]
        public string lastModifier { get; set; }
    }

    public partial class ISpec
    {        
        public Template template { get; set; }
    }

    public class Selector
    {
        public Matchlabels matchLabels { get; set; } = new Matchlabels();
    }

    public class Matchlabels
    {
        public string app { get; set; }
    }

    public class Template
    {
        public Metadata1 metadata { get; set; } = new Metadata1();
        public Spec1 spec { get; set; }
    }

    public class Metadata1
    {
        public Labels labels { get; set; } = new Labels();
        public SpecAnnotations annotations { get; set; }
    }

    public class SpecAnnotations
    {
        [JsonProperty(PropertyName = "autoscaling.knative.dev/scale-down-delay")]
        public string scaleDownDelay { get; set; }
    }

    public class Labels
    {
        public string app { get; set; }
    }

    public class Spec1
    {
        public List<Container> containers { get; set; } = new List<Container>();
        public List<Imagepullsecret> imagePullSecrets { get; set; } = new List<Imagepullsecret>();
        public List<Volume> volumes { get; set; } = new List<Volume>();
    }

    public class Container
    {
        public string name { get; set; }
        public string image { get; set; }
        public string imagePullPolicy { get; set; }
        public Resources resources { get; set; }
        public List<Env> env { get; set; }
        public List<IPort> ports { get; set; }
        public List<VolumeMount> volumeMounts { get; set; } = new List<VolumeMount>();
    }

    public class VolumeMount
    {
        public string mountPath { get; set; }
        public string name { get; set; }
    }

    public class Resources
    {
        public Requests requests { get; set; }
        public Limits limits { get; set; }
    }

    public class Requests
    {
        public string cpu { get; set; }
        public string memory { get; set; }
    }

    public class Limits
    {
        public string cpu { get; set; }
        public string memory { get; set; }
    }

    public class Env
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class IPort
    {
        public int containerPort { get; set; }        
    }

    public class Port : IPort
    {        
        public string name { get; set; }
    }

    public class Imagepullsecret
    {
        public string name { get; set; }
    }

    public class Volume
    {
        public string name { get; set; }
        public Persistentvolumeclaim persistentVolumeClaim { get; set; }
    }

    public class Persistentvolumeclaim
    {
        public string claimName { get; set; }
    }

}
