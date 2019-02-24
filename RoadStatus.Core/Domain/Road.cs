using System;

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

        public String Name { get { return name; } }

        public String Status { get { return status; } }

        public String Description { get { return description; } }
    }
}
