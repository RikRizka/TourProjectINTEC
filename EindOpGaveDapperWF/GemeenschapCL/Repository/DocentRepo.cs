using GemeenschapCL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;
using static GemeenschapCL.OpleidingenDbManaer;

namespace GemeenschapCL.Repository
{
    public class DocentRepo
    {
        public List<Docent> GetAllDocent()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Opleidingen")))
            {
                var sql = "Select * from Docenten";
                return connection.Query<Docent>(sql).ToList();
            }
        }
    }
}
