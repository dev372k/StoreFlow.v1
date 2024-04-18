using Microsoft.Extensions.Configuration;

namespace Shared.Helpers
{
    public class AppConfiguration
    {
        private static IConfigurationRoot _configuration;
        public AppConfiguration()
        {
            var builder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            builder.AddJsonFile(path, false);

            _configuration = builder.Build();
        }
        public static string GetSetting(string key)
        {
            return _configuration[key];
        }
    }
}
