using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FituationAPI.EntityFrameworkCore;
using FituationAPI.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace FituationAPI.Web.Tests
{
    [DependsOn(
        typeof(FituationAPIWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FituationAPIWebTestModule : AbpModule
    {
        public FituationAPIWebTestModule(FituationAPIEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FituationAPIWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FituationAPIWebMvcModule).Assembly);
        }
    }
}