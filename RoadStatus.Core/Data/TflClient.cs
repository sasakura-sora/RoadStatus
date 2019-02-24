using RoadStatus.Core.Domain;
using System;
using System.Net.Http;

namespace RoadStatus.Core.Data
{
    public class TflClient : ITflClient
    {
        private HttpClient client;

        private string appId;
        private string devKey;

        public TflClient(HttpClient client, IConfig config)
        {
            this.client = client;
            this.appId = config.AppId();
            this.devKey = config.DeveloperId();
        }

        public RoadData Get(string roadId)
        {
            var roadUri = new Uri($"/Road/{roadId}{BuildQueryString()}");

            var data = client.GetAsync(roadUri);

            return new RoadData();
        }

        public string BuildQueryString()
        {
            return $"?app_id={appId}&app_key={devKey}";
        }
    }
}
