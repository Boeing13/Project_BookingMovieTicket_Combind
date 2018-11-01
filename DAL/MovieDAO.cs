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
    public class MovieDAO
    {

        public DataTable GetMoviesByState(bool state)
        {
            string query = "select * from Movie where state = @state";
            SqlParameter parameter = new SqlParameter("@state", state);
            return SqlHelper.ExecuteDataTable(query, CommandType.Text, parameter);
        }

        public DataTable GetAllGenres()
        {
            string query = "select * from Genres";
            return SqlHelper.ExecuteDataTable(query, CommandType.Text, null);
        }

        public string GetGenreName(int genreID)
        {
            string genreName = "";
            string query = "select genreName from Genres where genreID = @genreID";
            SqlDataReader reader = SqlHelper.ExecuteReader(
               query, CommandType.Text, new SqlParameter("@genreID", genreID));
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    genreName = reader.GetString(0);

                }
            }
            return genreName;
        }

        public Movie GetMovieByID(int movieID)
        {
            Movie movie = new Movie();
            string query = "select * from Movie where movieID = @movieID";
            SqlDataReader reader = SqlHelper.ExecuteReader(query, CommandType.Text, 
                new SqlParameter("movieID", movieID));
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    string title = reader.GetString(1);
                    bool state = reader.GetBoolean(2);
                    int genreID = reader.GetInt32(3);
                    string description = reader.GetString(4);
                    movie = new Movie(movieID, title, state, genreID, description);
                }
            }
            return movie;
        }

        public int InsertNewMovie(string title, bool state, int genreID, string description)
        {
            string query = "insert into Movie(title, [state], genreID, [description]) " +
                "values(@title,@state, @genreID, @description)";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@title", title);
            parameters[1] = new SqlParameter("@state", state);
            parameters[2] = new SqlParameter("@genreID", genreID);
            parameters[3] = new SqlParameter("@description", description);
            return SqlHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }

        public int UpdateMovie(Movie movie, int movieID)
        {
            string query = "UPDATE Movie SET title = @title, [state] = @state, " +
                "genreID = @genreID, [description] = @description where movieID = @movieID";
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@title", movie.Title);
            parameters[1] = new SqlParameter("@state", movie.State);
            parameters[2] = new SqlParameter("@genreID", movie.GenreID);
            parameters[3] = new SqlParameter("@description", movie.Description);
            parameters[4] = new SqlParameter("@movieID", movieID);
            return SqlHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }

        public bool CheckDuplicate(string title, bool state, int genreID, string description)
        {
            int stt = 0;
            if (state) stt = 1;
            SqlParameter[] parameters = new SqlParameter[4];
            string query = "select * from Movie " +
                "where title = @title and state = @state and genreID = @genreID " +
                "and description = @description";
            parameters[0] = new SqlParameter("@title", title);
            parameters[1] = new SqlParameter("@state", stt);
            parameters[2] = new SqlParameter("@genreID", genreID);
            parameters[3] = new SqlParameter("@description", description);
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

        public bool IsDuplicateMovie(Movie movie)
        {
            List<Movie> list = new List<Movie>();
            string query = "select * from Movie " +
                "where title = @title and state = @state and genreID = @genreID " +
                "and description = @description";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@title", movie.Title);
            parameters[1] = new SqlParameter("@state", movie.State);
            parameters[2] = new SqlParameter("@genreID", movie.GenreID);
            parameters[3] = new SqlParameter("@description", movie.Description);
            SqlDataReader reader = SqlHelper.ExecuteReader(query, CommandType.Text, parameters);
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    int movieID = reader.GetInt32(0);
                    string title = reader.GetString(1);
                    bool state = reader.GetBoolean(2);
                    int genreID = reader.GetInt32(3);
                    string description = reader.GetString(4);
                    if (movieID != movie.MovieID)
                    {
                        Movie dmovie = new Movie(movieID, title, state, genreID, description);
                        list.Add(dmovie);
                    }
                    
                }
            }
            if(list.Count > 0)
            {
                return true;
            }
            return false;
        }


    }
}
