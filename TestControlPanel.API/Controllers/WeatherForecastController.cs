using Microsoft.AspNetCore.Mvc;

using TestControlPanel.Application.Interfaces;
using TestControlPanel.Models;

namespace TestControlPanel.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ApiBaseController<WeatherForecastController>
    {
        private readonly IWeatherService weatherService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService weatherService) : base(logger)
        {
            this.weatherService = weatherService;
        }


        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecastViewModel>> Get()
        {
            var response = await weatherService.GetWeather();
            return response;
        }
    }
}