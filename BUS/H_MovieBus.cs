using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Data.SqlClient;

namespace BUS
{
    public class H_MovieBus
    {
        MovieDAO dao = new MovieDAO();
        public static H_MovieBus movieBUS = new H_MovieBus();
        public DataTable SelectAll()
        {
            string query = "select * from Movie";
            DataTable dt = new DataTable();
            dt = dao.GetTable(query);
            return dt;
        }

        public DataTable selectBydate(String date)
        {
            return dao.selectBydate(date);
        }

        public DataTable getSelectedByDateAndMID(string date,int mid)
        {
            return dao.getSelectedTimeByDateAndMID(date, mid);
        }

        public DataTable getType()
        {
            return dao.getType();
        }

        public int getRoomID(int movieID, int hid, DateTime dateTime, int seats)
        {
            return dao.getRoomID(movieID, hid, dateTime, seats);
        }

        public string getDescription(int mid)
        {
            return dao.getDescription(mid);
        }

        public string getGenre(int mid)
        {
            return dao.getMovieGenre(mid);
        }

        public double getPrice(int gid)
        {
            return dao.getPrice(gid);
        }

        public int bookTickets(int rid, int hid, DateTime dateTime, int seat)
        {
            return dao.booKTickets(rid,hid,dateTime,seat);
        }

        public int getNumberofTickets(int rid,int hid,DateTime dateTime)
        {
            return dao.getNumberOfTickets(rid, hid, dateTime);
        }

        public string getRoomName(int rid)
        {
            return dao.getRoomName(rid);
        }

        public int inserInBookingHistory(int uid,int mid, int typeID,int hid, DateTime dateTime, int quantity)
        {
           return dao.inserInBookingHistory(uid, mid, typeID, hid, dateTime, quantity);
        }

        public DataTable getBookingHistory(int id)
        {
            return dao.getBookingHistory(id);
        }
    }
}
