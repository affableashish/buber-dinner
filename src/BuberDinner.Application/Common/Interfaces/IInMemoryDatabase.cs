using BuberDinner.Domain.Entities;
using BuberDinner.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Common.Interfaces
{
    public interface IInMemoryDatabase
    {
        Task<IEnumerable<WeatherForecast>> GetWeatherForecasts();

        Task<IEnumerable<BuberDinner.Domain.Entities.Dinner>> GetDinners();
    }
}
