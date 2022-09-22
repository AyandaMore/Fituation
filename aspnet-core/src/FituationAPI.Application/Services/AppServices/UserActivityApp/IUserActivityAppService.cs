using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FituationAPI.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Services.AppServices.UserActivityApp
{
    public interface IUserActivityAppService: IApplicationService
    {
        Task<UserActivityDto> CreateAsync(UserActivityDto input);
        Task<UserActivityDto> UpdateAsync(UserActivityDto input);
        Task<PagedResultDto<UserActivityDto>> GetAllAsync(PagedAndSortedResultRequestDto input);
        Task<PagedResultDto<UserActivityDto>> GetAsync(Guid id);

        Task DeleteAsync(Guid id);
    }
}
