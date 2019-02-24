using System;
using System.Collections.Generic;
using System.Text;

namespace RoadStatus.Core.Domain
{
    public class Road
    {
        private readonly string name;

        public Road()
        {
            this.name = string.Empty;
        }

        public Road(string name)
        {
            this.name = name;
        }

        public String Name { get { return name; } }
    }
}
