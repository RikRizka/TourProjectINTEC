using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComaSaperatedFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //not so good to use
            //string filePath = @"c:\demo\test.text";

            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "Test.txt";
            string filePath = Path.Combine(projectDirectory, fileName);
           // Console.WriteLine(filePath);
           
            //baca dari file
            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');
                Person person = new Person();
                person.FirstName = entries[0];
                person.LastName = entries[1];
                person.Address = entries[2];
                people.Add(person);
            }
            Console.WriteLine("Read form text file");
            foreach (var item in people)
            {
                Console.WriteLine($"{item.FirstName},{item.LastName},{item.Address}");
            }
            //END reading File

            //Begin writing into File
            Console.WriteLine("Write to file");
            people.Add(new Person { FirstName = "Rik", LastName = "ALain", Address ="Rick's Address"});
            people.Add(new Person { FirstName = "Alain", LastName = "Charlier", Address ="Alain's Address"});
            
            List <string> output = new List<string>();
            foreach (Person person in people)
            {
                output.Add($"{person.FirstName.Trim()+","} {person.LastName} {person.Address}");
            }
            File.WriteAllLines(filePath, output);
            Console.WriteLine("Records(s) saved in the text file");
            Console.ReadLine();
        }
    }
}
