using FifthHomework.Models;
using FifthHomework.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FifthHomework.Controllers
{
    [Route("api/artists/{artistId}/[controller]")]
    public class SongsController : Controller
    {
        private ISongsService _songsService;
        public SongsController(ISongsService songsService)
        {
            _songsService = songsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SongModel>> GetSongs(int artistId)
        {
            var result = _songsService.GetSongs(artistId);
            return Ok(result);
        }

        [HttpGet("{songId}")]
        public ActionResult<SongModel> GetPlayer(int artistId, int songId)
        {
            var result = _songsService.GetSong(artistId, songId);
            return Ok(result);
        }

        [HttpPost]
        public ActionResult<SongModel> CreateSong(int artistId, [FromBody] SongModel newSong)
        {
            var result = _songsService.CreateSong(artistId,newSong);
            return Created($"api/artists/{artistId}/songs/{result.Id}",result);
        }

        [HttpDelete("{songId}")]
        public ActionResult<bool> DeleteSong(int artistId, int songId)
        {
            var result = _songsService.DeleteSong(artistId, songId);
            return Ok(result);
        }

        [HttpPut("{songId}")]
        public ActionResult<SongModel> UpdateSong(int artistId, int songId, [FromBody] SongModel songToUpdate)
        {
            var result = _songsService.UpdateSong(artistId,songId,songToUpdate);
            return Ok(result);
        }
    }
}
