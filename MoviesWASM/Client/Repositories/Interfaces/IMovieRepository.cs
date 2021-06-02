using MoviesWASM.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWASM.Client.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetMovies();
    }
}
