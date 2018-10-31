using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    
    public class H_User
    {
        UserDAO dao = new UserDAO();
        public static H_User userBUS = new H_User();
        public DataTable SelectAll()
        {
            string query = "select u.userID, u.fullName, u.tel, u.address  from [User] u";
            DataTable dt = new DataTable();
            dt = dao.GetTable(query);
            return dt;
        }

        public Entity.User getUser(String uname,String psw)
        {
            return dao.getUser(uname, psw);
        }

        public Boolean  isExitedUName(string uname)
        {
            return dao.isExitedUName(uname);
        }

        public int insertUser(string username, string psw, string fname, string tel, string address)
        {
            return dao.insertUser(username, psw, fname, tel, address);
        }




    }
}
