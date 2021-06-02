using MoviesWASM.Client.Repositories.Interfaces;
using MoviesWASM.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWASM.Client.Repositories.Implementations
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() { Title = "Spider-Man: Far From Home", ReleaseDate = DateTime.Now },
                new Movie() { Title = "Peaky Blinders", ReleaseDate = DateTime.Now },
                new Movie() { Title = "Vikings", ReleaseDate = DateTime.Now }
            };
        }
    }
}
