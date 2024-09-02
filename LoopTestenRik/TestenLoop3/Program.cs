using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestenLoop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few sentences that u want: ");
            string sentences = Console.ReadLine();

            int numberSentences = 0;
            bool lettersOrNumbers = false; // karena program perlu memulai dengan asumsi bahwa tidak adak
            //kata kata yang sedang di analisi saat belum melihatkarakter apapun dlam kalimat

            foreach (char z in sentences) // yang akan menulang setiap karakter dalam kalimat
            {
                if (char.IsLetterOrDigit(z)) // kalau apakah leter atau angka maka program akan berlanjut
                {
                    lettersOrNumbers = true;
                }
                else
                {
                    if (lettersOrNumbers)
                    {
                        numberSentences++;
                        lettersOrNumbers = false;
                    }
                }
            }
            if (lettersOrNumbers)
            {
                numberSentences++;
            }
            Console.WriteLine("The numbers of in sentence is: " + numberSentences);
            Console.ReadLine();

            Console.WriteLine("Enter few sentences");
            string sentence= Console.ReadLine();    
            
            int numbersSentences = 0;

            string[] remove = sentence.Split(' ');  

            foreach(string removeStr in remove) 
            {
                numbersSentences++;
            }
            Console.WriteLine(numbersSentences);



        }
    }
}
