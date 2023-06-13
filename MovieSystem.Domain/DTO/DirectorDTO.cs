using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.DTO
{
    public class DirectorDTO:BaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
