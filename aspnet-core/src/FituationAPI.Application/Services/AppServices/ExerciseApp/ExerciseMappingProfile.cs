using AutoMapper;
using FituationAPI.Domain;
using FituationAPI.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Services.AppServices.ExerciseApp
{
    public class ExerciseMappingProfile: Profile
    {
        public ExerciseMappingProfile()
        {
            CreateMap<Exercise, ExerciseDto>();

            CreateMap<ExerciseDto, Exercise>()
                .ForAllMembers(e => e.Condition((src, dest, member) => member != null));

        }
    }
}
