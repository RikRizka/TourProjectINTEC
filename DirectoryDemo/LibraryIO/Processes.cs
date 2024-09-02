using LibraryIO.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryIO
{
    public class Processes
    {
        public static void WriteToFile(List<Book> book, string path, bool overwrite)
        {
            using (StreamWriter sw = new StreamWriter(path, overwrite))
            {
                for (int i = 0; i < book.Count; i++)
                {
                    sw.WriteLine(book[i].Title);
                    sw.WriteLine(book[i].Author);
                    sw.WriteLine(book[i].Year);
                    //sw.WriteLine(book[i]);
                }
            }
        }
        public static void WriteToFile(List<Book> book, string path)
        {
            using (StreamWriter sr = new StreamWriter(path, true))
            {
                for (int i = 0; i < book.Count; i++)
                {
                    
                    sr.WriteLine(book[i].Title);
                    sr.WriteLine(book[i].Author);
                    sr.WriteLine(book[i].Year);
                }
            }

        }
        public static List<Book> ReadFromFile( string path)
        {
            using (StreamWriter sr = new StreamWriter(path))
            {
                List<Book> line = new List<Book>(); 
                while (!sr.EndOfStream)
                {
                    Book b = new Book();
                    b.Title = sr.ReadLine();
                   b.Author = sr.ReadLine();
                    b.Year = Convert.ToInt32(sr.ReadLine());
                    line.Add(b);

                }
                return line;
            }

        }
        public static List<Book> PopulateBook()
        {
            List<Book> book = new List<Book>();


            book.Add(new Book { Author = "Rik", Title = "title3", Year = 2010 });
            book.Add(new Book { Author = "Kenan", Title = "title4", Year = 2000 });
            book.Add(new Book { Author = "Eveline", Title = "title5", Year = 2010 });
            book.Add(new Book { Author = "Hasan", Title = "title6", Year = 2010 });
            book.Add(new Book { Author = "Gabriela", Title = "title7", Year = 2010 });
            return book;


        }
        public static void WriteToFIleOneBook(Book book ,string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                Book b = new Book();
                sw.WriteLine(b.Title = book.Title);
                sw.WriteLine(b.Author= book.Author);
                sw.WriteLine(b.Year = book.Year);
            }
        }
    }
}
