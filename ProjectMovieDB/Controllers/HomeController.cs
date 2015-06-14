using ProjectMovieDB.Data;
using ProjectMovieDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMovieDB.Controllers
{
    public class HomeController : Controller
    {
   
        public ActionResult Index()
        {
            MovieView dataM  = new MovieView();
            dataM.Message = "Hello Testing Testing!!!";

            using (MovieDBContext _db = new MovieDBContext())
            {
                dataM.MovieList = _db.Movies.ToList();
            }

            return View(dataM);           
        }

        public ActionResult Details(int id)
        {
            ActorView dataA = new ActorView();
            dataA.Message = "List of all Actors";
            using (MovieDBContext _db = new MovieDBContext())
            {
                var aResults = _db.Actors.Where(a => a.MovieId == id).ToList();
                dataA.Actors = aResults;
                var mResults = _db.Movies.FirstOrDefault(a => a.MovieId == id);
                dataA.Movie = mResults;

            }

            return View(dataA);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}