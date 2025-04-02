using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWrightManager.Models.Kubernetes.Jobs
{

    public class JobDTO
    {
        public string apiVersion { get; set; }
        public string kind { get; set; }
        public Metadata metadata { get; set; }
        public Spec spec { get; set; }
    }

    public class Metadata
    {
        public string name { get; set; }
    }

    public class Spec
    {
        public Template template { get; set; }
        public int backoffLimit { get; set; }
        public int ttlSecondsAfterFinished { get; set; }
    }

    public class Template
    {
        public Spec1 spec { get; set; }
    }

    public class Spec1
    {
        public Container[] containers { get; set; }
        public Imagepullsecret[] imagePullSecrets { get; set; }
        public Volume[] volumes { get; set; }
        public string restartPolicy { get; set; }
    }

    public class Container
    {
        public string name { get; set; }
        public string image { get; set; }
        public string imagePullPolicy { get; set; }
        public Recourses resources { get; set; }
        public Env[] env { get; set; }
        public Volumemount[] volumeMounts { get; set; }
        public string[] command { get; set; }
    }

    public class Recourses
    {
        public RecourceObj requests { get; set; }
    }

    public class RecourceObj
    {
        public string cpu { get; set; }
        public string memory { get; set; }
    }



    public class Env
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class Volumemount
    {
        public string mountPath { get; set; }
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
