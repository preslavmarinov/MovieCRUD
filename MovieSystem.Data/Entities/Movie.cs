using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Entities
{
    public class Movie:Base
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        [Column(TypeName ="decimal(18,2)")]
        [Range(1,120)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public Guid DirectorId { get; set; }
        public virtual Director Director { get; set; }
        [Required]
        public Guid ProducingCompanyId { get; set; }
        public virtual ProducingCompany ProducingCompany { get; set; }
        [Required]
        public Guid GenreId { get; set; }
        public virtual Genre Genre { get; set; }

    }
}
