using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieSystem.Domain.DTO;
using MovieSystem.Services.Interfaces;
using MovieSystem.Web.Models.DirectorModels;
using System.Data;

namespace MovieSystem.Web.Controllers
{
    public class DirectorController:Controller
    {
        protected readonly IDirectorService _directorService;
        protected readonly IMapper _mapper;

        public DirectorController(IDirectorService directorService, IMapper mapper)
        {
            _directorService = directorService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllDirectors()
        {
            List<DirectorViewModel> directors = _mapper.Map<List<DirectorViewModel>>(_directorService.GetAllDirectors());
            return View(directors);
        }
        public IActionResult DetailsDirector(Guid id)
        {
            var director = _mapper.Map<DirectorViewModel>(_directorService.GetDirectorById(id));
            return View(director);
        }

        [HttpGet]
        public IActionResult AddDirector()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDirector(DirectorCreateModel director)
        {
            DirectorDTO newDirector = _mapper.Map<DirectorDTO>(director);
            _directorService.CreateDirector(newDirector);
            return RedirectToAction("GetAllDirectors");
        }

        [HttpGet]
        public IActionResult EditDirector(Guid id)
        {
            var director = _directorService.GetDirectorById(id);
            return View(_mapper.Map<DirectorCreateModel>(director));
        }

        [HttpPost]
        public IActionResult EditDirector(DirectorCreateModel director)
        {
            _directorService.UpdateDirector(_mapper.Map<DirectorDTO>(director));
            return RedirectToAction("GetAllDirectors");
        }

        public IActionResult DeleteDirector(Guid id)
        {
            _directorService.DeleteDirector(id);
            return RedirectToAction("GetAllDirectors");
        }
    }
}
