using MovieSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repositories.Interfaces
{
    public interface IGenreRepository
    {
        GenreDTO GetGenreById(Guid id);
        List<GenreDTO> GetAllGenres();
        Guid CreateGenre(GenreDTO genre);
        void DeleteGenre(Guid id);
    }
}
