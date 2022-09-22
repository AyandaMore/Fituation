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

namespace FituationAPI.Services.AppServices.AppUserApp
{
    public class AppUserAppService : ApplicationService, IAppUserAppService
    {
        private readonly IRepository<AppUser, Guid> _appUserRepository;

        public AppUserAppService(IRepository<AppUser, Guid> appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }
        public async Task<AppUserDto> CreateAsync(AppUserDto input)
        {
            var appUser = ObjectMapper.Map<AppUser>(input);
            await _appUserRepository.InsertAsync(appUser);
            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<AppUserDto>(appUser);
        }

        public async Task DeleteAsync(Guid id)
        {
            var appUser = await _appUserRepository.GetAsync((Guid)id);
            await _appUserRepository.DeleteAsync(appUser);
        }

        public async Task<PagedResultDto<AppUserDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var query = _appUserRepository.GetAllIncluding();
            var result = new PagedResultDto<AppUserDto>();
            result.TotalCount = query.Count();
            result.Items = ObjectMapper.Map<IReadOnlyList<AppUserDto>>(query);
            return await Task.FromResult(result);
        }

        public async Task<PagedResultDto<AppUserDto>> GetAsync(string email, string password)
        {
            var query = _appUserRepository.GetAllIncluding().Where(data => data.Email == email && data.Password == password);
            var result = new PagedResultDto<AppUserDto>();
            result.Items = ObjectMapper.Map<IReadOnlyList<AppUserDto>>(query);
            return await Task.FromResult(result);
        }

        public async Task<AppUserDto> UpdateAsync(AppUserDto input)
        {
            var appUser = await _appUserRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, appUser);
            await _appUserRepository.UpdateAsync(appUser);
            return ObjectMapper.Map<AppUserDto>(appUser);
        }
    }
}
