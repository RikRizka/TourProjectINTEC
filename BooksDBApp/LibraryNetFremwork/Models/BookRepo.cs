using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using System.Linq;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using LibraryNetFremwork.Generics;
namespace ClassLibraryBooks.Models
{
    public class BookRepo
    {
        private GenericRepo repo = new GenericRepo();
        public int AddBookReturnId(Book book)
        {
            string sql = "Insert Into Docenten (Title,Author,Prijs,Describe,CountryId)" +
                "Values(@Title, @Author, @Prijs, @Describe, @CountryId)" +
                "Select Cast(SCOPE_IDENTITY()as int)";

            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                var returnId = connection.Query<int>(sql, book).SingleOrDefault();
                //book.Id = returnId
                return returnId;
            }
        }
        public List<Book> GetAllBooks()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                //With Generic Repo
                var sql = "Select * from Book";
                return repo.LoadData<Book, dynamic>(sql, new { });

                //WithoudGEneric
                //var sql = "Select * from Book";
                //return connection.Query<Book>(sql).ToList();
            }

        }
        public void DeletBookById(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {

                connection.Execute("Delete from book where Id = @id", new { Id = id });
                //connection.Execute($"{sql}");
                // connection.Execute(sql.ToString());
            }
        }
        public void UpdateBook(Book book)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                connection.Execute("Update Book Set Title =@Title," +
                "Author = @Author,Prijs = @Prijs, Describe = @Describe ,CountryId =  @CountryId  Where Id=@Id",
                    new
                    {
                        Title = book.Title,
                        Author = book.Author,
                        Prijs = book.Prijs,
                        Describe = book.Describe,
                        CountryId = book.CountryId,
                        Id = book.Id,
                    });
            }
        }
    }
}
