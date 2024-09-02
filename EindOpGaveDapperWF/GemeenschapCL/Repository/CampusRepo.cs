using GemeenschapCL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GemeenschapCL.OpleidingenDbManaer;
using Dapper;

namespace GemeenschapCL.Repository
{
    public class CampusRepo
    {
        public List<Campus> GetAllCampuses()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Opleidingen")))
            {
                var sql = "Select * from Campussen";
                return connection.Query<Campus>(sql).ToList();
            }

        }
    }
}
