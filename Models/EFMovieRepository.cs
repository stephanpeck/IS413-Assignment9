using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMate.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        private MovieDBContext _context;

        //Constructor
        public EFMovieRepository (MovieDBContext context)
        {
            _context = context;
        }


        //Dbs set from BookDBContext.cs
        public IQueryable<MovieModel> MovieModel => _context.MovieModel;
    }
}
