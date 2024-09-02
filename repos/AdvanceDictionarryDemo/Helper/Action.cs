using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Action
    {
        private static Pizza FindPizza(Dictionary<int, Pizza> dictPizza, int code)
        {
            Pizza findPizza;

            if (dictPizza.TryGetValue(7, out findPizza))
            {
                Console.WriteLine(findPizza.Name + " " + findPizza.Size);
            }
            else
            {
                Console.WriteLine("is not found");
            }
        }
    }
}
