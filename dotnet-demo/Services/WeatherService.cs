using dotnet_common;
using dotnet_common.Interfaces;

namespace dotnet_demo.Services
{
    public class WeatherService : IWeatherService
    {
        public Task<WeatherForecast> GetCurrentWeather()
        {
            return Task.FromResult(new WeatherForecast() { Date = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), Summary = "The weather is good.", TemperatureC = 25 });
        }
    }
}
