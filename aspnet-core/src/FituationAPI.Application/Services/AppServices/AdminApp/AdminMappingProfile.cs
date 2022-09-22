using AutoMapper;
using FituationAPI.Domain;
using FituationAPI.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Services.AppServices.AdminApp
{
    public class AdminMappingProfile : Profile
    {
        public AdminMappingProfile()
        {
            CreateMap<Admin, AdminDto>();

            CreateMap<AdminDto, Admin>()
                .ForAllMembers(e => e.Condition((src, dest, member) => member != null));

        }
    }
}
