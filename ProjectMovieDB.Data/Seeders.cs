using ProjectMovieDB.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMovieDB.Data
{
    public static class Seeders
    {
        public static void seed(MovieDBContext database)
        {
            database.Movies.AddOrUpdate(m => new { m.MovieId, m.NameOfFilm, m.Rating, m.Description },
               new Movie
               {
                   NameOfFilm = "Babylon Babies",
                   MovieId = 1,
                   Rating = 10,
                   Description = "Post Apocalyptic"
               },
               new Movie
               {
                   NameOfFilm = "Mad Max",
                   MovieId = 2,
                   Rating = 5,
                   Description = "End of the World"
               },
               new Movie
               {
                   NameOfFilm = "Limitless",
                   MovieId = 3,
                   Rating = 10,
                   Description = "Mind stimulating film"
               }
              );

            database.SaveChanges();
        }
        public static void seedtwo(MovieDBContext database)
        {            

            database.Actors.AddOrUpdate(a => new { a.ActorId, a.ActorFullName, a.Awards, a.MovieId },
                new Actor
                {
                    ActorFullName = "Van Diesel",
                    ActorId = 1,
                    Awards = 0,
                    MovieId = 1

                },
               new Actor
               {
                   ActorFullName = "Mel Gibson",
                   ActorId = 2,
                   Awards = 2,
                   MovieId = 2
               },
              new Actor
              {
                  ActorFullName = "Bradley Cooper",
                  ActorId = 3,
                  Awards = 0,
                  MovieId = 3
              });

            database.SaveChanges();
        }
    }
}
