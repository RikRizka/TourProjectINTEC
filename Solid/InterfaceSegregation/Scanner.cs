﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class Scanner : IScan
    {
        public void Scan()
        {
            Console.WriteLine();
        }
    }
}
