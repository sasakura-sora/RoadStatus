using RoadStatus.Core.Data;
using RoadStatus.Core.Domain;

namespace RoadStatus.Core.Data
{
    public interface ITflClient
    {
        RoadData Get(string roadId);
    }
}