using Refit;

using TestControlPanel.Models;
using TestControlPanel.Models.Wrappers;

namespace TestControlPanel.Client.Services
{
    public interface IWeatherService
    {
        [Get("/WeatherForecast")]
        public Task<Response<IList<WeatherForecastViewModel>>> GetWeatherForecast();
    }
}