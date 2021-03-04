using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public enum MovieGenres
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
    }
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
}
