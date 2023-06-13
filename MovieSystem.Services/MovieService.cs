using MovieSystem.Data.Repositories.Interfaces;
using MovieSystem.Domain.DTO;
using MovieSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Guid CreateMovie(MovieDTO movie) => _movieRepository.CreateMovie(movie);

        public void DeleteMovie(Guid id) => _movieRepository.DeleteMovie(id);

        public IEnumerable<T> GetAllMovies<T>() => _movieRepository.GetAllMovies<T>();

        public MovieDTO GetMovieById(Guid id) => _movieRepository.GetMovieById(id);

        public Guid UpdateMovie(MovieDTO movie) => _movieRepository.UpdateMovie(movie);
    }
}
