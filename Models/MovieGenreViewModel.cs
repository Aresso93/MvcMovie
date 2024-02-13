using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        //public List<Movie>? Movies { get; set; }
        public List<MovieDTO>? MovieRecords { get; set; }
        public MovieDTO MovieDTO { get; set;}
        //public Genre? GenreName { get; set; }
        public SelectList? Genres { get; set; }
        //public string? MovieGenre { get; set; }
        //public string? SearchString { get; set; }
    }
}