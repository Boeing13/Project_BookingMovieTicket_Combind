
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
        public DataTable GetAllUser()
        {
            string query = "select u.userID, u.fullName, u.tel, u.[address] from [User] u";
            return SqlHelper.ExecuteDataTable(query, CommandType.Text, null);
        }

    }
}
