using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FituationAPI.Controllers
{
    public abstract class FituationAPIControllerBase: AbpController
    {
        protected FituationAPIControllerBase()
        {
            LocalizationSourceName = FituationAPIConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
