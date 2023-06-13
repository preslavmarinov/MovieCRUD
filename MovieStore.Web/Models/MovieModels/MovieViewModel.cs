using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieSystem.Web.Models.DirectorModels;
using MovieSystem.Web.Models.GenreModels;
using MovieSystem.Web.Models.ProducingCompanyModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Web.Models.MovieModels
{
    public class MovieViewModel:BaseViewModel
    {
        
        public string Title { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public Guid DirectorId { get; set; }
        [Display(Name = "Director")]
        public string DirectorName { get; set; }
        public Guid ProducingCompanyId { get; set; }
        [Display(Name = "Producing Company")]
        public string ProducingCompanyName { get; set; }
        public Guid GenreId { get; set; }
        [Display(Name = "Genre")]
        public string GenreName { get; set; }
    }
}
