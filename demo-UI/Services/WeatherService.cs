using dotnet_common;
using dotnet_common.Interfaces;
using System.Net.Http.Json;

namespace demo_UI.Services
{
    public class WeatherService : IWeatherService
    {
        private HttpClient _httpClient { get; }

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherForecast> GetCurrentWeather()
        {
            return await this._httpClient.GetFromJsonAsync<WeatherForecast>("https://localhost:7034/WeatherForecast/GetCurrentWeather");
        }
    }
}
