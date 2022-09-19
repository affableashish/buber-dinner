using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Web.Shared.Dinner
{
    public class DinnerDto
    {
        public int OrderId { get; set; }
        public string SomeUniqueThingInDb { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
    }
}
