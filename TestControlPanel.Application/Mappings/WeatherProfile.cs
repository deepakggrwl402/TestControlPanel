using AutoMapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestControlPanel.Domain.Entities;
using TestControlPanel.Models;

namespace TestControlPanel.Application.Mappings
{
    public class WeatherProfile : Profile
    {
        public WeatherProfile()
        {
            CreateMap<WeatherForecastViewModel, WeatherForecast>();
            //CreateMap<IEnumerable<WeatherForecastViewModel>, IEnumerable<WeatherForecast>>();

            CreateMap<WeatherForecast, WeatherForecastViewModel>();
            //CreateMap<IEnumerable<WeatherForecast>, IEnumerable<WeatherForecastViewModel>>();
        }
    }
}
