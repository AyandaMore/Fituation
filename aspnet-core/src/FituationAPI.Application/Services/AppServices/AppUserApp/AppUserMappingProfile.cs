using AutoMapper;
using FituationAPI.Domain;
using FituationAPI.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Services.AppServices.AppUserApp
{
    public class AppUserMappingProfile: Profile
    {
        public AppUserMappingProfile()
        {
            CreateMap<AppUser, AppUserDto>();

            CreateMap<AppUserDto, AppUser>()
                .ForAllMembers(e => e.Condition((src, dest, member) => member != null));

        }
    }
}
