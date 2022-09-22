using System.Threading.Tasks;
using Abp.Application.Services;
using FituationAPI.Authorization.Accounts.Dto;

namespace FituationAPI.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
