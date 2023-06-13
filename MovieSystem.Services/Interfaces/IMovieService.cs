using MovieSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Services.Interfaces
{
    public interface IMovieService
    {
        Guid CreateMovie(MovieDTO movie);

        Guid UpdateMovie(MovieDTO movie);

        void DeleteMovie(Guid id);

        MovieDTO GetMovieById(Guid id);

        IEnumerable<T> GetAllMovies<T>();
    }
}
