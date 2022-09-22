using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using FituationAPI.Domain;
using FituationAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Services.Dto
{
    [AutoMap(typeof(Exercise))]
    public class ExerciseDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public RefListLocation Location { get; set; }

        public RefListBodyTarget BodyTarget { get; set; }

        public RefListIntensity Intensity { get; set; }

        public int CalorieBurn { get; set; }

        public string Link { get; set; }
    }
}
