using LibraryIO;
using LibraryIO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\TempTest\\books.txt";
         
            //List<Book> books = new List<Book>();
            //books = Processes.PopulateBooks();
            //Processes.WriteToFile(books, path);
            //**********************************************

            var bk = Processes.ReadFromFile(path);

            foreach (Book book in bk)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();
            Console.WriteLine("List sorted by title");

            //List<Book> sortedBook = bk; 
            //sortedBook.Sort();

            bk.Sort();
            foreach (Book book in bk)
            {
                Console.WriteLine(book);
            }
            //*********************************************
            //use lambda expretion to sort by year

           List<Book> books = bk.OrderBy(b => b.Year).ToList(); //Landa sign like goes to be
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            

            Console.WriteLine("Add new book");
            Book newBook = new Book();
            newBook.Title = "Title new";
            newBook.Author = "Rik";
            newBook.Year = 2023;
            Processes.WriteToFIleOneBook(newBook, path);
        }


       
    }
}
