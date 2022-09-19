using BuberDinner.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Domain.Shared
{
    // Objects that have no Id and aren't immutable belong under ValueObjects folder
    public record ClassWithNoIdAndImmutable
    {
    }
}
