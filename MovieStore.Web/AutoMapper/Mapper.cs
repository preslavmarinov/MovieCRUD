using AutoMapper;
using MovieSystem.Data.Entities;
using MovieSystem.Domain.DTO;
using MovieSystem.Web.Models.DirectorModels;
using MovieSystem.Web.Models.GenreModels;
using MovieSystem.Web.Models.MovieModels;
using MovieSystem.Web.Models.ProducingCompanyModels;

namespace MovieSystem.Web.AutoMapper
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<MovieViewModel,MovieDTO>().ReverseMap();
            CreateMap<Movie, MovieViewModel>().ForMember(x => x.DirectorName, x => x.MapFrom(y => $"{y.Director.FirstName} {y.Director.LastName}"));
            CreateMap<MovieCreateModel, MovieDTO>().ReverseMap();
            CreateMap<DirectorViewModel, DirectorDTO>().ReverseMap().ForMember(x => x.Name, x => x.MapFrom(y => $"{y.FirstName} {y.LastName}"));
            CreateMap<DirectorCreateModel, DirectorDTO>().ReverseMap();
            CreateMap<ProducingCompanyViewModel,ProducingCompanyDTO>().ReverseMap();
            CreateMap<ProducingCompanyCreateModel, ProducingCompanyDTO>().ReverseMap();
            CreateMap<GenreCreateModel,GenreDTO>().ReverseMap();
        }
    }
}
