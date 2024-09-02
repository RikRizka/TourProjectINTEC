using CSharpPFOefenmap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rekening rek = new Rekening("BE1234",1000, new DateTime(2013,12,7));           
            rek.Setor(100);
            Console.WriteLine(rek.Dispay());
            
        }
    }
}
