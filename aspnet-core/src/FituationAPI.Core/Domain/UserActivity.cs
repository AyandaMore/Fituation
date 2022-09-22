using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Domain
{
    public class UserActivity : FullAuditedEntity<Guid>
    {
        public virtual DateTime Date { get; set; }

        public virtual AppUser User { get; set; }

        public virtual Exercise Exercise { get; set; }
        
        public virtual int CaloriesBurned { get; set; }
    }
}
