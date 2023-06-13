using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Entities
{
    public abstract class Base
    {
        [Key]
        public Guid Id { get; set; }
    }
}
