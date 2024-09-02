using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VokalAIUEO9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vokal = { 'a', 'i', 'u', 'e', 'o' };
            Console.WriteLine("Enter a sentence");
            string userSentence = Console.ReadLine();
            int hasil = Sentence(vokal, userSentence);
            Console.WriteLine(hasil);
            
        }
        static int Sentence(char[] vokal, userSentence)
        {
            int jumSentence = 0;

            foreach (var sentences in string userSentence)
            {
                if (userSentence == 'a' || sentences == 'i' || sentences == 'u' || sentences == 'e' ||
                    sentences == 'o')
                {
                    jumSentence++;
                }             
            }
            return jumSentence;
        }
         
    }
}
