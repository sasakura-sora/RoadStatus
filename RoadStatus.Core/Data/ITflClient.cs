using System.Threading.Tasks;

namespace RoadStatus.Core.Data
{
    public interface ITflClient
    {
        Task<RoadData> Get(string roadId);
    }
}