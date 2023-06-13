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
    public class DirectorRepository : IDirectorRepository
    {
        private readonly MovieSystemContext _context;
        private readonly IMapper _mapper;

        public DirectorRepository(MovieSystemContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Guid CreateDirector(DirectorDTO director)
        {
            Director directorEntity = _mapper.Map<Director>(director);
            directorEntity.Id = Guid.NewGuid();
            _context.Directors.Add(directorEntity);
            _context.SaveChanges();
            return directorEntity.Id;
        }

        public void DeleteDirector(Guid id)
        {
            Director director = _context.Directors.FirstOrDefault(x => x.Id == id);
            if(director != null)
            {
                _context.Directors.Remove(director);
                _context.SaveChanges();
            }
        }

        public List<DirectorDTO> GetAllDirectors()
        {
            var directors = _context.Directors.ToList();
            return _mapper.Map<List<DirectorDTO>>(directors);
        }

        public DirectorDTO GetDirectorById(Guid id)
        {
            Director director = _context.Directors.FirstOrDefault(x => x.Id == id);
            return _mapper.Map<DirectorDTO>(director);
               
        }

        public Guid UpdateDirector(DirectorDTO director)
        {
            _context.Directors.Update(_mapper.Map<Director>(director));
            _context.SaveChanges();
            return director.Id;

        }
    }
}
