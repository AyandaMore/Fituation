using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FituationAPI.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Services.AppServices.AppUserApp
{
    public interface IAppUserAppService : IApplicationService
    {
        Task<AppUserDto> CreateAsync(AppUserDto input);
        Task<AppUserDto> UpdateAsync(AppUserDto input);
        Task<PagedResultDto<AppUserDto>> GetAllAsync(PagedAndSortedResultRequestDto input);
        Task<PagedResultDto<AppUserDto>> GetAsync(string email, string password);

        Task DeleteAsync(Guid id);
    }
}
