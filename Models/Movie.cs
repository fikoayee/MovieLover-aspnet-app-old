﻿using MovieLover.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MovieLover.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public MovieCategory MovieCategory { get; set; }

    }
}
