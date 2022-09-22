using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FituationAPI.Configuration;

namespace FituationAPI.Web.Host.Startup
{
    [DependsOn(
       typeof(FituationAPIWebCoreModule))]
    public class FituationAPIWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FituationAPIWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FituationAPIWebHostModule).GetAssembly());
        }
    }
}
