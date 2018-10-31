using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class MovieDAO
    {
        public DataTable GetTable(string query)
        {
            SqlConnection conn = DBContext.getConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public void NonExecuteQuery(string query)
        {
            SqlConnection conn = new SqlConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
    }
}
