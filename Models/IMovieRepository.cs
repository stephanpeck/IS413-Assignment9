using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//IBookRepository creates a queryable Book Model
namespace MovieMate.Models
{
    public interface IMovieRepository
    {
        IQueryable<MovieModel> MovieModel { get; }
    }
}
