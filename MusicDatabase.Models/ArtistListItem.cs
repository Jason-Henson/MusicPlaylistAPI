using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabase.Models
{
    public class ArtistListItem
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set;}
        public int NumberOfMembers { get; set; }
        public bool IsAlive { get; set; }
    }
}
