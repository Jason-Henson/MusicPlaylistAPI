using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicDatabase.Models;
using MusicDatabase.Data;


namespace MusicDatabase.Services
{
    public class ArtistService
    {
        private readonly Guid _userId;


        public ArtistService(Guid userId)
        {
            _userId = userId;
        }   
        public bool CreateArtist(ArtistCreate model)
        {
            var entity = new Artist()
            {
                OwnerId = _userId,
                Name = model.Name,
                NumberOfMembers = model.NumberOfMembers,
                IsAlive = model.isAlive
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Artists.Add(entity);
                ctx.SaveChanges();
                return true;
            }
        }
    }
}
