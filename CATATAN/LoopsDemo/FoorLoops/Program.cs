using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FoorLoops
{
    internal class Program
    {
        //for loop
        //while loop
        //do while loop
        //foreach loop
        static void Main(string[] args)
        {
            #region for loop
            //for (int ageMikey = 1; ageMikey <= 70; ageMikey++) //deze kondisi suoer belangrrijk
            //{
            //    Console.WriteLine($"mike's age{ageMikey} Header got a pie with{ageMikey * 2}candle");
            //}
            #endregion

            #region do while;
            #endregion

            #region for loop with string 
            //kan overeal more adfance
            string myString = "Hello word";
            for (int i = 0; i < myString.Length; i++)
            {
                Console.WriteLine(myString[i]);
            }
            #endregion

            #region for each loop // kan je niet overal
            //string myString = "Hello word";
            //foreach (char karakter in myString)
            //{
            //    Console.Write(karakter);
            //}
            #endregion

            #region while loop
            //int i = 1;
            //while (i < 10)
            //{
            //    Console.WriteLine("helo word");
            //    i++;
            //}
            //int y = 0;
            //while (y < 10)
            //{
            //    y++;
            //    if (y == 5) //jika dengan continue maka 5 automatis 5 akan hilang
            //    {

            //        Console.WriteLine("");
            //        continue;
            //    }
            //    Console.WriteLine("hallo " + y);


            //}
            #endregion

            ////  herhalen;

            //int counter = 0;
            //string choice = null;
            //string continueMenu;
            //while (choice != "5") // untuk memberhentiakn 5
            //{
            //    Console.WriteLine("1. say hello");
            //    Console.WriteLine("2. say good bye");
            //    Console.WriteLine("3. say hello");
            //    Console.WriteLine("4. say hello4");
            //    Console.WriteLine("5. say hello5");
            //    Console.WriteLine("6. exit");
            //    choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            Console.WriteLine("hello");
            //            Console.WriteLine("continue? y/n");
            //            continueMenu = Console.ReadLine();
            //            if (continueMenu == "n")
            //            {
            //                Console.WriteLine("");
            //            }
            //            break;

            //        case "2":
            //            Console.WriteLine("good day");
            //            break;
            //        case "3":
            //            Console.WriteLine("good evening");
            //            break;
            //        case "4":
            //            Console.WriteLine("good night");
            //            break;
            //        case "5":
            //        case "6":
            //        case "7":
            //        case "8":
            //        case "9":
            //            break;
            //            Console.WriteLine("byeee");
            //            return;





            //    }




            //}
            //Console.WriteLine($"choice{choice} continue menu");

        }


    }
    }
