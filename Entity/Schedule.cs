using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Schedule
    {
        public int RoomID { get; set; }
        public int HourID { get; set; }
        public int MovieID { get; set; }
        public string RoomName { get; set; }
        public string Time { get; set; }
        public string MovieName { get; set; }
        public string Date { get; set; }
        public int LeftSeat { get; set; }

        public override string ToString()
        {
            return RoomName + "\t" + Time + "\t" + MovieName + "\t" + Date + "\t" + LeftSeat; 
        }
    }
}
