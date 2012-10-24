using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxmulator.Core
{
    public interface IProcesser
    {
        void ProcessRequest(object args);
    }
}
