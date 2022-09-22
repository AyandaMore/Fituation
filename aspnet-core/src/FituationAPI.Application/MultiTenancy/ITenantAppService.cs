using Abp.Application.Services;
using FituationAPI.MultiTenancy.Dto;

namespace FituationAPI.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

