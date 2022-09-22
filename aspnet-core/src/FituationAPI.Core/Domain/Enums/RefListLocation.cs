using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Domain.Enums
{
    public enum RefListLocation : int
    {
        [Description("1. Home")]
        Home = 1,

        [Description("2. Gym")]
        Gym = 2
    }
}
