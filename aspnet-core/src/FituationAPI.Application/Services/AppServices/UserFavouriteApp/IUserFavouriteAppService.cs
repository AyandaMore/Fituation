using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FituationAPI.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Services.AppServices.UserFavouriteApp
{
    public interface IUserFavouriteAppService: IApplicationService
    {
        Task<UserFavouriteDto> CreateAsync(UserFavouriteDto input);
        Task<UserFavouriteDto> UpdateAsync(UserFavouriteDto input);
        Task<PagedResultDto<UserFavouriteDto>> GetAllAsync(PagedAndSortedResultRequestDto input);
        Task<PagedResultDto<UserFavouriteDto>> GetAsync(Guid id);

        Task DeleteAsync(Guid id);
    }
}
