using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_common.Interfaces
{
    public interface IWeatherService
    {
        public Task<WeatherForecast> GetCurrentWeather(); 
    }
}
