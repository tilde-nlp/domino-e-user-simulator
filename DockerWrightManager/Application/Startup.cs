using System;
using System.Threading.Tasks;
using DockerWrightManager.Infrastructure;
using DockerWrightManager.Models.Settings;
using DockerWrightManager.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DockerWrightManager
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.json")
                  .AddEnvironmentVariables()
                  .Build();

            var appSettings = configuration.Get<AppSetting>();
            appSettings.SetBearerToken();
            appSettings.LogSettings();
            services.AddSingleton<IConfigurationRoot>(configuration);
            services.AddSingleton<AppSetting>(appSettings);
            services.AddTransient<HttpHelper, HttpHelper>();
            
            services.AddTransient<KubernetesContainerProcessing, KubernetesContainerProcessing>();            
            services.AddControllers(o => o.InputFormatters.Insert(o.InputFormatters.Count, new TextPlainInputFormatter()));

            services.AddSwaggerGen();
            Callbacker.respath = appSettings.ResultVolume.MountPath;
            Task.Run((Action)Callbacker.run);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            EventLogger.logUrl = $"{Configuration["LogService:Host"]}{Configuration["LogService:EventAppId"]}/";
            EventLogger.logSecret = Configuration["LogService:EventSecret"];
            EventLogger.logName = Configuration["LogService:EventName"];
            EventLogger.level = (EventSeverity)Enum.Parse(typeof(EventSeverity), Configuration["LogService:EventLevel"]);

            app.UseRouting();

            app.UseAuthorization();
            app.UseDeveloperExceptionPage();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Infrastructure management");
            });
        }
    }
}
