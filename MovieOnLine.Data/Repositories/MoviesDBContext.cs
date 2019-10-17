using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieOnLine.Data.Entities;

namespace MovieOnLine.Data.Repositories
{
    public class MoviesDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        //el get y set es un metodo get para movies y set
    }
}
