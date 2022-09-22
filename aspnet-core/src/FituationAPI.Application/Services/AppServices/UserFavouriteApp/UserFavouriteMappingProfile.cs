using AutoMapper;
using FituationAPI.Domain;
using FituationAPI.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Services.AppServices.UserFavouriteApp
{
    public class UserFavouriteMappingProfile: Profile
    {
        public UserFavouriteMappingProfile()
        {
            CreateMap<UserFavourite, UserFavouriteDto>();

            CreateMap<UserFavouriteDto, UserFavourite>()
                .ForAllMembers(e => e.Condition((src, dest, member) => member != null));

        }
    }
}
