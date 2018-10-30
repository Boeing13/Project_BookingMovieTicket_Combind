using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class SqlHelper
    {
        /// <summary>
        /// method execute query 
        /// </summary>
        /// <param name="query">Query sql or name of store Procedure</param>
        /// <param name="commandType">Command Type</param>
        /// <param name="parameters">parameters List</param>
        /// <returns>rows affected</returns>
        public static int ExecuteNonQuery(string query, CommandType commandType, params SqlParameter[] parameters)
        {
            SqlConnection connection = DBContext.getConnection();
            
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = commandType;
                cmd.CommandText = query;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                connection.Open();
                return cmd.ExecuteNonQuery();
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string query, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                SqlConnection connection = DBContext.getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = commandType;
                cmd.CommandText = query;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                connection.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string query, CommandType commandType, params SqlParameter[] parameters)
        {
            SqlConnection connection = DBContext.getConnection();
            
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = commandType;
                cmd.CommandText = query;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                return ds;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string query, CommandType commandType, params SqlParameter[] parameters)
        {
            SqlConnection connection = DBContext.getConnection();
            
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = commandType;
            cmd.CommandText = query;
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
            
        }
    }
}
