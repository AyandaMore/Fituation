using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FituationAPI.Authorization;

namespace FituationAPI
{
    [DependsOn(
        typeof(FituationAPICoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FituationAPIApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FituationAPIAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FituationAPIApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
