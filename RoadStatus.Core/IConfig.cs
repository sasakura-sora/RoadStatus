using System;
using System.Collections.Generic;
using System.Text;

namespace RoadStatus.Core
{
    public interface IConfig
    {
        string AppId();
        string DeveloperId();        
    }
}
