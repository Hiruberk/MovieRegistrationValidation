using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistrationValidation.Models
{
    public enum GenreType
    {
        Action,
        Comedy,
        Drama,
        Fantasy,
        Horror,
        Mystery,
        Romance,
        Thriller
    }
    public class Movie
    {
        public int ID { get; set; } = 1;
        public string Title { get; set; } = "";
        public GenreType Genre { get; set; }
        public int Year { get; set; }
        public string Actors { get; set; } = "";
        public string Directors { get; set; } = "";
    }
}
