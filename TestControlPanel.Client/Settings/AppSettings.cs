namespace TestControlPanel.Client.Settings
{
    public class AppSettings
    {
        public string? Warning { get; set; }
        public BaseUrls? BaseUrls { get; set; }
        public int RefitTimeoutInSeconds { get; set; }
    }


    public class BaseUrls
    {
        public string? HttpBaseUrl { get; set; }
        public string? HttpsBaseUrl { get; set; }
        public string? IISBaseUrl { get; set; }
    }
}
