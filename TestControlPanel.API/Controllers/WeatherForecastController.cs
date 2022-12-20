using Microsoft.AspNetCore.Mvc;

using TestControlPanel.Application.Interfaces;
using TestControlPanel.Models;
using TestControlPanel.Models.Wrappers;

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
        public async Task<Response<IEnumerable<WeatherForecastViewModel>>> Get()
        {
            var response = await weatherService.GetWeather();
            return Response<IEnumerable<WeatherForecastViewModel>>.GetSuccess(response);
        }
    }
}