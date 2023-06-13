using AutoMapper;
using MovieSystem.Data.Entities;
using MovieSystem.Data.Repositories.Interfaces;
using MovieSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repositories
{
    public class ProducingCompanyRepository : IProducingCompanyRepository
    {
        private readonly MovieSystemContext _context;
        private readonly IMapper _mapper;
        public ProducingCompanyRepository(MovieSystemContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Guid CreateProducingCompany(ProducingCompanyDTO producingCompany)
        {
            ProducingCompany companyEntity = _mapper.Map<ProducingCompany>(producingCompany);
            companyEntity.Id = Guid.NewGuid();
            _context.ProducingCompanies.Add(companyEntity);
            _context.SaveChanges();
            return companyEntity.Id;
        }

        public void DeleteProducingCompany(Guid id)
        {
            ProducingCompany company = _context.ProducingCompanies.FirstOrDefault(x => x.Id==id);
            if (company!=null)
            {
                _context.ProducingCompanies.Remove(company);
                _context.SaveChanges();
            }
        }

        public List<ProducingCompanyDTO> GetAllProducingCompanies()
        {
            var companies = _context.ProducingCompanies.ToList();
            return _mapper.Map<List<ProducingCompanyDTO>>(companies);
        }

        public ProducingCompanyDTO GetProducingCompanyById(Guid id)
        {
            ProducingCompany company = _context.ProducingCompanies.FirstOrDefault(x => x.Id == id);
            return _mapper.Map<ProducingCompanyDTO>(company);
        }

        public Guid UpdateProducingCompany(ProducingCompanyDTO producingCompany)
        {
            _context.ProducingCompanies.Update(_mapper.Map<ProducingCompany>(producingCompany));
            _context.SaveChanges();
            return producingCompany.Id;
        }
    }
}
