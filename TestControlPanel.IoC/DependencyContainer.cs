using Microsoft.Extensions.DependencyInjection;

using TestControlPanel.Application.Interfaces;
using TestControlPanel.Application.Services;
using TestControlPanel.Domain.Interfaces;
using TestControlPanel.Infra.Repositories;

namespace TestControlPanel.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ITestCaseService, TestCaseService>();

            //Infra.Data Layer
            services.AddScoped<ITestCaseRepo, TestCaseRepo>();
        }
    }
}