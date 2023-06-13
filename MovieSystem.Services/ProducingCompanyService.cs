using MovieSystem.Data.Repositories.Interfaces;
using MovieSystem.Domain.DTO;
using MovieSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Services
{
    public class ProducingCompanyService : IProducingCompanyService
    {
        private readonly IProducingCompanyRepository _companyRepository;
        public ProducingCompanyService(IProducingCompanyRepository companyRepository)
        {
            _companyRepository= companyRepository;
        }
        public Guid CreateProducingCompany(ProducingCompanyDTO company) => _companyRepository.CreateProducingCompany(company);

        public void DeleteProducingCompany(Guid id) => _companyRepository.DeleteProducingCompany(id);

        public List<ProducingCompanyDTO> GetAllProducingCompanies() => _companyRepository.GetAllProducingCompanies();

        public ProducingCompanyDTO GetProducingCompanyById(Guid id) => _companyRepository.GetProducingCompanyById(id);

        public Guid UpdateProducingCompany(ProducingCompanyDTO company) => _companyRepository.UpdateProducingCompany(company);
    }
}
