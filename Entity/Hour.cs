using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Hour
    {
        public int HourID { get; set; }
        public string Time { get; set; }

        public Hour()
        {
        }

        public Hour(int hourID, string time)
        {
            HourID = hourID;
            Time = time;
        }
    }
}
