using BuberDinner.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Domain.Entities
{
    public class Dinner : BaseEntity
    {
        public int OrderId { get; set; }
        public string SomeUniqueThingInDb { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;

        // Behavior relating to Dinner should live here. That's what we mean by rich domain model.

        public int GetCostOfDinner()
        {
            if (Reason == "Wedding")
            {
                return 2000;
            }
            else
            {
                return 20;
            }
        }
    }
}
