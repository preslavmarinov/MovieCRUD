using MovieSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repositories.Interfaces
{
    public interface IDirectorRepository
    {
        DirectorDTO GetDirectorById(Guid id);
        List<DirectorDTO> GetAllDirectors();
        Guid CreateDirector(DirectorDTO director);
        Guid UpdateDirector(DirectorDTO director);
        void DeleteDirector(Guid id);
    }
}
