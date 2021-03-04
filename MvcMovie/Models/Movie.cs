using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public enum MovieGenres
    {
        Action,
        Adventure,
        Comedy,
        Documentary,
        Drama,
        Historical,
        Romance,
        SciFi,
        Thriller,
        Other
    }
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Movie Poster")]
        public string ImagePath { get; set; }
    }
}
