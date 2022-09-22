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
    [AutoMap(typeof(Person))]
    public class PersonDto : EntityDto<Guid> 
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
