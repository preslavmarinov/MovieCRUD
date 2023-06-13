using AutoMapper;
using MovieSystem.Data.Entities;
using MovieSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.AutoMapper
{
    public class Mapper:Profile
    {
        public Mapper() 
        {
            CreateMap<Movie, MovieDTO>().ForMember(x => x.Title, x => x.MapFrom(y => y.Title))
                .ForMember(x => x.Price, x => x.MapFrom(y => y.Price))
                .ForMember(x => x.ReleaseDate, x => x.MapFrom(y => y.ReleaseDate))
                .ForMember(x => x.DirectorId, x => x.MapFrom(y => y.DirectorId))
                .ForMember(x => x.DirectorName, x => x.MapFrom(y => $"{y.Director.FirstName} {y.Director.LastName}"))
                .ForMember(x => x.ProducingCompanyId, x => x.MapFrom(y => y.ProducingCompanyId))
                .ForMember(x => x.ProducingCompanyName, x => x.MapFrom(y => $"{y.ProducingCompany.Name}"))
                .ForMember(x => x.GenreId, x => x.MapFrom(y => y.GenreId))
                .ForMember(x => x.GenreName, x => x.MapFrom(y => $"{y.Genre.Name}"));

            CreateMap<MovieDTO, Movie>().ForMember(x => x.Title, x => x.MapFrom(y => y.Title))
                .ForMember(x => x.Price, x => x.MapFrom(y => y.Price))
                .ForMember(x => x.ReleaseDate, x => x.MapFrom(y => y.ReleaseDate))
                .ForMember(x => x.DirectorId, x => x.MapFrom(y => y.DirectorId))
                .ForMember(x => x.ProducingCompanyId, x => x.MapFrom(y => y.ProducingCompanyId))
                .ForMember(x => x.GenreId, x => x.MapFrom(y => y.GenreId));

            CreateMap<Director, DirectorDTO>().ReverseMap();
            CreateMap<ProducingCompany, ProducingCompanyDTO>().ReverseMap();
            CreateMap<Genre, GenreDTO>().ReverseMap();
        }
    }
}
