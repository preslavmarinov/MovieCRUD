using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Web.Models.GenreModels
{
    public class GenreCreateModel : BaseViewModel
    {
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Name { get; set; }
    }
}
