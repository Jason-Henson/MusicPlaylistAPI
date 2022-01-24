using Microsoft.AspNet.Identity;
using MusicDatabase.Models;
using MusicDatabase.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MusicDatabseAPI.Controllers
{
    public class SongController : ApiController
    {
      
        [Authorize]
        private SongService CreateSongService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var songService = new SongService(userId);
            return songService;
        }

        [HttpGet]
        public IHttpActionResult GetSong()
        {
           SongService songService = CreateSongService();
            var song = songService.GetSongs();
            return Ok(song);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            SongService songService = CreateSongService();
            var song = songService.GetSongById(id);
            return Ok(song);
        }

        [HttpPost]
        public IHttpActionResult CreateSong(AddSong song)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateSongService();

            if (!service.CreateSong(song))
                return InternalServerError();

            return Ok($"{song},was added");
        }

        [HttpDelete]
        public IHttpActionResult DeleteSong(int id)
        {
            var service = CreateSongService();
            if (!service.DeleteSong(id))
                return InternalServerError();

            return Ok("Deletetion Successful");
        }
    }
}
