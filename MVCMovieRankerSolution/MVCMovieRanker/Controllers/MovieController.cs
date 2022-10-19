using Microsoft.AspNetCore.Mvc;
using MVCMovieRanker.Data;
using MVCMovieRanker.Models;
using System.ComponentModel;

namespace MVCMovieRanker.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Movie> objMovieList = _db.Movies;
            return View(objMovieList);
        }

        //GET
        // Method invoked when pressing the Add New Movie Button
        public IActionResult Create()
        {
            // here we create the model directly inside the view
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken] // Prevents Cross Site Request Forgery
        // Method Invoked when pressing the Add Movie Button with Data
        public IActionResult Create(Movie obj)
        {
            if (obj.Score > 100)
            {
                ModelState.AddModelError("Score", "The Score cannot exceed 100 points");
            }
            if (ModelState.IsValid)
            {
                _db.Movies.Add(obj);
                _db.SaveChanges();
                // here we create the model directly inside the view
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var movieFromDb = _db.Movies.Find(id); // will search the PK
            // other ways to retrieve records:
            // var movieFromDbFirst = _db.Movies.FirstOrDefault(u => u.MovieId == id);
            // var movieFromDbSingle = _db.Movies.SingleOrDefault(u => u.MovieId == id);
            
            if (movieFromDb == null)
            {
                return NotFound();
            }
            
            return View(movieFromDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken] // Prevents Cross Site Request Forgery
                                   // Method Invoked when pressing the Add Movie Button with Data
        public IActionResult Edit(Movie obj)
        {
            if (obj.Score > 100)
            {
                ModelState.AddModelError("Score", "The Score cannot exceed 100 points");
            }
            if (ModelState.IsValid)
            {
                _db.Movies.Update(obj);
                _db.SaveChanges();
                // here we create the model directly inside the view
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }

}
