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
    [AutoMap(typeof(Admin))]
    public class AdminDto: PersonDto
    {
    }
}
