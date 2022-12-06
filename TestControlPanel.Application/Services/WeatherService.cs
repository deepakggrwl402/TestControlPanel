﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestControlPanel.Application.Interfaces;
using TestControlPanel.Domain.Interfaces;
using TestControlPanel.Models;

namespace TestControlPanel.Application.Services
{
    public class WeatherService : IWeatherService
    {
        #region Fields, Properties & Construtor
        private readonly IWeatherRepo weatherRepo;

        public WeatherService(IWeatherRepo weatherRepo)
        {
            this.weatherRepo = weatherRepo;
        }
        #endregion

        #region Tasks & Methods

        public async Task<IEnumerable<WeatherForecastViewModel>> GetWeather()
        {
            var entity = await weatherRepo.GetWeather();

            return default;
        }

        #endregion
    }
}