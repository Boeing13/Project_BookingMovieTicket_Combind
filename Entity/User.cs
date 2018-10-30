using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User
    {
        private int userID;

        public int UserID {
            get { return userID; }
            set { userID = value; }
        }

        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string fullName;
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        private string tel;
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        

        public User()
        {

        }

        public User(int userID, string username, string password, 
                string fullName, string tel, string address)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.fullName = fullName;
            this.tel = tel;
            this.address = address;
        }
    }
}
