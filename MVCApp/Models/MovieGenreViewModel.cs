using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCApp.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MoviesGenre { get; set; }
        public string? searchString { get; set; }
    }
}
