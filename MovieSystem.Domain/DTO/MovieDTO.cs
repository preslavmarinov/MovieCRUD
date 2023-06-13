using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.DTO
{
    public class MovieDTO:BaseDTO
    {
        public string Title { get; set; }
        public string Price { get; set; }
        public string ReleaseDate { get; set; }
        public string DirectorId { get; set; }
        public string ProducingCompanyId { get; set; }
        public string GenreId { get; set; }
    }
}
