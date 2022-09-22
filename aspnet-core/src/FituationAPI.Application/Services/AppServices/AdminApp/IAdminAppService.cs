using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FituationAPI.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Services.AppServices.AdminApp
{
    public interface IAdminAppService : IApplicationService
    {
        Task<AdminDto> CreateAsync(AdminDto input);
        Task<AdminDto> UpdateAsync(AdminDto input);
        Task<PagedResultDto<AdminDto>> GetAllAsync(PagedAndSortedResultRequestDto input);
        Task<PagedResultDto<AdminDto>> GetAsync(Guid id);

        Task DeleteAsync(Guid id);
    }
}
