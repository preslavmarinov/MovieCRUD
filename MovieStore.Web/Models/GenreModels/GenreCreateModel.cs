using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Web.Models.GenreModels
{
    public class GenreCreateModel : BaseViewModel
    {
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$",ErrorMessage ="Genre name must contain only letters and start with a capital one.")]
        public string Name { get; set; }
    }
}
