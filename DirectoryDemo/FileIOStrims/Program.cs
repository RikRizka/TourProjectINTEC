using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Web;

namespace FileIOStrims
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\TempTest";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine($"Directory {path} has been created");
            }
            else
            {
                Console.WriteLine("Directory Exist you can't create this directory");
            }
            string filePath = @"c:\Temptest\Rick.txt";
            if (!File.Exists(filePath))
            {
                //Create file
                using (FileStream fs = File.Create(filePath))
                {
                    byte[] content = new UTF8Encoding(true).GetBytes("This is only a test");
                    fs.Write(content, 0, content.Length);
                }
                Console.WriteLine(($"File created + {filePath}"));

            }
            else
            {
                Console.WriteLine("File exist! u cant create this file");
            }
        }
    }
}
