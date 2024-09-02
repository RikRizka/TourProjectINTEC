using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShowOnlychar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with numbers or special chars");
            string word = Console.ReadLine();
           if (CheckIfDigit(word))
            {
                Console.WriteLine("this is number");
            }
           else
            {
                Console.WriteLine("this is not a number");
            }
            //for (int i = 0; i < word.Length; i++)
            //{
            //    char ch = Convert.ToChar(word[i]);
            //    if (char.IsLetter(ch) || char.IsWhiteSpace(ch))
            //    {
            //        Console.WriteLine(ch);
            //    }
            //}

        }
        private static bool CheckIfDigit(string input)
        {
            bool isDigit = false;
            for (int i = 0; i < input.Length; i++)
            {        //mengganti string ke char dan di simpan pada variable ch       
                char ch = Convert.ToChar(input[i]); 
                if (char.IsDigit(ch))
                {
                    isDigit = true;
                }
                else
                {
                    isDigit = false;
                    break;
                }
                
            }
            return isDigit;

        }
    }
}
