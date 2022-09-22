using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FituationAPI.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Services.AppServices.ExerciseApp
{
    public interface IExerciseAppService : IApplicationService
    {
        Task<ExerciseDto> CreateAsync(ExerciseDto input);
        Task<ExerciseDto> UpdateAsync(ExerciseDto input);
        Task<PagedResultDto<ExerciseDto>> GetAllAsync(PagedAndSortedResultRequestDto input);
        Task<PagedResultDto<ExerciseDto>> GetAsync(Guid id);

        Task DeleteAsync(Guid id);
    }
}
