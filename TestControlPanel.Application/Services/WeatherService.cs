using AutoMapper;

using Microsoft.Extensions.Logging;

using TestControlPanel.Application.Interfaces;
using TestControlPanel.Domain.Interfaces;
using TestControlPanel.Models;

namespace TestControlPanel.Application.Services
{
    public class WeatherService : BaseService<WeatherService>, IWeatherService
    {
        #region Fields, Properties & Construtor

        private readonly IWeatherRepo weatherRepo;

        public WeatherService(IMapper mapper, ILogger<WeatherService> logger, IWeatherRepo weatherRepo)
            : base(mapper, logger)
        {
            this.weatherRepo = weatherRepo;
        }

        #endregion Fields, Properties & Construtor

        #region Tasks & Methods

        public async Task<IEnumerable<WeatherForecastViewModel>> GetWeather()
        {
            var entity = await weatherRepo.GetWeather();
            var model = mapper.Map<IEnumerable<WeatherForecastViewModel>>(entity);
            return model;
        }

        #endregion Tasks & Methods
    }
}