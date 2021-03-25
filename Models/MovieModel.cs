using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMate.Models
{
    public class MovieModel
    {
        [Key]
        public int movieID { get; set; }

        [Required]
        public string movieTitle { get; set; }

        [Required]
        [Range(1878, 2021)]
        public int year { get; set; }

        [Required]
        public string director { get; set; }

        [Required]
        public string rating { get; set; }

        public bool edited { get; set; }

        public string lentTo { get; set; }

        [MaxLength(25)]
        public string notes { get; set; }






    }
}
