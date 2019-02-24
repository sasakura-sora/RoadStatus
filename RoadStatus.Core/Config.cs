using Microsoft.Extensions.Configuration;

namespace RoadStatus.Core
{
    public class Config : IConfig
    {
        private IConfiguration config;

        public Config()
        {
            var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true, true);

            config = builder.Build();
        }

        public string AppId()
        {
            return config.GetSection("AppId").Value;
        }

        public string DeveloperId()
        {
            return config.GetSection("DeveloperId").Value;
        }
    }
}
