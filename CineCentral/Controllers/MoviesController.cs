using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CineCentral.Models;
//using CineCentral.ViewModels;

namespace CineCentral.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "No way Home" };
            return View(movie);
        }

        //GET : Movies/
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }
        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Fast and Furious" },
                new Movie { Id = 2, Name = "End Game Avengers !" }
            };
        }
    }
}