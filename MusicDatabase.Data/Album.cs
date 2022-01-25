using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicDatabase.Data
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        [Required]
        public string AlbumName { get; set; }

        [ForeignKey(nameof(Artist))]
        public int ArtistId { get; set; }

        [ForeignKey(nameof(Songs))]
        public List<Song> Songs { get; set; }

        [Required]
        public DateTimeOffset ReleaseDate { get; set; }
    }
}