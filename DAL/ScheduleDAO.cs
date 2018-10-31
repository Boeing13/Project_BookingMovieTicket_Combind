using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;

namespace DAL
{
    public class ScheduleDAO
    {
       
        public DataTable GetAllSchedule()
        {
            string query = "select r.name, h.time, m.title, s.date, s.leftSeat  from Schedule s " +
                            " inner join Room r on s.roomID = r.roomID " +
                            " inner join Movie m on s.movieID = m.movieID " +
                            " inner join[Hour] h on s.hourID = h.hourID ";
            return SqlHelper.ExecuteDataTable(query, CommandType.Text, null);
        }

        public DataTable GetAllMovies()
        {
            string query = "select m.movieID, m.title from Movie m order by m.title";
            return SqlHelper.ExecuteDataTable(query, CommandType.Text);
        }

        public DataTable GetAllRooms()
        {
            string query = "select r.roomID, r.name from Room r";
            return SqlHelper.ExecuteDataTable(query, CommandType.Text);
        }

        public DataTable GetAllHours()
        {
            string query = "select h.hourID, h.[time] from Hour h";
            return SqlHelper.ExecuteDataTable(query, CommandType.Text);
        }


        public int GetMovieID(string title)
        {
            string query = "select m.movieID from Movie m where m.title = @title";
            SqlDataReader reader = SqlHelper.ExecuteReader(
                query, CommandType.Text, new SqlParameter("@title", title));
            int movieID = 0;
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    movieID =  reader.GetInt32(0);
                  
                }
            }
            return movieID;
            
        }

        public int GetRoomID(string name)
        {
            string query = "select r.roomID from Room r where r.name = @name";
            SqlDataReader reader = SqlHelper.ExecuteReader(
                query, CommandType.Text, new SqlParameter("@name", name));
            int roomID = 0;
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    roomID = reader.GetInt32(0);

                }
            }
            return roomID;

        }

        public int GetHourID(string time)
        {
            string query = "select h.hourID from Hour h where h.time = @time";
            SqlDataReader reader = SqlHelper.ExecuteReader(
                query, CommandType.Text, new SqlParameter("@time", time));
            int hourID = 0;
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    hourID = reader.GetInt32(0);

                }
            }
            return hourID;

        }

        public bool CheckDuplicate(int roomID, int hourID, string date)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            string query = "select COUNT (*) from Schedule " +
                " where roomID = @roomID and hourID = @hourID and date = @date";
            parameters[0] = new SqlParameter("@roomID", roomID);
            parameters[1] = new SqlParameter("@hourID", hourID);
            parameters[2] = new SqlParameter("@date", date);

            SqlDataReader reader = SqlHelper.ExecuteReader(query, CommandType.Text, parameters);
            int row = 0;
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    row = reader.GetInt32(0);
                }
            }
            if (row > 0)
            {
                return true;
            }
            else
                return false;
               
        }

        
        public int InsertNewSchedule(Schedule schedule) 
        {
            
            string query = "insert into Schedule(roomID, hourID, [date], movieID, leftSeat) " + 
                            " values(@roomID, @hourID, @date, @movieID, @leftSeat)";
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@roomID", schedule.RoomID);
            parameters[1] = new SqlParameter("@hourID", schedule.HourID);
            parameters[2] = new SqlParameter("@date", schedule.Date);
            parameters[3] = new SqlParameter("@movieID", schedule.MovieID);
            parameters[4] = new SqlParameter("@leftSeat", schedule.LeftSeat);
            return SqlHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }

        public int UpdateSchedule(Schedule schedule, int roomID, int hourID, string date)
        {
            string query = "update Schedule set roomID = @roomID, hourID = @hourID, " +
                " [date] = @date, movieID = @movieID, leftSeat = @leftSeat " +
                " where roomID = @roomDK and hourID = @hourDK and [date] = @dateDK";
            SqlParameter[] parameters = new SqlParameter[8];
            parameters[0] = new SqlParameter("@roomID", schedule.RoomID);
            parameters[1] = new SqlParameter("@hourID", schedule.HourID);
            parameters[2] = new SqlParameter("@date", schedule.Date);
            parameters[3] = new SqlParameter("@movieID", schedule.MovieID);
            parameters[4] = new SqlParameter("@leftSeat", schedule.LeftSeat);
            parameters[5] = new SqlParameter("@roomDK", roomID);
            parameters[6] = new SqlParameter("@hourDK", hourID);
            parameters[7] = new SqlParameter("@dateDK", date);
            return SqlHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }
        
        public int UpdateSeatAndMovie(int leftSeat, int movieID, int roomID, int hourID, string date)
        {
            string query = "update Schedule set leftSeat = @leftSeat, movieID = @movieID " +               
                " where roomID = @roomID and hourID = @hourID and [date] = @date";
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@leftSeat", leftSeat);
            parameters[1] = new SqlParameter("@movieID", movieID);
            parameters[2] = new SqlParameter("@roomID", roomID);
            parameters[3] = new SqlParameter("@hourID", hourID);
            parameters[4] = new SqlParameter("@date", date);        
                    
            return SqlHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }
        public int DeleteSchedule(int roomID, int hourID, string date)
        {
            string query = "DELETE FROM Schedule WHERE roomID = @roomID " +
                         "and hourID = @hourID and [date] = @date";
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@roomID", roomID);
            parameters[1] = new SqlParameter("@hourID", hourID);
            parameters[2] = new SqlParameter("@date", date);
            return SqlHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }
    }
}
