using System.Threading.Tasks;
using FituationAPI.Configuration.Dto;

namespace FituationAPI.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
