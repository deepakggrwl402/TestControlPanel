using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestControlPanel.Domain.Entities;

namespace TestControlPanel.Domain.Interfaces
{
    public interface IWeatherRepo
    {
        Task<IEnumerable<WeatherForecast>> GetWeather();
    }
}