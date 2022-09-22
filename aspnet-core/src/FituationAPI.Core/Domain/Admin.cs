using FituationAPI.Domain.Discriminators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FituationAPI.Domain
{
    [Entity(TypeShortAlias = "Fit.Admin")]
    [DiscriminatorValue("Fit.Admin")]
    public class Admin : Person
    {

    }
}
