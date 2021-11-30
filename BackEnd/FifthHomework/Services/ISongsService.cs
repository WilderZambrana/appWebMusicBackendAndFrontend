using FifthHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FifthHomework.Services
{
    public interface ISongsService
    {
        SongModel CreateSong(int artistId, SongModel newSong);
        bool DeleteSong(int artistId, int songId);
        SongModel UpdateSong(int artistId, int songId, SongModel updatedSong);
        SongModel GetSong(int artistId, int songId);
        IEnumerable<SongModel> GetSongs(int artistId);
    }
}
