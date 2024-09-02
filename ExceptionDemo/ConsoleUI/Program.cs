using ClassLibraryExeption;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exception Handling simple
            //int x;
            //int y;
            //int result;


            //try
            //{
            //    Console.WriteLine("Enter number 1: ");
            //    x = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter number 2: ");
            //    y = int.Parse(Console.ReadLine());

            //    result = x / y;
            //    Console.WriteLine($"Result from {x} and {y} is {result}");
            //}

            //catch (FormatException ex)
            //{
            //    Console.WriteLine("u dindnt enter a valid number");
            //}
            //catch ( DivideByZeroException ex )
            //{

            //    Console.WriteLine("you cant devide by zero");               
            //}
            //catch( Exception ex ) //Excetion harus di akhir
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}
            #endregion
            string filepath = @"C:\Temp\test.txt";
            string error = null;
            if (!File.Exists(filepath))
            {
                File.WriteAllText(filepath, error);
            }

            DemoClass demos = new DemoClass();
            try
            {
                var result = demos.GrandParantMethode(12);
               // Console.WriteLine("Add Number");
                //string res = Console.ReadLine();
              //  var result = demos.GrandParantMethode(res);
                Console.WriteLine("the resuly is " + result);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine("Wrong data suplied");
                error = ex.StackTrace;
                File.AppendAllText(filepath, ex.StackTrace);
                throw;
                
                //Console.WriteLine(ex.StackTrace);
               // Console.WriteLine("This is inner exeption " + ex.InnerException);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.);
                error = ex.StackTrace;
                File.AppendAllText(filepath, ex.StackTrace);
                throw;
            }
            finally
            {
                Console.WriteLine("Finally block executed"); // ini bagus di gunakan ketika berkerja di File dan Data base 
            }
        }
        
      
    }
}
