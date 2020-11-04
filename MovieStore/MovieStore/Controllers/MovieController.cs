using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Models;
using MovieStore.Repository;

namespace MovieStore.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieRepository _movieRepository= null;
            
        public MovieController()
        {
            _movieRepository = new MovieRepository();
        }

        public ViewResult GetAllMovies()
        {
            var data = _movieRepository.GetAllMovies();

            return View();
        }

        public MovieModel GetMovie(int id)
        {
            return _movieRepository.GetMovieById(id);
        }

        public List<MovieModel> SearchMovies(string title, string director)
        {
            return _movieRepository.SearchMovie(title, director);
        }
    }
}
