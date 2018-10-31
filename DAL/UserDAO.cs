
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Entity;

namespace DAL
{
    public class UserDAO
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

        public Entity.User getUser(string user,string psw)
        {
            string sql = "select * from [User]";
            SqlConnection conn = DBContext.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
           SqlDataReader reader= cmd.ExecuteReader();
            while (reader.Read())
            {
                string uname = reader.GetString(1);
                string pass = reader.GetString(2);
                if (uname.Equals(user) && pass.Equals(psw))
                {
                    int uid = reader.GetInt32(0);
                    string fullName = reader.GetString(3);
                    string tel = reader.GetString(4);
                    string address = reader.GetString(5);
                    return new Entity.User(uid, uname, pass, fullName, tel, address);
                }
            }
            return null;
        }

        public Boolean isExitedUName(string uname)
        {
            string sql = "select * from [User] where username=@uname";
            using (SqlConnection conn = DBContext.getConnection())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@uname", uname);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public int insertUser(string username,string psw,string fname,string tel,string address)
        {
            string sql = "insert into [User] values(@uname,@psw,@fname,@tel,@address)";
            using(SqlConnection conn = DBContext.getConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uname", username);
                cmd.Parameters.AddWithValue("@psw", psw);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@address", address);
                return cmd.ExecuteNonQuery();
            }
        }





    }
}
