using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWrightManager.Models
{
    public class HealthCheckDTO
    {
        public HealthCheckDTO(string log)
        {
            Message = log;
            IsHealthy = log.Contains("livez check passed");
        }
        public bool IsHealthy { get; set; }
        public string Message { get; set; }
    }
}
