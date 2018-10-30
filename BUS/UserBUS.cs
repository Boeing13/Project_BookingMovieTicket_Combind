using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class UserBUS
    {
        UserDAO dao = new UserDAO();
        public DataTable GetAllUser()
        {
            return dao.GetAllUser();
        }
    }
}
