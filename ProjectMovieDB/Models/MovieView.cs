using ProjectMovieDB.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectMovieDB.Models
{
    public class MovieView
    {
        public string Message { get; set; }
        public List<Movie> MovieList { get; set; }
    }
}