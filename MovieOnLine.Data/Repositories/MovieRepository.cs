using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieOnLine.Data.Entities;

namespace MovieOnLine.Data.Repositories
{
    public class MovieRepository
    {
        public List<Movie> getMovies()
        {
            using (var context = new MoviesDBContext())
            {
                return context.Movies.ToList();

            }
        }
        public int save(Movie movie)
        {
            using (var context = new  MoviesDBContext()){
                context.Movies.Add(movie);
                return context.SaveChanges();

            }
        }
    }
}
