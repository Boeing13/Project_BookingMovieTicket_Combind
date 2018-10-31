using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class DBContext
    {
        public static SqlConnection getConnection()
        {
            //return new SqlConnection(
            //    ConfigurationManager.ConnectionStrings["BookingTicket"].ConnectionString);

            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            return new SqlConnection(connectionString);

        }

        
    }
}
