using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Type
    {
        public int TypeID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Type()
        {
        }

        public Type(int typeID, string name, double price)
        {
            TypeID = typeID;
            Name = name;
            Price = price;
        }
    }
}
