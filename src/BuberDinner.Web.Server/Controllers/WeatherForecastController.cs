using MediatR;
using Microsoft.AspNetCore.Mvc;
using BuberDinner.Application.WeatherForecasts.Query;
using BuberDinner.Web.Shared.Weatherforecasts;

namespace BuberDinner.Web.Server.Controllers
{
    // [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecastDto>> Get()
        {
            var getWeatherForecastQuery = new GetWeatherForecastsQuery();
            return await _mediator.Send(getWeatherForecastQuery);
        }
    }
}