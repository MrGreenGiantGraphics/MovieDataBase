using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectMovieDB.Data.Model;

namespace ProjectMovieDB.Models
{
    public class ActorView
    {
        public string Message { get; set; }
        public Movie Movie { get; set; }
        public List<Actor> Actors { get; set; } 
    }
}