using MovieSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repositories.Interfaces
{
    public interface IProducingCompanyRepository
    {
        ProducingCompanyDTO GetProducingCompanyById(Guid id);
        List<ProducingCompanyDTO> GetAllProducingCompanies();
        Guid CreateProducingCompany(ProducingCompanyDTO producingCompany);
        Guid UpdateProducingCompany(ProducingCompanyDTO producingCompany);
        void DeleteProducingCompany(Guid id);
    }
}
