using AutoMapper;

using Microsoft.Extensions.DependencyInjection;

using TestControlPanel.Application.Interfaces;
using TestControlPanel.Application.Mappings;
using TestControlPanel.Application.Services;
using TestControlPanel.Domain.Interfaces;
using TestControlPanel.Infra.Repositories;

namespace TestControlPanel.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ITestCaseService, TestCaseService>();
            services.AddScoped<IWeatherService, WeatherService>();

            //Infra.Data Layer
            services.AddScoped<ITestCaseRepo, TestCaseRepo>();
            services.AddScoped<IWeatherRepo, WeatherRepo>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new WeatherProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}