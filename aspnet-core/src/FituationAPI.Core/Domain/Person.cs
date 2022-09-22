using Abp.Domain.Entities.Auditing;
using FituationAPI.Domain.Discriminators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Domain
{
    [Entity(TypeShortAlias = "Person")]
    [Table("People")]
    [DiscriminatorValue("Person")]
    public class Person : FullAuditedEntity<Guid>
    {
        
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }

        public virtual string Password { get; set; }
    }
}
