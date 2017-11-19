using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;
        public SelectList genres;
        public SelectList releaseDate;
        public string movieGenre { get; set; }
        public string sortOrder { get; set; }
    }
}
