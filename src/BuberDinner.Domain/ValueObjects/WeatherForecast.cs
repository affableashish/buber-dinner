using BuberDinner.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Domain.ValueObjects
{
    public class WeatherForecast : ValueObject
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            // Specify which properties ensures that 2 objects are equal. Here if there are 2 weather forecast objects with same Date and same temp then they're equal.
            yield return Date;
            yield return TemperatureC;
        }
    }
}
