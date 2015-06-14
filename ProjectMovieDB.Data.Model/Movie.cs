using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMovieDB.Data.Model
{
    public class Movie
    {
        // Create a Primary Key
        public int MovieId { get; set; }
        public string NameOfFilm { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
    }
}
