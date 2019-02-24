using RoadStatus.Core.Data;
using System.Threading.Tasks;

namespace RoadStatus.Core.Domain
{
    public class RoadService : IRoadService
    {
        private readonly ITflClient data;

        public RoadService(ITflClient data)
        {
            this.data = data;
        }

        public async Task<Road> GetStatus(string roadId)
        {
            var road =  await data.Get(roadId);

            if (road == null)
            {
                return null;
            }

            return new Road(road.displayName, road.statusSeverity, road.statusSeverityDescription);
        }
    }
}
