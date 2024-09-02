using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorryLibrarry
{
    public class LogToFile : ILogger
    {
        public void Log(string message)
        {
           File.WriteAllText("c:\\TempTest\\Log.txt",message);
        }
    }
}
