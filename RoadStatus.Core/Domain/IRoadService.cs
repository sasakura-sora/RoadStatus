using System.Threading.Tasks;

namespace RoadStatus.Core.Domain
{
    public interface IRoadService
    {
        Task<Road> GetStatus(string roadId);
    }
}