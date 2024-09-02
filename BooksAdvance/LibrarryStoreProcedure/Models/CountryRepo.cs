using Dapper;
using LibrarryStoreProcedure.Conection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarryStoreProcedure.Models
{
    public class CountryRepo
    {
       public List<Country> GetCountrys()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                var countries = connection.Query<Country>("GetAllCountries", 
                    commandType:CommandType.StoredProcedure).ToList();
                return countries;
            }

        }
    }
}
