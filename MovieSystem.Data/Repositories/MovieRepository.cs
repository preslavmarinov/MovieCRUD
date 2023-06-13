using AutoMapper;
using AutoMapper.QueryableExtensions;
using MovieSystem.Data.Entities;
using MovieSystem.Data.Repositories.Interfaces;
using MovieSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieSystemContext _context;
        private readonly IMapper _mapper;
        public MovieRepository(MovieSystemContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Guid CreateMovie(MovieDTO movie)
        {
            Movie movieEntity = _mapper.Map<Movie>(movie);
            movieEntity.Id= Guid.NewGuid();
            _context.Movies.Add(movieEntity);
            _context.SaveChanges();
            return movieEntity.Id;
        }

        public void DeleteMovie(Guid id)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
        }

        public IEnumerable<T> GetAllMovies<T>()
        {
            var movies = _context.Movies.ProjectTo<T>(_mapper.ConfigurationProvider).ToList();
            return movies;
        }

        public MovieDTO GetMovieById(Guid id)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id==id);
            return _mapper.Map<MovieDTO>(movie);
        }

        public Guid UpdateMovie(MovieDTO movie)
        {
            _context.Movies.Update(_mapper.Map<Movie>(movie));
            _context.SaveChanges();
            return movie.Id;
        }
    }
}
