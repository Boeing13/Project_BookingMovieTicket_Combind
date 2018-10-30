using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class MovieBUS
    {
        MovieDAO dao = new MovieDAO();

        public DataTable SelectAll()
        {
            string query = "select * from Movie";
            DataTable dt = new DataTable();
            dt = dao.GetTable(query);
            return dt;
        }
    }
}
