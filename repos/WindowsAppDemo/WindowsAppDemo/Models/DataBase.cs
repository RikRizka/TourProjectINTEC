using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppDemo.Models
{
    public static class DataBase
    {
        public static List<Book> Books { get; set; }
        static public List<Book> PopulateBooks()
        {
            Books = new List<Book>();
            Books.Add(new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", YearPublished = 1937, Genre = "Fantasy" });
            Books.Add(new Book { Title = "The Fellowship of the Ring", Author = "J.R.R. Tolkien", YearPublished = 1954, Genre = "Fantasy" });
            Books.Add(new Book { Title = "The Two Towers", Author = "J.R.R. Tolkien", YearPublished = 1954, Genre = "Fantasy" });
            Books.Add(new Book { Title = "The Return of the King", Author = "J.R.R. Tolkien", YearPublished = 1955, Genre = "Fantasy" });
            Books.Add(new Book { Title = "The Silmarillion", Author = "J.R.R. Tolkien", YearPublished = 1977, Genre = "Fantasy" });
            Books.Add(new Book { Title = "The Children of Hurin", Author = "J.R.R. Tolkien", YearPublished = 2007, Genre = "Fantasy" });
            Books.Add(new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", YearPublished = 1937, Genre = "Fantasy" });
            Books.Add(new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", YearPublished = 1937, Genre = "Fantasy" });
            Books.Add(new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", YearPublished = 1937, Genre = "Fantasy" });
            Books.Add(new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", YearPublished = 1937, Genre = "Fantasy" });
            return Books;
        }
    }
}
    
