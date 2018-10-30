using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using Entity;

namespace BUS
{
    public class ScheduleBUS
    {
        ScheduleDAO dao = new ScheduleDAO();
        
        public DataTable GetAllSchedule()
        {
            return dao.GetAllSchedule();
        }

        public DataTable GetAllMovies()
        {
            return dao.GetAllMovies();
        }

        public DataTable GetAllRooms()
        {
            return dao.GetAllRooms();
        }

        public DataTable GetAllHours()
        {
            return dao.GetAllHours();
        }

        public int GetMovieID(string title)
        {
            return dao.GetMovieID(title);
        }

        public int GetRoomID(string name)
        {
            return dao.GetRoomID(name);
        }

        public int GetHourID(string time)
        {
            return dao.GetHourID(time);
        }

        public int InsertNewSchedule(Schedule schedule)
        {
            return dao.InsertNewSchedule(schedule);
        }

        public int UpdateSchedule(Schedule schedule, int roomID, int hourID, string date)
        {
            return dao.UpdateSchedule(schedule, roomID, hourID, date);
        }

        public int UpdateSeatAndMovie(int leftSeat, int movieID, int roomID, int hourID, string date)
        {
            return dao.UpdateSeatAndMovie(leftSeat, movieID, roomID, hourID, date);
        }

        public int DeleteSchedule(int roomID, int hourID, string name)
        {
            return dao.DeleteSchedule(roomID, hourID, name);
        }
    }
}
