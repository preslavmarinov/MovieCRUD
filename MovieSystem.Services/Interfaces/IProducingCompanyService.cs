using MovieSystem.Domain.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Services.Interfaces
{
    public interface IProducingCompanyService
    {
        Guid CreateProducingCompany(ProducingCompanyDTO company);

        Guid UpdateProducingCompany(ProducingCompanyDTO company);

        void DeleteProducingCompany(Guid id);

        ProducingCompanyDTO GetProducingCompanyById(Guid id);

        List<ProducingCompanyDTO> GetAllProducingCompanies();
    }
}
