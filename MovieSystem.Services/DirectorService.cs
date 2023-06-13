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
    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;
        public DirectorService(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }

        public Guid CreateDirector(DirectorDTO director) => _directorRepository.CreateDirector(director);

        public void DeleteDirector(Guid id) => _directorRepository.DeleteDirector(id);

        public List<DirectorDTO> GetAllDirectors() => _directorRepository.GetAllDirectors();

        public DirectorDTO GetDirectorById(Guid id) => _directorRepository.GetDirectorById(id);
        

        public Guid UpdateDirector(DirectorDTO director) => _directorRepository.UpdateDirector(director);
    }
}
