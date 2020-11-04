using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Repository
{
    public class MovieRepository
    {
        public List<MovieModel> GetAllMovies()
        {
            return DataSource();
        }

        public MovieModel GetMovieById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<MovieModel> SearchMovie(string title, string director)
        {
            return DataSource().Where(x => x.Title == title && x.Director == director).ToList();
        }

        private List<MovieModel> DataSource()
        {
            return new List<MovieModel>()
            {
                new MovieModel() {Id = 1, Title = "ComedyMovie1", Director = "John Doe" },
                new MovieModel() {Id = 2, Title = "RomanceMovie2", Director = "Wonsang" },
                new MovieModel() {Id = 3, Title = "ActionMovie3", Director = "Eric Nguyen" },
                new MovieModel() {Id = 4, Title = "ThrillerMovie4", Director = "James Smith" },
                new MovieModel() {Id = 5, Title = "BoringMovie5", Director = "Donald Trump" },
            };
        }
    }
}
