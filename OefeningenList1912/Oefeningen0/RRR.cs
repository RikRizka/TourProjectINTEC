using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen0
{
    public class RRR
    {
        public static List<string> GetWords(string userInput)
        {
            string[] intput = userInput.Split(' ');
            return new List<string>(intput);
        }
    }
}
