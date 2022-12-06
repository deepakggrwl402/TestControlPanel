using Refit;

using TestControlPanel.Models;

namespace TestControlPanel.Client.Services
{
    public interface IWeatherService
    {
        [Get("/WeatherForecast")]
        public Task<IEnumerable<WeatherForecastViewModel>> GetWeatherForecast();
    }
}
