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

namespace FituationAPI.Services.AppServices.UserActivityApp
{
    public class UserActivityAppService : ApplicationService, IUserActivityAppService
    {
        private readonly IRepository<UserActivity, Guid> _userActivityRepository;

        public UserActivityAppService(IRepository<UserActivity, Guid> userActivityRepository)
        {
            _userActivityRepository = userActivityRepository;
        }
        public async Task<UserActivityDto> CreateAsync(UserActivityDto input)
        {
            var userActivity = ObjectMapper.Map<UserActivity>(input);
            await _userActivityRepository.InsertAsync(userActivity);
            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<UserActivityDto>(userActivity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var activity = await _userActivityRepository.GetAsync((Guid)id);
            await _userActivityRepository.DeleteAsync(activity);
        }

        public async Task<PagedResultDto<UserActivityDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var query = _userActivityRepository.GetAllIncluding();
            var result = new PagedResultDto<UserActivityDto>();
            result.TotalCount = query.Count();
            result.Items = ObjectMapper.Map<IReadOnlyList<UserActivityDto>>(query);
            return await Task.FromResult(result);
        }

        public async Task<PagedResultDto<UserActivityDto>> GetAsync(Guid id)
        {
            var query = _userActivityRepository.GetAllIncluding();
            var IdResult = query.Where(data => data.Id == id);
            var result = new PagedResultDto<UserActivityDto>();
            result.Items = ObjectMapper.Map<IReadOnlyList<UserActivityDto>>(IdResult);
            return await Task.FromResult(result);
        }

        public async Task<UserActivityDto> UpdateAsync(UserActivityDto input)
        {
            var activity = await _userActivityRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, activity);
            await _userActivityRepository.UpdateAsync(activity);
            return ObjectMapper.Map<UserActivityDto>(activity);
        }
    }
}
