using Refit;

using TestControlPanel.Models;

namespace TestControlPanel.Client.Pages
{
    public partial class FetchData
    {
        #region Fields & Properties
        private IEnumerable<WeatherForecastViewModel>? forecasts;
        #endregion

        #region Tasks & Methods
        protected override async Task OnInitializedAsync()
        {
            await GetWeatherForecast();
        }
        private async Task GetWeatherForecast()
        {
            try
            {
                var response = await weatherService.GetWeatherForecast();
                if (response != null && response.Succeeded && response.ResponseCode == Models.Enums.ResponseCode.Success && response.Data != null && response.Data.Any())
                {
                    forecasts = response.Data;
                }
            }
            catch (Exception ex) when (ex is HttpRequestException or ApiException)
            {
                logger.LogError(ex, ex.Message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
        }
        #endregion
    }
}