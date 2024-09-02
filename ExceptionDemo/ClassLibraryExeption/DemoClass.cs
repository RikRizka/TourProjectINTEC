
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExeption
{
    public class DemoClass
    {
        public int GrandParantMethode (int position)
        {
            int outout = 0;
            Console.WriteLine("Open Data base Conection");
            try
            {
                outout = ParentMethode(position);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Close Data Basse conection");
            }
            return outout;
        }
       
        private int ParentMethode(int position)
        {
            return GetNumber(position);
        }
        private int GetNumber(int position)
        {
            int output = 0;
            //try
            //{
            int[] numbers = new int[] { 1, 4, 7, 2 };
            output = numbers[position];
            //}
            //catch (Exception ex)
            //{
            //    //Console.WriteLine(ex.Message);
            //    //Console.WriteLine(ex.StackTrace);
            //    throw;
            //}
            return output;

        }
        
    }
    

}
