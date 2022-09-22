using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using FituationAPI.Domain;
using FituationAPI.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Services.AppServices.UserFavouriteApp
{
    public class UserFavouriteAppService : ApplicationService, IUserFavouriteAppService
    {
        private readonly IRepository<UserFavourite, Guid> _userFavouriteRepository;

        public UserFavouriteAppService(IRepository<UserFavourite, Guid> userFavouriteRepository)
        {
            _userFavouriteRepository = userFavouriteRepository;
        }
        public async Task<UserFavouriteDto> CreateAsync(UserFavouriteDto input)
        {
            var userFavourite = ObjectMapper.Map<UserFavourite>(input);
            await _userFavouriteRepository.InsertAsync(userFavourite);
            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<UserFavouriteDto>(userFavourite);
        }

        public async Task DeleteAsync(Guid id)
        {
            var favourite = await _userFavouriteRepository.GetAsync((Guid)id);
            await _userFavouriteRepository.DeleteAsync(favourite);
        }

        public async Task<PagedResultDto<UserFavouriteDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var query = _userFavouriteRepository.GetAllIncluding();
            var result = new PagedResultDto<UserFavouriteDto>();
            result.TotalCount = query.Count();
            result.Items = ObjectMapper.Map<IReadOnlyList<UserFavouriteDto>>(query);
            return await Task.FromResult(result);
        }

        public async Task<PagedResultDto<UserFavouriteDto>> GetAsync(Guid id)
        {
            var query = _userFavouriteRepository.GetAllIncluding();
            var IdResult = query.Where(data => data.Id == id);
            var result = new PagedResultDto<UserFavouriteDto>();
            result.Items = ObjectMapper.Map<IReadOnlyList<UserFavouriteDto>>(IdResult);
            return await Task.FromResult(result);
        }

        public async Task<UserFavouriteDto> UpdateAsync(UserFavouriteDto input)
        {
            var favourite = await _userFavouriteRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, favourite);
            await _userFavouriteRepository.UpdateAsync(favourite);
            return ObjectMapper.Map<UserFavouriteDto>(favourite);
        }
    }
}
