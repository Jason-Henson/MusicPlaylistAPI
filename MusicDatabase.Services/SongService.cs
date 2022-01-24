using MusicDatabase.Data;
using MusicDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDatabase.Services
{
    public class SongService
    {
        private readonly Guid _userId;
        public SongService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateSong(AddSong model)
        {
            var entity =
                new Song()
                {
                    OwnerId = _userId,
                    SongName = model.SongName,
                    ArtistId = model.ArtistId,
                    Genre = model.Genre
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Songs.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public SongDetail GetSongById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Songs
                    .Single(e => e.Id == id && e.OwnerId == _userId);
                return
                new SongDetail
                {
                    Id = entity.Id,
                    SongName = entity.SongName,
                    ArtistId = entity.ArtistId,
                };
            }
        }
        public IEnumerable<SongList> GetSongs()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Songs
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                        e =>
                        new SongList
                        {
                            Id = e.Id,
                            SongName = e.SongName,
                            
                        }
            );


                return query.ToArray();
            }

        }
        public bool UpdateSong(SongEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx
                    .Songs
                    .Single(e => e.Id == model.Id);
                entity.SongName = model.SongName;
                entity.ArtistId = model.ArtistId;

                return ctx.SaveChanges() == 1;
            }

        }
        public bool DeleteSong(int Id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Songs
                    .Single(e => e.Id == Id && e.OwnerId == _userId);

                ctx.Songs.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}

