using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWrightManager.Models.Kubernetes.Deployment
{
    public class DeploymentDTO : IDeploymentDTO
    {
        public override ISpec spec { get; set; } = new Spec();
    }

    public class Spec : ISpec
    {
        public Selector selector { get; set; } = new Selector();        
    }
}
