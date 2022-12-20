using System.Text.Json.Serialization;

namespace TestControlPanel.Domain.Entities
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [JsonIgnore]
        public string? Summary { get; set; }
    }
}