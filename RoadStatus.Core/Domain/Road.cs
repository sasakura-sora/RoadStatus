namespace RoadStatus.Core.Domain
{
    public class Road
    {
        private readonly string description;
        private readonly string status;
        private readonly string name;

        public Road()
        {
            this.name = string.Empty;
            this.status = string.Empty;
            this.description = string.Empty;
        }

        public Road(string name, string status, string description)
        {
            this.name = name;
            this.status = status;
            this.description = description;
        }

        public string Name => name;
        public string Status => status;
        public string Description => description;
    }
}
