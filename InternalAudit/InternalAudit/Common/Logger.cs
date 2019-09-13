using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalAudit.Common
{
    public class Logger : ILogger
    {
        public string Log()
        {
            return "Logged";
        }
    }
}
