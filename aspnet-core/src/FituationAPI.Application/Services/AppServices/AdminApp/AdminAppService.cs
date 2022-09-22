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

namespace FituationAPI.Services.AppServices.AdminApp
{
    public class AdminAppService : ApplicationService, IAdminAppService
    {
        private readonly IRepository<Admin, Guid> _adminRepository;

        public AdminAppService(IRepository<Admin, Guid> adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public async Task<AdminDto> CreateAsync(AdminDto input)
        {
            var admin = ObjectMapper.Map<Admin>(input);
            await _adminRepository.InsertAsync(admin);
            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<AdminDto>(admin);
        }

        public async Task DeleteAsync(Guid id)
        {
            var admin = await _adminRepository.GetAsync((Guid)id);
            await _adminRepository.DeleteAsync(admin);
        }

        public async Task<PagedResultDto<AdminDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var query = _adminRepository.GetAllIncluding();
            var result = new PagedResultDto<AdminDto>();
            result.TotalCount = query.Count();
            result.Items = ObjectMapper.Map<IReadOnlyList<AdminDto>>(query);
            return await Task.FromResult(result);
        }

        public async Task<PagedResultDto<AdminDto>> GetAsync(Guid id)
        {
            var query = _adminRepository.GetAllIncluding();
            var IdResult = query.Where(data => data.Id == id);
            var result = new PagedResultDto<AdminDto>();
            result.Items = ObjectMapper.Map<IReadOnlyList<AdminDto>>(IdResult);
            return await Task.FromResult(result);
        }

        public async Task<AdminDto> UpdateAsync(AdminDto input)
        {
            var admin = await _adminRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, admin);
            await _adminRepository.UpdateAsync(admin);
            return ObjectMapper.Map<AdminDto>(admin);
        }
    }
}
