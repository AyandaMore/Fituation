using Abp.Domain.Entities.Auditing;
using FituationAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Domain
{
    public class Exercise : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public virtual  RefListLocation Location { get; set; }

        public virtual RefListBodyTarget BodyTarget { get; set; }

        public virtual RefListIntensity Intensity { get; set; }

        public virtual int CalorieBurn { get; set; }

        public virtual string Link { get; set; }

    }
}
