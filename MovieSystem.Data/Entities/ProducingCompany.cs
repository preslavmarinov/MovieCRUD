using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Entities
{
    public class ProducingCompany:Base
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Established")]
        public DateTime DateOfEstablishment { get; set; }
        public ICollection<Movie> Movies { get; set; } = new HashSet<Movie>();
    }
}
