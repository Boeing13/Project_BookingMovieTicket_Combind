using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Room
    {
        public int RoomID { get; set; }
        public string Name { get; set; }

        public Room()
        {
        }

        public Room(int roomID, string name)
        {
            RoomID = roomID;
            Name = name;
        }
    }
}
