using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.DTO
{
    public class ProducingCompanyDTO:BaseDTO
    {
        public string Name { get; set; }
        public string DateOfEstablishment { get; set; }
    }
}
