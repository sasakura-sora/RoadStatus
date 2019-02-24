using RoadStatus.Core.Domain;
using System;
using System.Net.Http;

namespace RoadStatus.Core
{
    public class Data
    {
        public Data(HttpClient client)
        {

        }

        public Road Get(string roadId)
        {
            return new Road();
        }
    }
}
