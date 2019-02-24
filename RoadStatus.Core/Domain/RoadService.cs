using RoadStatus.Core.Data;

namespace RoadStatus.Core.Domain
{
    public class RoadService
    {
        private readonly ITflClient data;

        public RoadService(ITflClient data)
        {
            this.data = data;
        }

        public Road GetStatus(string roadId)
        {
            var road = data.Get(roadId);

            if (road == null)
            {
                return null;
            }

            return new Road(road.displayName, road.statusSeverity, road.statusSeverityDescription);
        }
    }
}
