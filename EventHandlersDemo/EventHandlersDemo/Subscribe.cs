using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlersDemo
{

    public class Subscribe
    {
        private string _name;
        public Subscribe(string name)
        {
            _name = name;
        }
        public void OnArticelPublished(string message)
        {
            Console.WriteLine($"{_name} ontving melding op {DateTime.Now} {message}");
        }
    }

}
