using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATM
{
    class AtmUnsave
    {
        private object myLock = new object();
        private object myLock1 = new object();
        public decimal cash = 100;
        public void Withdraw100()
        {
            lock (myLock)
            {
                if (cash >= 100)
                {
                    Console.WriteLine("you write 100 euro");
                    cash -= 100;
                    Console.WriteLine($"your still have {cash}");
                }
            }
            
        }
        public void WithdrawThreads()
        {
            
            Thread thread = new Thread(Withdraw100);
            thread.Start();
            Withdraw100();
            if (cash < 0)
            {
                Console.WriteLine("Your cash is negative, we got an huhe problem");
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          //  for 
            AtmUnsave atm = new AtmUnsave();
            //Thread thread = new Thread();
            atm.Withdraw100();
        }
    }
}
