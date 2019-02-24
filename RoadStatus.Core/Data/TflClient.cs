using RoadStatus.Core.Domain;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RoadStatus.Core.Data
{
    public class TflClient : ITflClient
    {
        private HttpClient client;

        private string appId;
        private string devKey;

        public TflClient(IConfig config)
        {
            this.client = new HttpClient
            {
                BaseAddress = new Uri("https://api.tfl.gov.uk")
            };

            this.appId = config.AppId();
            this.devKey = config.DeveloperId();
        }

        public async Task<RoadData> Get(string roadId)
        {
            var roadUri = new Uri($"/Road/{roadId}{BuildQueryString()}", uriKind: UriKind.Relative);

            var data = await client.GetAsync(roadUri);

            return new RoadData();
        }

        public string BuildQueryString()
        {
            return $"?app_id={appId}&app_key={devKey}";
        }
    }
}
