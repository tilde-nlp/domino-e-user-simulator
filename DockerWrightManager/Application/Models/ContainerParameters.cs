using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWrightManager.Models
{

    public class ContainerParameters
    {
        public string LimitCPU { get; set; } 
        public string LimitMemory { get; set; }

        public string RequestCPU { get; set; }
        public string RequestMemory { get; set; }        
        public string Volume { get; set; }
        public string Image { get; set; }
        public string Service { get; set; }        
        public List<string> Command { get; set; }
        public List<Env> Env { get; set; } = new List<Env>();
    }

    public class Env
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
