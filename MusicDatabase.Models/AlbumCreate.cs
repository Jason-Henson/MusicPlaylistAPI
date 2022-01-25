using System;
using System.ComponentModel.DataAnnotations;

namespace MusicDatabase.Services
{
    public class AlbumCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "There are too many characters in this field.")]
        public int AlbumId { get; set; }

        [MaxLength(8000)]
        public string AlbumName { get; set; }

        [Display(Name = "Date Released")]
        public DateTimeOffset ReleaseDate { get; set; }

        [Display(Name = "Artists Name")]
        public int ArtistID { get; set; }
    }
}