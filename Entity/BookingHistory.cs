using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class BookingHistory
    {
        string title;
        string genreName;
        string typeName;
        DateTime date;
        string time;
        double price;
        int quantity;
        double total;

        public BookingHistory(string title, string genreName, string typeName, DateTime date, string time, double price, int quantity, double total)
        {
            this.title = title;
            this.genreName = genreName;
            this.typeName = typeName;
            this.date = date;
            this.time = time;
            this.price = price;
            this.quantity = quantity;
            this.total = total;
        }
    }
}
