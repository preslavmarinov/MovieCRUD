using MovieSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Services.Interfaces
{
    public interface IGenreService
    {
        Guid CreateGenre(GenreDTO genre);

        void DeleteGenre(Guid id);

        GenreDTO GetGenreById(Guid id);

        List<GenreDTO> GetAllGenres();
    }
}
