using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MovieSystem.Data.Entities;
using MovieSystem.Web.Models.DirectorModels;
using MovieSystem.Web.Models.ProducingCompanyModels;
using MovieSystem.Web.Models.GenreModels;

namespace MovieSystem.Web.Models.MovieModels
{
    public class MovieCreateModel:BaseViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        [Range(1, 120)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public Guid DirectorId { get; set; }
        public  List<DirectorViewModel>? Directors { get; set; }
        public Guid ProducingCompanyId { get; set; }
        public List<ProducingCompanyViewModel>?  ProducingCompanys { get; set; }
        public Guid GenreId { get; set; }
        public List<GenreCreateModel>? Genres { get; set; }
    }
}
