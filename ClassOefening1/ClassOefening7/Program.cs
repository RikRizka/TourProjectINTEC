﻿using ClassOefening7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Toyota", "M20", 2020);
            Console.WriteLine(auto);
        }
    }
}
