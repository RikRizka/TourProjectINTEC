using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class TV
    {
        private int BouwJaar;
        public string Merk;
        public int SchermGroote;

        public override string ToString()
        {
            return $"BouJaar: {BouwJaar}, Merk: {Merk}, SchermGroote: {SchermGroote}";
        }
        public void SetBouwJaar(int bouwJaar)
        {
            if (BouwJaar < 2013)
            {
                Console.WriteLine("Boujaar mag niet kleiner dan 2013");
                return;
            }
            BouwJaar = bouwJaar;
        }
        public int GetBouwJaar()
        {
            return BouwJaar;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TV tv1 = new TV() { Merk = "Samsung", SchermGroote = 42 };
            tv1.SetBouwJaar(2012);

           
            TV tv2 = new TV() { Merk = "Sam", SchermGroote = 41 };
            tv2.SetBouwJaar(2015);

            TV tv3 = new TV() { Merk = "Sani", SchermGroote = 15 };
            tv3.SetBouwJaar(2018);

            Console.WriteLine(tv1.GetBouwJaar());
            Console.WriteLine(tv2.GetBouwJaar());
            Console.WriteLine(tv3.GetBouwJaar());

        }
       
        
    }
}
