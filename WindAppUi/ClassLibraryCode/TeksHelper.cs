﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCode
{
    public class TeksHelper
    {
        public int Lengte(string input)
        {
            return input.Length;
        }
        public string Omkeren(string input)
        {
            char[] chars = input.ToCharArray(); //hallo
            Array.Reverse(chars);
            return new string(chars); //ollah
        }
        public string NaarHoofdletters(string input)
        {
            return input.ToUpper();
        }
        public bool IsLeeg(string input)
        {
            return string.IsNullOrEmpty(input);
        }
        public string Samenvoegen(string a, string b)
        {
            return a + b;
        }

        public string Analyze(int number)
        {
            if (number > 0)
                return "Positief";
            else if (number < 0)
                return "Negatief";
            else
                return "Null";
        }
    }
}
