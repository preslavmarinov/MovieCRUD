using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Web.Models.ProducingCompanyModels
{
    public class ProducingCompanyCreateModel : BaseViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Established")]
        public DateTime DateOfEstablishment { get; set; }
    }
}
