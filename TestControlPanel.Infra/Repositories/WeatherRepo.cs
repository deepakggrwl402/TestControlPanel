using TestControlPanel.Domain.Entities;
using TestControlPanel.Domain.Interfaces;

namespace TestControlPanel.Infra.Repositories
{
    public class WeatherRepo : IWeatherRepo
    {
        #region Fields, Properties & Constructor

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherRepo()
        {
        }

        #endregion Fields, Properties & Constructor

        #region Methods

        public Task<IEnumerable<WeatherForecast>> GetWeather()
        {
            var response = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });

            return Task.FromResult(response);
        }

        #endregion Methods
    }
}