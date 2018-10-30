using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public bool State { get; set; }

        public Movie()
        {

        }

        public Movie(int movieID, string title, bool state)
        {
            this.MovieID = movieID;
            this.Title = title;
            this.State = state;
        }
    }
}
