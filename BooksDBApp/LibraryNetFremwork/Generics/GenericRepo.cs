using ClassLibraryBooks.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace LibraryNetFremwork.Generics
{
    public class GenericRepo
    {
        public List<T> LoadData<T, U>(String sqlstatment, U parameters)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                List<T> result = connection.Query<T>(sqlstatment, parameters).ToList();
                return result;
            }
        }
        public void SaveData<T, U>(String sqlstatment, U parameters)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                connection.Execute(sqlstatment, parameters);
            }
        }
    }
}
