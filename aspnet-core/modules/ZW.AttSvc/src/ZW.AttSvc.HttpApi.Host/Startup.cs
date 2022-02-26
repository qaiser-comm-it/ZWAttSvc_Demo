using ZW.AttSvc.HttpApi.Host;
using Microsoft.AspNetCore.Builder;

using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.Logging;
using ZW.AttSvc.HttpApi.Host;

namespace ZW.AttSvc
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)

        {

            services.AddApplication<AttSvcHttpApiHostModule>();

            services.AddSameSiteCookiePolicy();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)

        {

            app.InitializeApplication();

        }
    }
}
