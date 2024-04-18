using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Helpers
{
    public static class AppSettingHelper
    {
        private static IConfigurationRoot _configuration;
        static AppSettingHelper()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            _configuration = builder.Build();
        }
        public static string GetSetting(string key)
        {
            return _configuration[key];
        }
    }
}
