using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Data.Repositories
{
    public class MovieSystemContext:IdentityDbContext
    {
        public MovieSystemContext(DbContextOptions<MovieSystemContext> options)
            :base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<ProducingCompany> ProducingCompanies { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
