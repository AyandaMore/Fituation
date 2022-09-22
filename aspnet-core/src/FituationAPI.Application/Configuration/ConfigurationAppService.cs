using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FituationAPI.Configuration.Dto;

namespace FituationAPI.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FituationAPIAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
