using Refit;
using System.Net.Http.Json;
using TestControlPanel.Client.Services;
using TestControlPanel.Client.Settings;
using TestControlPanel.Models.Constants;
using Microsoft.Extensions.DependencyInjection;

namespace TestControlPanel.Client.Extensions
{
    public static class ServiceExtensions
    {
        public static void AppServiceProvider(this IServiceCollection services)
        {
            services.AddSingleton(services.BuildServiceProvider());
        }
        public static async Task AddAppSettings(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            var httpClient = serviceProvider.GetRequiredService<HttpClient>();
            var appsettings = await httpClient.GetFromJsonAsync<AppSettings>(AppConstants.UISettings.AppSettings);
            services.AddSingleton(appsettings!);
        }
        public static void AddRefitService(this IServiceCollection services)
        {
            AppSettings appSettings = services.BuildServiceProvider().GetRequiredService<AppSettings>();

            RefitSettings settings = new();
            TimeSpan timeSpan = appSettings.RefitTimeoutInSeconds > 0
                ? TimeSpan.FromSeconds(appSettings.RefitTimeoutInSeconds) : TimeSpan.FromMinutes(1);

            _ = services.AddRefitClient<IWeatherService>(settings)
              .ConfigureHttpClient(c =>
              {
                  c.BaseAddress = new Uri(appSettings!.BaseUrls!.HttpBaseUrl!);
                  c.Timeout = timeSpan;
              });
        }

    }
}
