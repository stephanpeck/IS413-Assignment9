using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MovieMate.Models;
namespace MovieMate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IMovieRepository _repository;

        //initialize the context object to reference the context db
        private MovieDBContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, IMovieRepository repository, MovieDBContext ctx)
        {
            _logger = logger;
            _repository = repository;
            context = ctx;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Movie")]
        public IActionResult Movie()
        {
            return View(new MovieModel
            {
            });
        }




        //this loads when the page submits a form
        [HttpPost("Movie")]
        public IActionResult Movie(MovieModel model)
        {

     

            
                //Fills in the values of the film you are editing

                return View(new MovieModel
                {
                    movieID = model.movieID,
                    movieTitle = model.movieTitle,
                    year = model.year,
                    director = model.director,
                    rating = model.rating,
                    edited = model.edited,
                    lentTo = model.lentTo,
                    notes = model.notes


                });


        }

        [HttpGet]
        public IActionResult Podcasts()
        {
            return View();
        }


        [HttpGet]
        public IActionResult allMovies()
        {
            return View(context.MovieModel);
        }


        [HttpPost]
        public IActionResult allMovies(MovieModel newMovie)
        {

     
            //Using UpdateRange allows for editing and adding movies -- if no movie with that specific ID exists, then a new movie will be created, otherwise it will simply update the movie with that ID.
            if (ModelState.IsValid)
            {
                context.MovieModel.UpdateRange(newMovie);
                context.SaveChanges();
                return View("allMovies",
                    context.MovieModel
                    );
            }
            else
            {
                return RedirectToAction();
            }

        }

        //deletes the desired movie from the database
        [HttpPost]
        public IActionResult delete(MovieModel movie)
        {
            context.MovieModel.Remove(movie);
            context.SaveChanges();
            return View("allMovies", context.MovieModel);
        }


    }
}
