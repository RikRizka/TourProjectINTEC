using Dapper;
using LibrarryStoreProcedure.Conection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibrarryStoreProcedure.Models
{
    public class BookRepo
    {
        public void AddBook(Book book)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Title", book.Title);
            param.Add("@Authos", book.Author);
            param.Add("@Price", book.Price);
            param.Add("@CountryId", book.CountryId);
            param.Add("@Deription", book.Description);

            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                connection.Execute("AddBook", param, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Book> GetBooks()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                var books = connection.Query<Book>("GetAllBooks",
                    commandType: CommandType.StoredProcedure).ToList();
                return books;
            }

        }
        public void DeleteBook(Book book)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id",book.Id);
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                connection.Execute("DeletBook", param, commandType: CommandType.StoredProcedure);
            }
        }

    }
           
}
