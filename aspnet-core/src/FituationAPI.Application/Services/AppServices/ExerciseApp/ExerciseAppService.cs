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

namespace FituationAPI.Services.AppServices.ExerciseApp
{
    public class ExerciseAppService : ApplicationService, IExerciseAppService
    {
        private readonly IRepository<Exercise, Guid> _exerciseRepository;

        public ExerciseAppService(IRepository<Exercise, Guid> exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }
        public async Task<ExerciseDto> CreateAsync(ExerciseDto input)
        {
            var exercise = ObjectMapper.Map<Exercise>(input);
            await _exerciseRepository.InsertAsync(exercise);
            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<ExerciseDto>(exercise);
        }

        public async Task DeleteAsync(Guid id)
        {
            var exercise = await _exerciseRepository.GetAsync((Guid)id);
            await _exerciseRepository.DeleteAsync(exercise);
        }

        public async Task<PagedResultDto<ExerciseDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var query = _exerciseRepository.GetAllIncluding();
            var result = new PagedResultDto<ExerciseDto>();
            result.TotalCount = query.Count();
            result.Items = ObjectMapper.Map<IReadOnlyList<ExerciseDto>>(query);
            return await Task.FromResult(result);
        }

        public async Task<PagedResultDto<ExerciseDto>> GetAsync(Guid id)
        {
            var query = _exerciseRepository.GetAllIncluding();
            var IdResult = query.Where(data => data.Id == id);
            var result = new PagedResultDto<ExerciseDto>();
            result.Items = ObjectMapper.Map<IReadOnlyList<ExerciseDto>>(IdResult);
            return await Task.FromResult(result);
        }

        public async Task<ExerciseDto> UpdateAsync(ExerciseDto input)
        {
            var exercise = await _exerciseRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, exercise);
            await _exerciseRepository.UpdateAsync(exercise);
            return ObjectMapper.Map<ExerciseDto>(exercise);
        }
    }
}
