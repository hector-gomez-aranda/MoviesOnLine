using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using model =  MoviesOnLine.Models;
using entity = MovieOnLine.Data.Entities;

namespace MoviesOnLine.Helper
{
    public class MapHelper
    {
        internal static IMapper mapper;

        public static T Map<T>(Object source)
        {
            return mapper.Map<T>(source);
        }

        static MapHelper()
        {
            var config = new MapperConfiguration(x => 
            { 
                x.CreateMap<entity.Movie, model.MovieList>().ReverseMap(); 
            });
            mapper = config.CreateMapper();
        }
    }
}