using AutoMapper;
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
    public class GenreRepository : IGenreRepository
    {
        private readonly MovieSystemContext _context;
        private IMapper _mapper;
        public GenreRepository(MovieSystemContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Guid CreateGenre(GenreDTO genre)
        {
            Genre genreEntity = _mapper.Map<Genre>(genre);
            genreEntity.Id= Guid.NewGuid();
            _context.Genres.Add(genreEntity);
            _context.SaveChanges();
            return genreEntity.Id;
        }

        public void DeleteGenre(Guid id)
        {
            Genre genre = _context.Genres.FirstOrDefault(x => x.Id == id);
            if(genre != null)
            {
                _context.Genres.Remove(genre);
                _context.SaveChanges();
            }
        }

        public List<GenreDTO> GetAllGenres()
        {
            var genres = _context.Genres.ToList();
            return _mapper.Map<List<GenreDTO>>(genres);
        }

        public GenreDTO GetGenreById(Guid id)
        {
            Genre genre = _context.Genres.FirstOrDefault(x =>x.Id == id);
            return _mapper.Map<GenreDTO>(genre);
        }
    }
}
