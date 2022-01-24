using MusicDatabase.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabase.Models
{
    public class SongDetail
    {
        
        public int Id { get; set; }

        public string SongName { get; set; }

        [ForeignKey("Artist")]
        public int ArtistId { get; set; }

        public string Genre { get; set; }
    }
}
