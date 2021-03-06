﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        [Display(Name = "Date Added (Today's Date)")]
        public DateTime? DateAdded { get; set; }
        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public double? NumberInStock { get; set; }

        public Genre Genre { get; set; }
        
        [Required]
        [Display(Name = "Type Of Genre")]
        public int GenreId { get; set; }
    }
}
