using MovieSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Services.Interfaces
{
    public interface IDirectorService
    {
        Guid CreateDirector(DirectorDTO director);

        Guid UpdateDirector(DirectorDTO director);

        void DeleteDirector(Guid id);

        DirectorDTO GetDirectorById(Guid id);

        List<DirectorDTO> GetAllDirectors();
    }
}
