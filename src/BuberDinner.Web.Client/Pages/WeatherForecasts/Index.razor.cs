using Microsoft.AspNetCore.Components;
using BuberDinner.Web.Shared.Weatherforecasts;
using System.Net.Http.Json;

namespace BuberDinner.Web.Client.Pages.WeatherForecasts
{
    public partial class Index
    {
        [Inject] private HttpClient Client { get; set; }

        private WeatherForecastDto[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Client.GetFromJsonAsync<WeatherForecastDto[]>("WeatherForecast");
        }
    }
}