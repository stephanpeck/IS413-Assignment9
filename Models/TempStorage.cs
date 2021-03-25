using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMate.Models
{
    public static class TempStorage
    {
        private static List<ApplicationResponse> movies = new List<ApplicationResponse>();


        //lambda filling up with movies as they are posted
        public static IEnumerable<ApplicationResponse> Movies => movies;

        public static void AddMovie(ApplicationResponse application)
        {
            movies.Add(application);
        }
    }
}
