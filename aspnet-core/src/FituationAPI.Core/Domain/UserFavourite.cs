using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Domain
{
    public class UserFavourite : FullAuditedEntity<Guid>
    {
        public AppUser User { get; set; }
        public Exercise Exercise { get; set; }
    }
}
