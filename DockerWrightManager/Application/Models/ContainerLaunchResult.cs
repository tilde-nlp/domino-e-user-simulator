using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWrightManager.Models
{
    public class ContainerLaunchResult
    {
        public bool Status { get; set; }
        public string Command { get; set; }
        public string Message { get; set; }        
    }
}
