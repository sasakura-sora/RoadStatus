using System;
using System.Collections.Generic;
using System.Text;

namespace RoadStatus.Core.Data
{
    public class RoadData
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string statusSeverity { get; set; }
        public string statusSeverityDescription { get; set; }
    }
}
