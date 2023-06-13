

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieSystem.Domain.DTO;
using MovieSystem.Services.Interfaces;
using MovieSystem.Web.Models.DirectorModels;
using MovieSystem.Web.Models.GenreModels;
using MovieSystem.Web.Models.MovieModels;
using MovieSystem.Web.Models.ProducingCompanyModels;

namespace MovieSystem.Web.Controllers
{
    public class MovieController : Controller
    {
        protected readonly IDirectorService _directorService;
        protected readonly IMovieService _movieService;
        protected readonly IProducingCompanyService _producingCompanyService;
        protected readonly IGenreService _genreService;
        protected readonly IMapper _mapper;


        public MovieController(IDirectorService directorService, IMovieService movieService, IProducingCompanyService producingCompanyService, IGenreService genreService, IMapper mapper)
        {
            _directorService = directorService;
            _movieService = movieService;
            _producingCompanyService = producingCompanyService;
            _genreService = genreService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var movies = _movieService.GetAllMovies<MovieViewModel>();
            return View(movies);
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            MovieCreateModel model = new MovieCreateModel();
            PopulateDropDowns(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult AddMovie(MovieCreateModel movie)
        {
            MovieDTO newMovie = _mapper.Map<MovieDTO>(movie);
            _movieService.CreateMovie(newMovie);
            return RedirectToAction("GetAllMovies");
        }

        [HttpGet]
        public IActionResult EditMovie(Guid id)
        {
            var movie = _mapper.Map<MovieCreateModel>(_movieService.GetMovieById(id));
            PopulateDropDowns(movie);
            return View(movie);
        }

        [HttpPost]
        public IActionResult EditMovie(MovieCreateModel movie)
        {
            _movieService.UpdateMovie(_mapper.Map<MovieDTO>(movie));
            return RedirectToAction("GetAllMovies");
        }

        public IActionResult DeleteMovie(Guid id)
        {
            _movieService.DeleteMovie(id);
            return RedirectToAction("GetAllMovies");
        }
        public IActionResult DetailsMovie(Guid id)
        {
            var movie = _mapper.Map<MovieViewModel>(_movieService.GetMovieById(id));
            return View(movie);
        }

        [HttpGet]
        public IActionResult AddGenre()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGenre(GenreCreateModel genre)
        {
            GenreDTO newGenre = _mapper.Map<GenreDTO>(genre);
            _genreService.CreateGenre(newGenre);
            return RedirectToAction("GetAllMovies");
        }

        public IActionResult DeleteGenre(Guid id)
        {
            _genreService.DeleteGenre(id);
            return RedirectToAction("GetAllMovies");
        }

        [HttpGet]
        public IActionResult ListGenres()
        {
            var genres = _mapper.Map<List<GenreCreateModel>>(_genreService.GetAllGenres());
            return View(genres);
        }

        private MovieCreateModel PopulateDropDowns(MovieCreateModel model)
        {
            model.Directors = _mapper.Map<List<DirectorViewModel>>(_directorService.GetAllDirectors());
            model.ProducingCompanys = _mapper.Map<List<ProducingCompanyViewModel>>(_producingCompanyService.GetAllProducingCompanies());
            model.Genres = _mapper.Map<List<GenreCreateModel>>(_genreService.GetAllGenres());
            return model;
        }
    }
}
