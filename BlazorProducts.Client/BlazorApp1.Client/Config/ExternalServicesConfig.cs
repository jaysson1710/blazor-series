

namespace BlazorApp1.Client.Config
{
    public interface IExternalServicesConfig
    {
        string WeatherApiUrl { get; set; }
    }

    public class ExternalServicesConfig : IExternalServicesConfig
    {
        public const string ExternalServices = "ExternalServices";
        public string WeatherApiUrl { get; set; }
    }
}
