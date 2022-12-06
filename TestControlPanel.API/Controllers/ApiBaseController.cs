using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace TestControlPanel.API.Controllers
{
    public class ApiBaseController<T> : ControllerBase where T : class
    {
        #region Properties & Fields

        protected readonly ILogger<T> logger;

        #endregion Properties & Fields

        #region Constructor

        public ApiBaseController(ILogger<T> logger)
        {
            this.logger = logger;
        }

        #endregion Constructor

        #region Tasks & Methods
        protected virtual void Log(LogLevel logLevel, string? getTypeName, string? getCurrentMethodName, string? message = default, object? json = default, object? response = default)
        {
            try
            {
                string requestJson = json != null ? $"\nRequest Json :{JsonSerializer.Serialize(json)}" : string.Empty;
                string responseJson = response != null ? $"\nResponse Json {JsonSerializer.Serialize(response)}" : string.Empty;
                string finalmessage = $"\n{logLevel} Log : Class: {getTypeName}-Method: {getCurrentMethodName} {message}{requestJson}{responseJson}";

                logger.Log(logLevel, finalmessage);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"\nException Occured in {getTypeName}-{getCurrentMethodName}\nMessage : {ex.Message}\nDetails : {ex} ");
            }
        }
        #endregion
    }
}
