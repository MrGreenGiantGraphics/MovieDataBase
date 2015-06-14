using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMovieDB.Data.Model;

namespace ProjectMovieDB.Data
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext() : base("DefaultConnection") { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
    }
}
