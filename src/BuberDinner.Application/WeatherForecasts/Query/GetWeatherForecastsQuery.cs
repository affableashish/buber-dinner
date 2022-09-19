using MediatR;
using BuberDinner.Application.Common.Interfaces;
using BuberDinner.Domain.ValueObjects;
using BuberDinner.Web.Shared.Weatherforecasts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.WeatherForecasts.Query
{
    public record GetWeatherForecastsQuery : IRequest<IEnumerable<WeatherForecastDto>>
    {

    }

    public class GetWeatherForecastsQueryHandler : IRequestHandler<GetWeatherForecastsQuery, IEnumerable<WeatherForecastDto>>
    {
        private readonly IInMemoryDatabase _db;
        public GetWeatherForecastsQueryHandler(IInMemoryDatabase db)
        {
            _db = db;
        }

        public async Task<IEnumerable<WeatherForecastDto>> Handle(GetWeatherForecastsQuery request, CancellationToken cancellationToken)
        {
            var myforecasts = (await _db.GetWeatherForecasts())
                                        .Select(f => new WeatherForecastDto()
                                        {
                                            Date = f.Date,
                                            TemperatureC = f.TemperatureC,
                                            Summary = f.Summary
                                        });
            return myforecasts;
        }
    }
}
