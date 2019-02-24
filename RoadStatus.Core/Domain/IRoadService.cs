namespace RoadStatus.Core.Domain
{
    public interface IRoadService
    {
        Road GetStatus(string roadId);
    }
}