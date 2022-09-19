using BuberDinner.Domain.Common;
using BuberDinner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Domain.Events
{
    public class DinnerCreatedEvent : BaseDomainEvent
    {
        public DinnerCreatedEvent(Dinner ro)
        {
            Dinner = ro;
        }
        public Dinner Dinner { get; }
    }
}
