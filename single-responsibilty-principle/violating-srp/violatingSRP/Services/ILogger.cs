using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace violatingSRP.Services
{
    public interface ILogger
    {
        void Log(string message);
    }
}