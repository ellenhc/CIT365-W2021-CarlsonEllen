using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    /*public enum MovieGenres
    {
        [Display(Name = "Action")]
        Action,
        [Display(Name = "Adventure")]
        Adventure,
        [Display(Name = "Comedy")]
        Comedy,
        [Display(Name = "Documentary")]
        Documentary,
        [Display(Name = "Drama")]
        Drama,
        [Display(Name = "Historical")]
        Historical,
        [Display(Name = "Romance")]
        Romance,
        [Display(Name = "SciFi")]
        SciFi,
        [Display(Name = "Thriller")]
        Thriller,
        [Display(Name = "Other")]
        Other
    }*/
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }

        [Display(Name = "Movie Poster")]
        public string ImagePath { get; set; }
    }
}
