using System;
using System.ComponentModel.DataAnnotations;

namespace MusicDatabase.Models
{
    public class AlbumDetail
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}