using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using FituationAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Services.Dto
{
    [AutoMap(typeof(UserFavourite))]
    public class UserFavouriteDto : EntityDto<Guid>
    {
        public AppUser UserId { get; set; }
        public Exercise ExerciseId { get; set; }
    }
}
