using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen0._1
{
    public class Numbers
    {
        public void DevideBy10()
        {
            Console.WriteLine("Devide by 10: ");
            for (int start = 50; start <= 150; start++)
            {
                List<int> list = new List<int>();
               if (start % 10 == 0)
                {
                   list.Add(start);
                   
                }
                foreach (int i in list)
                {
                    Console.WriteLine(i);
                }

            }

        }
        public void DevideBy3And5()
        {
            Console.WriteLine("\nDevide by 3 and 5: ");
            for (int start = 50; start <= 150; start++)
            {
                if (start % 3 == 0 && start % 5 == 0)
                {
                    Console.WriteLine(start);
                }

            }
        }
    }
}
