
using System.ComponentModel.DataAnnotations;

namespace MovieSystem.Web.Models.ProducingCompanyModels
{
    public class ProducingCompanyViewModel:BaseViewModel
    {
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date Established")]
        public DateTime DateOfEstablishment { get; set; }
    }
}
