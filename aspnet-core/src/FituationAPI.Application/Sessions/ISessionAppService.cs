using System.Threading.Tasks;
using Abp.Application.Services;
using FituationAPI.Sessions.Dto;

namespace FituationAPI.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
