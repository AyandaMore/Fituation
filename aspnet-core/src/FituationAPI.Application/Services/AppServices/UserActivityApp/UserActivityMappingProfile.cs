using AutoMapper;
using FituationAPI.Domain;
using FituationAPI.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Services.AppServices.UserActivityApp
{
    public class UserActivityMappingProfile: Profile
    {
        public UserActivityMappingProfile()
        {
            CreateMap<UserActivity, UserActivityDto>();

            CreateMap<UserActivityDto, UserActivity>()
                .ForAllMembers(e => e.Condition((src, dest, member) => member != null));

        }
    }
}
