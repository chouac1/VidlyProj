﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormModelWithGenre
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public double? NumberInStock { get; set; }

        [Required]
        [Display(Name = "Type Of Genre")]
        public int? GenreId { get; set; }

        public string Title
        {
            get 
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormModelWithGenre()
        {
            Id = 0; //makes sure that in our form the hidden value is populated
        }
        public MovieFormModelWithGenre(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}
