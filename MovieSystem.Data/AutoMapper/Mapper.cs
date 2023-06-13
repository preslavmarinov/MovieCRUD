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
            CreateMap<Movie, MovieDTO>().ReverseMap();
            CreateMap<Director, DirectorDTO>().ReverseMap();
            CreateMap<ProducingCompany, ProducingCompanyDTO>().ReverseMap();
            CreateMap<Genre, GenreDTO>().ReverseMap();
        }
    }
}
