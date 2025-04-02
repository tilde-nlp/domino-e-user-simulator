using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;

namespace DockerWrightManager.Infrastructure.Security
{
    public class InfrastructureAuthorizationAttribute : Attribute, IActionFilter
    {
        IConfiguration _configuration;

        public InfrastructureAuthorizationAttribute(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var authorizationHeader = context.HttpContext.Request.Headers["Authorization"];
            var secret = _configuration.GetValue<string>("InfrastructureSecret");

            var isAuthorized = authorizationHeader.Equals(secret);
            if (isAuthorized)
            {
                return;
            }

            context.HttpContext.Response.StatusCode = 401;
            context.Result = new EmptyResult();
        }
    }
}
