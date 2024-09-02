using ClassOefening._1._1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOefening._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("BE1234567", 5000.00, new DateTime(2023,11,24));
            account.Afbeelden();
            account.Deposite (100);
            
        }
    }
}
