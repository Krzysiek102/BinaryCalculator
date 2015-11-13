using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator.Core
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Trace.TraceInformation(message);
        }
    }
}
