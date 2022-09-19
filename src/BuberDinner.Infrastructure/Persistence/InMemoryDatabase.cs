using BuberDinner.Application.Common.Interfaces;
using BuberDinner.Domain.Entities;
using BuberDinner.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Infrastructure.Persistence
{
    public class InMemoryDatabase : IInMemoryDatabase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecasts()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        public async Task<IEnumerable<Dinner>> GetDinners()
        {
            return new Dinner[] {
                new Dinner
                {
                    OrderId = 1,
                    SomeUniqueThingInDb = "Ayo 1",
                    Reason = "Reason 1"
                },
                new Dinner
                {
                    OrderId = 2,
                    SomeUniqueThingInDb = "Ayo 2",
                    Reason = "Reason 2"
                }
            }
            .ToArray();
        }
    }
}
