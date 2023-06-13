using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieSystem.Domain.DTO;
using MovieSystem.Services.Interfaces;
using MovieSystem.Web.Models.ProducingCompanyModels;
using System.Data;

namespace MovieSystem.Web.Controllers
{
    public class ProducingCompanyController:Controller
    {
        protected readonly IProducingCompanyService _companyService;
        protected readonly IMapper _mapper;

        public ProducingCompanyController(IProducingCompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllCompanies()
        {

            List<ProducingCompanyViewModel> companies = _mapper.Map<List<ProducingCompanyViewModel>>(_companyService.GetAllProducingCompanies());
            return View(companies);
        }

        [HttpGet]
        public IActionResult AddCompany()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCompany(ProducingCompanyCreateModel company)
        {
            if (!ModelState.IsValid) return View(company);
            ProducingCompanyDTO newCompany = _mapper.Map<ProducingCompanyDTO>(company);
            _companyService.CreateProducingCompany(newCompany);
            return RedirectToAction("GetAllCompanies");
        }

        [HttpGet]
        public IActionResult EditCompany(Guid id)
        {
            var company = _companyService.GetProducingCompanyById(id);
            return View(_mapper.Map<ProducingCompanyCreateModel>(company));
        }

        [HttpPost]
        public IActionResult EditCompany(ProducingCompanyCreateModel company)
        {
            if (!ModelState.IsValid) return View(company);
            _companyService.UpdateProducingCompany(_mapper.Map<ProducingCompanyDTO>(company));
            return RedirectToAction("GetAllCompanies");
        }

        public IActionResult DeleteCompany(Guid id)
        {
            _companyService.DeleteProducingCompany(id);
            return RedirectToAction("GetAllCompanies");
        }
        [HttpGet]
        public IActionResult DetailsCompany(Guid id)
        {
            var publisher = _companyService.GetProducingCompanyById(id);
            return View(_mapper.Map<ProducingCompanyViewModel>(publisher));
        }
    }
}
