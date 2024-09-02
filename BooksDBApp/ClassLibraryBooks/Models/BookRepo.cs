using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using System.Data.

namespace ClassLibraryBooks.Models
{
    public class BookRepo 
    {
        public int AddBookReturnId (Book book)
        {
            string sql = "Insert Into Book(Title,Author,Prijs,Describe,CountryId)" +
                "Values(@Title, @Author, @Prijs, @Describe, @CountryId)" +
                "Select Cast(SCOPE_IDENTITY()as int)";

            using (IDbConnection conn = new IDbConnection(sql))
            {

            }
        }
    }
}
