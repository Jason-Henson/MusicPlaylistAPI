﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabase.Models
{
    public class ArtistCreate
    {
        public Guid Guid { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters")]
        [MaxLength(25, ErrorMessage = "Maximum Length is 25 characters")]
        public string Name { get; set; }
        [Required]
        [Range(1,50, ErrorMessage = "Please enter a number between 1 and 50.")]
        public int NumberOfMembers { get; set; }
        [Required]
        public bool isAlive { get; set; }
    }
}
