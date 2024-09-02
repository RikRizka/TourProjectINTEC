using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = @"c:\TempTest\TestFile1.txt";
            WriteToFile(file);
            ReadfromFile(file);
                
            
        }
        public static void WriteToFile(string file)
        {
            StreamWriter writer = new StreamWriter(file, false); // jika false hanya membuat file baru jika true akan menimpa (append text)
            string tempString = string.Empty;

            do
            {
                Console.WriteLine("Enter your name or -1 to exit: ");
                tempString =Console.ReadLine();
                if (tempString != "-1")
                {
                    writer.WriteLine(tempString); // jika banyak informasi tidak laki bikin ReadLine
                }
            } while (tempString != "-1");
            writer.Flush(); //membersihkan
            writer.Close();
        }
        private static void ReadfromFile(string file)
        {
            int count = 0;
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
                count++;
            }
            Console.WriteLine("Total record  in file" + count);
        }

    }
}
