using FifthHomework.Models;
using FifthHomework.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FifthHomework.Controllers
{
    [Route("api/[controller]")]
    public class ArtistsController : Controller
    {
        private IArtistsService _artistsService;
        public ArtistsController(IArtistsService artistsService)
        {
            _artistsService = artistsService;
        }

        [HttpGet]
        public ActionResult <IEnumerable<ArtistModel>> GetArtists()
        {
            var artists = _artistsService.GetArtists();
            return Ok(artists);
        }

        [HttpGet("{artistId:int}")]
        public ActionResult<ArtistModel> GetArtist(int artistId)
        {
            var artist = _artistsService.GetArtist(artistId);
            return Ok(artist);
        }

        [HttpPost]
        public ActionResult<ArtistModel> CreateArtist([FromBody] ArtistModel newArtist)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var artist = _artistsService.CreateArtist(newArtist);
            return Created($"api/artists/{artist.Id}",artist);
        }

        [HttpDelete("{artistId:int}")]
        public ActionResult<bool> DeleteArtist(int artistId)
        {
            var artist = _artistsService.DeleteArtist(artistId);
            return Ok(artist);
        }

        [HttpPut("{artistId:int}")]
        public ActionResult<ArtistModel> UpdatedArtist(int artistId, [FromBody] ArtistModel updatedArtist)
        {
            var artist = _artistsService.UpdateArtist(artistId, updatedArtist);
            return Ok(artist);
        }
    }
}
