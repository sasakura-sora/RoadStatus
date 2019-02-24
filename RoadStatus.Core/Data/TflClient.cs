using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RoadStatus.Core.Data
{
    public class TflClient : ITflClient
    {
        private HttpClient client;

        private readonly string appId;
        private readonly string devKey;

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
            var roadUri = new Uri($"/Road/{roadId}{BuildQueryString()}", UriKind.Relative);

            var data = await client.GetAsync(roadUri);

            if(data.IsSuccessStatusCode == false)
            {
                return null;
            }

            return DeSeralize(await data.Content.ReadAsStringAsync());            
        }

        public string BuildQueryString()
        {
            return $"?app_id={appId}&app_key={devKey}";
        }

        public RoadData DeSeralize(string message)
        {
            var data = JsonConvert.DeserializeObject<List<RoadData>>(message);

            if(data == null || data.Count == 0)
            {
                return null;
            }

            return data[0];
        }
    }
}
