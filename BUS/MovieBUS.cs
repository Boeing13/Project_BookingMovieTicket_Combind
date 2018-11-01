using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Entity;

namespace BUS
{
    public class MovieBUS
    {
        MovieDAO dao = new MovieDAO();

        public DataTable GetMoviesByState(bool state)
        {
            return dao.GetMoviesByState(state);
        }

        public DataTable GetAllGenres()
        {
            return dao.GetAllGenres();
        }

        public int InsertNewMovie(string title, bool state, int genreID, string description)
        {
            return dao.InsertNewMovie(title, state, genreID, description);
        }

        public int UpdateMovie(Movie movie, int movieID)
        {
            return dao.UpdateMovie(movie, movieID);
        }

        public bool CheckDuplicate(string title, bool state, int genreID, string description)
        {
            return dao.CheckDuplicate(title, state, genreID, description);
        }

        public bool IsDuplicateMovie(Movie movie)
        {
            return dao.IsDuplicateMovie(movie);
        }

        public string GetGenreName(int genreID)
        {
            return dao.GetGenreName(genreID);
        }

        public Movie GetMovieByID(int movieID)
        {
            return dao.GetMovieByID(movieID);
        }
    }
}
