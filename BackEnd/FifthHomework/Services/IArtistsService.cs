using FifthHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FifthHomework.Services
{
    public interface IArtistsService
    {
        ArtistModel CreateArtist(ArtistModel newArtist);
        bool DeleteArtist(int id);
        ArtistModel UpdateArtist(int artistId,ArtistModel updatedArtist);
        ArtistModel GetArtist(int artistId);
        IEnumerable<ArtistModel> GetArtists();
    }
}
