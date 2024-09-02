using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCode
{
    public class Logger
    {
        public string LastError { get; set; }
        public void LogMessage(string error)
        {
            LastError = error;
        }
    }
}
