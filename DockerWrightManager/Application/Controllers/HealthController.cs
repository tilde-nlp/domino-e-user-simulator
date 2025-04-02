using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DockerWrightManager.Controllers
{
    [ApiController]
    [Route("health")]
    public class HealthController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok();
        }
    }
}
