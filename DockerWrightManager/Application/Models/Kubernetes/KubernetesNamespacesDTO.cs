using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWrightManager.Models.Kubernetes.NamespaceDTO
{
    public class KubernetesNamespacesDTO
    {
        public string kind { get; set; }
        public string apiVersion { get; set; }
        public Metadata metadata { get; set; }
        public Item[] items { get; set; }
    }

    public class Metadata
    {
        public string resourceVersion { get; set; }
    }

    public class Item
    {
        public Metadata1 metadata { get; set; }
        public Spec spec { get; set; }
        public Status status { get; set; }
    }

    public class Metadata1
    {
        public string name { get; set; }
        public string uid { get; set; }
        public string resourceVersion { get; set; }
        public DateTime creationTimestamp { get; set; }
        public Managedfield[] managedFields { get; set; }
    }

    public class Managedfield
    {
        public string manager { get; set; }
        public string operation { get; set; }
        public string apiVersion { get; set; }
        public DateTime time { get; set; }
        public string fieldsType { get; set; }
        public Fieldsv1 fieldsV1 { get; set; }
    }

    public class Fieldsv1
    {
        public FStatus fstatus { get; set; }
    }

    public class FStatus
    {
        public FPhase fphase { get; set; }
    }

    public class FPhase
    {
    }

    public class Spec
    {
        public string[] finalizers { get; set; }
    }

    public class Status
    {
        public string phase { get; set; }
    }

}
