using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Web.Models.DirectorModels
{
    public class DirectorCreateModel:BaseViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string? LastName { get; set; }
    }
}
