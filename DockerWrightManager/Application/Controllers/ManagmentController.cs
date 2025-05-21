using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DockerWrightManager.Infrastructure.Security;
using DockerWrightManager.Models;
using DockerWrightManager.Models.Settings;
using DockerWrightManager.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace DockerWrightManager.Controllers
{
    [Route("api")]
   // [TypeFilter(typeof(InfrastructureAuthorizationAttribute))]
    public class ManagmentController : Controller
    {        
        readonly KubernetesContainerProcessing _kubernetesContainerProcessing;
        readonly AppSetting _appSetting;

        public ManagmentController(KubernetesContainerProcessing kubernetesContainerProcessing, AppSetting appSetting)
        {       
            _kubernetesContainerProcessing = kubernetesContainerProcessing;
            _appSetting = appSetting;
        }


        [HttpGet("startjob")]
        public async Task<IActionResult> StartJob(string callback)
        {
            ContainerParameters parameters = new ContainerParameters();
            parameters.Image = _appSetting.Image;
            parameters.Volume = "ResultVolume";
            var jobId = Guid.NewGuid().ToString();
            parameters.Service = "testresult-"+Guid.NewGuid().ToString();
            parameters.Env = new List<Env>()
            {
                new Env { Name = "PLAYWRIGHT_HTML_OUTPUT_DIR", Value = _appSetting.ResultVolume.MountPath + $"/{jobId}" },
				new Env { Name = "PLAYWRIGHT_PAGE_URL", Value = _appSetting.PageURL }
			};
            parameters.Command = new List<string> { "npm", "run", "test-html-report" };
            if (!string.IsNullOrEmpty(callback))
                Callbacker.push(jobId, callback);
            await _kubernetesContainerProcessing.StartJob(parameters);
            return Ok();
        }


        [HttpGet("startone")]
        public async Task<IActionResult> StartOne(string test, string callback)
        {
            ContainerParameters parameters = new ContainerParameters();
            parameters.Image = _appSetting.Image;
            parameters.Volume = "ResultVolume";
            var jobId = "testresult-" + Guid.NewGuid().ToString();
            parameters.Service = jobId;
            parameters.Env = new List<Env>()
            {
                new Env { Name = "PLAYWRIGHT_HTML_OUTPUT_DIR", Value = _appSetting.ResultVolume.MountPath + $"/{jobId}" },
				new Env { Name = "PLAYWRIGHT_PAGE_URL", Value = _appSetting.PageURL }
			};
            parameters.Command = new List<string> { "npx", "playwright", "test", $"{test}", "--browser=all", "--reporter=html" };
            if (!string.IsNullOrEmpty(callback))
                Callbacker.push(jobId, callback);
            await _kubernetesContainerProcessing.StartJob(parameters);
            return Ok(jobId);
        }

        [HttpGet("resultlist")]
        public async Task<IActionResult> ResultList()
        {
            var dirs = Directory.EnumerateDirectories(_appSetting.ResultVolume.MountPath).ToList();
            var res = "<html>";            
            foreach (var l in dirs.OrderByDescending(x => System.IO.File.GetCreationTime(x + "/index.html")))
            {
                res += $"<a href={_appSetting.URL}/result?path={l}>{System.IO.File.GetCreationTime(l+"/index.html")}</a><br>";
            }
            res += "</html>";
            return Content(res, "text/html");            
        }

        [HttpGet("result")]
        public async Task<IActionResult> Result(string path)
        {
            var content = System.IO.File.ReadAllText($"{path}/index.html");
            return Content(content, "text/html");
        }

        [HttpGet("complete")]
        public async Task<IActionResult> Complete(string path)
        {
            if (System.IO.File.Exists($"{path}/index.html"))
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet("list")]
        public async Task<IActionResult> List()
        {
            var list = new List<string> { "tests/productCatalogue.spec.ts", "tests/programmingRequest.spec.ts" };
            var res = "<html>";
            res += "<script>"
                + "function startJob(path, id, id2) {\r\n  var xhttp = new XMLHttpRequest();\r\n  xhttp.onreadystatechange = function() {\r\n    if (this.readyState == 4 && this.status == 200) {\r\n\t\tdocument.getElementById(id).style.visibility = \"visible\";\r\n\t\tdocument.getElementById(id2).style.visibility = \"hidden\";\r\n\t\tvar jobid = this.responseText;\r\n\t \r\n\t\tsetInterval(function(){\r\n\t\t\tvar that = this;\r\n\t\t\tvar x = new XMLHttpRequest();\r\n\t\t\tx.onreadystatechange = function() {\r\n\t\t\t\tif (this.readyState == 4 && this.status == 200) {\r\n\t\t\t\t\tdocument.getElementById(id).style.visibility = \"hidden\";\r\n\t\t\t\t\tdocument.getElementById(id2).style.visibility = \"visible\";\r\n\t\t\t\t\tdocument.getElementById(id2).innerHTML=\"<a href=/api/result?path=/data/\"+jobid+\">RESULT</a>\";\r\n\t\t\t\t\tclearInterval(that);\r\n\t\t\t\t}\r\n\t\t\t};\r\n\t\t\tx.open(\"GET\", \"/api/complete?path=/data/\"+jobid, true);\r\n\t\t\tx.send();\r\n\t\t},5000);\r\n    }\r\n  };\r\n  xhttp.open(\"GET\", \"/api/startone?test=\"+path, true);\r\n  xhttp.send();  \r\n}\r\n\r\n"
                + "</script>";
            foreach (var l in list)
            {
                res += $"<span style=\"color: blue; cursor: pointer\" onclick=\"startJob('{l}','spinner{list.IndexOf(l)}', 'link{list.IndexOf(l)}')\"><u>{l}</u> </span><span style=\"visibility: hidden\" id=\"spinner{list.IndexOf(l)}\">PROCESSING</span><span id=\"link{list.IndexOf(l)}\"></span><br>\n";
            }
            res += "</html>";
            return Content(res, "text/html");
        }

        [HttpGet("status")]
        public async Task<IActionResult> Status(string job)
        {
            return Json(await _kubernetesContainerProcessing.GetJob(job, _appSetting.JobDefaultNamespace));            
        }
    }
}
