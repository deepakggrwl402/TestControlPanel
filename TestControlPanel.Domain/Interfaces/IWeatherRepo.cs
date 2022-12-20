using TestControlPanel.Domain.Entities;

namespace TestControlPanel.Domain.Interfaces
{
    public interface IWeatherRepo
    {
        Task<IEnumerable<WeatherForecast>> GetWeather();
    }
}