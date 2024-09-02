using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraLoopOefeningen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "Rick";
            string userPw = "";
            

            while (userPw != password) //selama user memasukan angaka yang salah maka akan terus berjalan.
            {

                Console.Write("Please enter a password and minimum 4 leters: ");
                userPw = Console.ReadLine();
                Console.Clear();
                if (userPw != password)
                {
 
                    Console.WriteLine("you entered a wrong password..\nplease try again.\n");
                      
                }
                else
                {
                    Console.WriteLine("Success..\nYou entered the correct password.");
                    Console.WriteLine("Welcome to the cloub");
                    Console.ReadLine();
                }
                
               
            }

        }
        
    }
}
