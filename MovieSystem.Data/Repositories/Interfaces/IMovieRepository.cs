using MovieSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        MovieDTO GetMovieById(Guid id);
        IEnumerable<T> GetAllMovies<T>();
        Guid CreateMovie(MovieDTO movie);
        Guid UpdateMovie(MovieDTO movie);
        void DeleteMovie(Guid id);
    }
}
