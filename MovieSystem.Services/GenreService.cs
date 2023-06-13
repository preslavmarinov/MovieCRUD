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
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository= genreRepository;
        }
        public Guid CreateGenre(GenreDTO genre) => _genreRepository.CreateGenre(genre);

        public void DeleteGenre(Guid id) => _genreRepository.DeleteGenre(id);

        public List<GenreDTO> GetAllGenres() => _genreRepository.GetAllGenres();

        public GenreDTO GetGenreById(Guid id) => _genreRepository.GetGenreById(id);
    }
}
