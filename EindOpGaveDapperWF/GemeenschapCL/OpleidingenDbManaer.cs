using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using GemeenschapCL.Models;
namespace GemeenschapCL
{
    public class OpleidingenDbManaer
    {
        public class Helper
        {
            public static string ConStr(string name)
            {
                return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }

        }    
    }
}
