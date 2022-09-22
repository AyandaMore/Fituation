using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Domain.Enums
{
    public enum RefListBodyTarget : int
    {
        [Description("1. Full Body")]
        FullBody = 1,

        [Description("2. Abs")]
        Abs = 2,

        [Description("3. Glutes")]
        Glutes = 3,

        [Description("4. Legs")]
        Legs = 4,

        [Description("5. Upper Body")]
        UpperBody = 5
    }
}
