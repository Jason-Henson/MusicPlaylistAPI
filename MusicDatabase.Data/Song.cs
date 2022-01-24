using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabase.Data
{
    public class Song
    {
        public int Id { get; set; }
        public Guid OwnerId { get; set; }
        public string SongName { get; set; }
        public int ArtistId { get; set; }
        public string Genre { get; set; }
    }
}
