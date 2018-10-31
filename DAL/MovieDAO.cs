using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class MovieDAO
    {
        public DataTable GetTable(string query)
        {
            SqlConnection conn = DBContext.getConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public void NonExecuteQuery(string query)
        {
            SqlConnection conn = new SqlConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }

        public DataTable selectBydate(String date)
        {
            SqlConnection conn = DBContext.getConnection();
            String sql = "select distinct m.title,m.movieID from Schedule s inner join Movie m on s.movieID = m.movieID where s.date = @date";
          
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@date", date));

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable getSelectedTimeByDateAndMID(string date, int mid)
        {
            string sql = "select h.hourID,h.time from Schedule s \n"
                        + " inner join Hour h on s.hourID = h.hourID  where date=@date and movieID=@mid and leftSeat>0";
            SqlConnection conn= DBContext.getConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@date", date));
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@mid", mid));
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

       
        public string getMovieGenre(int mid)
        {
            string str = "";
            string sql = "select genreName from movie m \n"
                        + "inner join genres g on m.genreID = g.genreID \n"
                        + "where m.movieID = @mid";
            
            using (SqlConnection conn = DBContext.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@mid", mid);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    str = read.GetString(0);
                    break;
                }
            }
            return str;
        }

        public string getDescription(int mid)
        {
            string str = "";
            string sql = "select * from Movie where movieID=@mid";
            using (SqlConnection conn = DBContext.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@mid", mid);
                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    str = read.GetString(4);
                    break;
                }

            }
            return str;
        }

        public DataTable getType()
        {
            string sql = "select * from Type";
            SqlConnection conn = DBContext.getConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public int getRoomID(int movieID,int hid, DateTime dateTime, int seats)
        {
            int number=-1;
            int seatTotal = 0;
            string sql = "select * from Schedule where movieID=@mid and date=@date and hourID=@hid and leftSeat>=@seats order by leftSeat asc";
            using (SqlConnection conn = DBContext.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql,conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@mid", movieID);
                command.Parameters.AddWithValue("@date", dateTime);
                command.Parameters.AddWithValue("@hid", hid);
                command.Parameters.AddWithValue("@seats", seats);
                SqlDataReader read= command.ExecuteReader();
               
                while (read.Read())
                {
                    number = read.GetInt32(0);
                    break;
                }
                
            }
            return number;
        }

        public int booKTickets(int rid,int hid,DateTime dateTime,int seat)
        {
            string sql = "update Schedule set leftseat=@seat where roomID=@rid and hourID=@hid and date=@date";
            int result = 0;
            using (SqlConnection conn = DBContext.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@rid", rid);
                command.Parameters.AddWithValue("@hid", hid);
                command.Parameters.AddWithValue("@seat", seat);
                command.Parameters.AddWithValue("@date", dateTime);
               result= command.ExecuteNonQuery();
            }
            return result;
        }

        public double getPrice(int gid)
        {
            string sql = "select * from Type where typeID= @gid";
            double price=0;
            using (SqlConnection conn = DBContext.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@gid", gid);
               SqlDataReader read =  command.ExecuteReader();
                while (read.Read())
                {
                    price = read.GetDouble(2);
                }
            }
            return price;
        }

        public int getNumberOfTickets(int rid, int hid, DateTime dateTime)
        {
            int seatTotal = 0;
            string sql = "select * from Schedule where roomID=@rid and hourID=@hid and date=@date";
            using (SqlConnection conn = DBContext.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@rid", rid);
                command.Parameters.AddWithValue("@hid", hid);
                command.Parameters.AddWithValue("@date", dateTime);
                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    seatTotal = read.GetInt32(4);
                    break;
                }

            }
            return seatTotal;
        }

        public string getRoomName(int rid)
        {
            string sql = "select * from Room where roomID=@rid";
            string roomName = "";
            using (SqlConnection conn = DBContext.getConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sql, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@rid", rid);
                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    roomName = read.GetString(1);
                    break;
                }

            }
            return roomName;
        }

        public int inserInBookingHistory(int uid, int mid, int typeID, int hid, DateTime dateTime, int quantity)
        {
            string sql = "insert into BookingHistory values(@uid,@mid,@typeID,@hid,@date,@quantity)";
            int result = 0;
            using (SqlConnection conn = DBContext.getConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@uid", uid);
                cmd.Parameters.AddWithValue("@mid", mid);
                cmd.Parameters.AddWithValue("@typeID", typeID);
                cmd.Parameters.AddWithValue("@hid", hid);
                cmd.Parameters.AddWithValue("@date", dateTime);
                cmd.Parameters.AddWithValue("@quantity", quantity);
               result= cmd.ExecuteNonQuery();
            }
            return result;

        }

        public DataTable getBookingHistory(int id)
        {
            DataTable dt = new DataTable();
            string sql = "select m.title, g.genreName,t.name,bh.bookedDate,h.time,t.price,bh.quantity,(t.price*bh.quantity) as 'total' from BookingHistory bh "
                        + " inner join Movie m on bh.movieID = m.movieID"
                        + " inner join[Type] t on t.typeID = bh.typeID"
                        + " inner join Hour h on h.hourID = bh.hourID"
                        + " inner join Genres g on g.genreID = m.genreID"
                        + " where bh.userID=@id";
            using (SqlConnection conn = DBContext.getConnection())
            {
                SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
                adap.SelectCommand.Parameters.AddWithValue("@id", id);
                adap.Fill(dt);
            }
            return dt;

        }

    }
}
