using System.Text.Json.Serialization;

namespace TestControlPanel.Models
{
    public class WeatherForecastViewModel
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        [JsonIgnore]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}