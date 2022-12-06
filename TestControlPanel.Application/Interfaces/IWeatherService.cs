using TestControlPanel.Models;

namespace TestControlPanel.Application.Interfaces
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherForecastViewModel>> GetWeather();
    }
}