using RoadStatus.Core.Domain;
using System;
using System.Net.Http;

namespace RoadStatus.Core
{
    public class Data
    {
        private HttpClient client;

        private string appId;
        private string devKey;

        public Data(HttpClient client, string appId, string developerKey)
        {
            this.client = client;
            this.appId = appId;
            this.devKey = developerKey;
        }

        public Road Get(string roadId)
        {
            var roadUri = new Uri($"/Road/{roadId}{BuildQueryString()}");

            var data = client.GetAsync(roadUri);

            return new Road();
        }

        public string BuildQueryString()
        {
            return $"?app_id={appId}&app_key={devKey}";
        }
    }
}
