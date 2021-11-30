using FifthHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FifthHomework.Services
{
    public class SongsService : ISongsService
    {
        private IArtistsService _artistsService;
        private IList<SongModel> _songs = new List<SongModel>();
        public SongsService(IArtistsService artistsService)
        {
            _artistsService = artistsService;

            //1 Adele
            _songs.Add(new SongModel()
            {
                Id = 1,
                Name = "Easy On Me",
                Album = "30",
                ImgAlbum= "https://media.vogue.mx/photos/6194ffc484e242c09f4a6866/1:1/w_3000,h_3000,c_limit/COVER_no-text_10X10_RGB.jpg",
                Duration = "3:44",
                ArtistId = 1
            });
            _songs.Add(new SongModel()
            {
                Id = 2,
                Name = "Rolling in the Deep",
                Album = "21",
                ImgAlbum = "https://lh3.googleusercontent.com/-XCXv0h2b9K8/TY3b8F1NJqI/AAAAAAAAB0o/YPgrwNVqT5Y/s1600/Adele+21.jpg",
                Duration = "3:48",
                ArtistId = 1
            });
            _songs.Add(new SongModel()
            {
                Id = 3,
                Name = "Someone Like You",
                Album = "21",
                ImgAlbum = "https://lh3.googleusercontent.com/-XCXv0h2b9K8/TY3b8F1NJqI/AAAAAAAAB0o/YPgrwNVqT5Y/s1600/Adele+21.jpg",
                Duration = "4:45",
                ArtistId = 1
            });
            _songs.Add(new SongModel()
            {
                Id = 4,
                Name = "Hello",
                Album = "25",
                ImgAlbum = "https://m.media-amazon.com/images/I/81q0mwIoc0L._SL1500_.jpg",
                Duration = "4:55",
                ArtistId = 1
            });
            //2 Billie Eilish
            _songs.Add(new SongModel()
            {
                Id = 5,
                Name = "Lovely",
                Album = "Lovely",
                ImgAlbum = "https://cdns-images.dzcdn.net/images/cover/910033ba5cd64291a921061c8e8ba85a/500x500.jpg",
                Duration = "3:20",
                ArtistId = 2
            });
            _songs.Add(new SongModel()
            {
                Id = 6,
                Name = "Bored",
                Album = "Autumn Chill",
                ImgAlbum = "https://i.scdn.co/image/ab67616d0000b27315e3275e296efc5fb2213cdd",
                Duration = "3:00",
                ArtistId = 2
            });
            //3 Bob Marley
            _songs.Add(new SongModel()
            {
                Id = 7,
                Name = "Buffalo Soldier",
                Album = "Confrontation",
                ImgAlbum = "https://img.discogs.com/mL2cXqzZ_PRAUP_5qO7kECPFYvg=/fit-in/600x603/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-671351-1264290249.jpeg.jpg",
                Duration = "4:15",
                ArtistId = 3
            });
            _songs.Add(new SongModel()
            {
                Id = 8,
                Name = "Three Little Birds",
                Album = "Legend - The Best Of Bob Marley",
                ImgAlbum = "https://img.discogs.com/ZcZseGz9sJU-cZirSYcfUQnzONc=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-533226-1564873856-8049.jpeg.jpg",
                Duration = "3:00",
                ArtistId = 3
            });
            //4 Eminem
            _songs.Add(new SongModel()
            {
                Id = 9,
                Name = "Godzilla",
                Album = "Music To Be Murdered By",
                ImgAlbum = "https://www.mor.bo/wp-content/uploads/2020/01/portada-genius.jpg",
                Duration = "3:30",
                ArtistId = 4
            });
            _songs.Add(new SongModel()
            {
                Id = 10,
                Name = "Without Me",
                Album = "The Eminem Show",
                ImgAlbum = "https://m.media-amazon.com/images/I/61jxguiMreL._SL1200_.jpg",
                Duration = "4:50",
                ArtistId = 4
            });
            _songs.Add(new SongModel()
            {
                Id = 11,
                Name = "The Real Slim Shady",
                Album = "The Marshall Mathers LP",
                ImgAlbum = "https://m.media-amazon.com/images/I/813Is33yOzL._SY355_.jpg",
                Duration = "4:44",
                ArtistId = 4
            });
            _songs.Add(new SongModel()
            {
                Id = 12,
                Name = "'Till I Collapse",
                Album = "The Eminem Show",
                ImgAlbum = "https://m.media-amazon.com/images/I/61jxguiMreL._SL1200_.jpg",
                Duration = "4:57",
                ArtistId = 4
            });
            _songs.Add(new SongModel()
            {
                Id = 13,
                Name = "Mockingbird",
                Album = "Encore(Deluxe Version)",
                ImgAlbum = "https://m.media-amazon.com/images/I/51VIR8u5aFL.jpg",
                Duration = "4:10",
                ArtistId = 4
            });
            _songs.Add(new SongModel()
            {
                Id = 14,
                Name = "Not Afraid",
                Album = "Recovery",
                ImgAlbum = "https://m.media-amazon.com/images/I/61fXEwg-lAL._SL1400_.jpg",
                Duration = "4:08",
                ArtistId = 4
            });
            //5 Freddie Mercury
            _songs.Add(new SongModel()
            {
                Id = 15,
                Name = "Time Waits For No One",
                Album = "Never Boring",
                ImgAlbum = "https://img.discogs.com/5_06yYLEy_QwOnKvgUIQjcecPPU=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-14250969-1570745095-7098.jpeg.jpg",
                Duration = "3:18",
                ArtistId = 5
            });
            _songs.Add(new SongModel()
            {
                Id = 16,
                Name = "Living on My Own",
                Album = "Messenger Of The Gods:The Singles Collection",
                ImgAlbum = "https://images-na.ssl-images-amazon.com/images/I/41RNBMpiNzL._SY355_.jpg",
                Duration = "3:05",
                ArtistId = 5
            });
            //6 J Balvin
            _songs.Add(new SongModel()
            {
                Id = 17,
                Name = "Que Pretendes",
                Album = "Oasis",
                ImgAlbum = "https://umomag.com/wp-content/uploads/2019/07/articulo-oasis-j-balvin-bad-bunny-2019-umomag-cover.jpg",
                Duration = "3:42",
                ArtistId = 6
            });
            _songs.Add(new SongModel()
            {
                Id = 18,
                Name = "Azul",
                Album = "Colores",
                ImgAlbum = "https://lh3.googleusercontent.com/proxy/zWHWu7nLqYl8dylppqJPaggyCP1_qyzUq932LGRizGwU7628d6erZHor9K9BP10mo_WUcrUY5XCw07YSw9MusSCf-2IBHHvwaCiSIiOuneS16sQFPiYHssNlDHXsQF_e-hBKaXxr6Ok",
                Duration = "3:25",
                ArtistId = 6
            });
            _songs.Add(new SongModel()
            {
                Id = 19,
                Name = "Que Mas Pues?",
                Album = "JOSE",
                ImgAlbum = "https://ca-times.brightspotcdn.com/dims4/default/159a701/2147483647/strip/true/crop/3000x3000+0+0/resize/840x840!/quality/90/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2F66%2F0e%2Fba83fa456a1fcd4121c1009ca66c%2Fa3f5db7bb53e4594b5d3b1386a843845",
                Duration = "3:37",
                ArtistId = 6
            });
            _songs.Add(new SongModel()
            {
                Id = 20,
                Name = "6 AM",
                Album = "La Familia",
                ImgAlbum = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTTymT8v1tvdkJ6hhXFE8g0ucVOMDV59mq8Trnc5nJydS1p442A8l6s17Pax2a-sKA7nI&usqp=CAU",
                Duration = "4:03",
                ArtistId = 6
            });
            _songs.Add(new SongModel()
            {
                Id = 21,
                Name = "Bonita",
                Album = "Bonita",
                ImgAlbum = "https://img.discogs.com/OOS45t_MyDfkqVd7afGWgYGUK80=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-12703123-1540364289-7962.jpeg.jpg",
                Duration = "4:25",
                ArtistId = 6
            });
            //7 Julio Iglesias
            _songs.Add(new SongModel()
            {
                Id = 22,
                Name = "Abrazame",
                Album = "El Amor",
                ImgAlbum = "https://upload.wikimedia.org/wikipedia/en/b/b4/El_Amor_%28Julio_Iglesias_album%29_cover.jpg",
                Duration = "3:31",
                ArtistId = 7
            });
            _songs.Add(new SongModel()
            {
                Id = 23,
                Name = "Con la Misma Piedra",
                Album = "Moments",
                ImgAlbum = "https://m.media-amazon.com/images/I/51eQz43GD7L._SX355_.jpg",
                Duration = "3:57",
                ArtistId = 7
            });
            _songs.Add(new SongModel()
            {
                Id = 24,
                Name = "La Cumparsita",
                Album = "Tango",
                ImgAlbum = "https://i.scdn.co/image/ab67616d0000b2737f038d3cdb65df1df73ca1f1",
                Duration = "2:34",
                ArtistId = 7
            });
            //8 Micro TDH
            _songs.Add(new SongModel()
            {
                Id = 25,
                Name = "Volver",
                Album = "Volver",
                ImgAlbum = "https://cdns-images.dzcdn.net/images/cover/3e49e889c99b99bc96e860b990566a35/500x500.jpg",
                Duration = "1:59",
                ArtistId = 8
            });
            _songs.Add(new SongModel()
            {
                Id = 26,
                Name = "Cafune",
                Album = "Inefable",
                ImgAlbum = "https://s3.amazonaws.com/filepicker-images-rapgenius/v9o7nd4vhmr",
                Duration = "4:22",
                ArtistId = 8
            });
            _songs.Add(new SongModel()
            {
                Id = 27,
                Name = "Besame Sin Sentir",
                Album = "Besame Sin Sentir",
                ImgAlbum = "https://m.media-amazon.com/images/I/A15RErkuHVL._SS500_.jpg",
                Duration = "4:08",
                ArtistId = 8
            });
            //9 Rihanna
            _songs.Add(new SongModel()
            {
                Id = 28,
                Name = "Man Down",
                Album = "Loud",
                ImgAlbum = "https://m.media-amazon.com/images/I/71iMVBsItRL._SL1400_.jpg",
                Duration = "4:27",
                ArtistId = 9
            });
            _songs.Add(new SongModel()
            {
                Id = 29,
                Name = "Work",
                Album = "ANTI(Deluxe)",
                ImgAlbum = "https://direct.rhapsody.com/imageserver/images/alb.217601819/500x500.jpg",
                Duration = "3:39",
                ArtistId = 9
            });
            _songs.Add(new SongModel()
            {
                Id = 30,
                Name = "We Found Love",
                Album = "Talk That Talk",
                ImgAlbum = "https://upload.wikimedia.org/wikipedia/en/8/8e/Rihanna_-_Talk_That_Talk_%28standard%29.png",
                Duration = "3:35",
                ArtistId = 9
            });
            //10 Whitney Houston
            _songs.Add(new SongModel()
            {
                Id = 31,
                Name = "I Will Always Love You",
                Album = "I Wish You Love",
                ImgAlbum = "https://i.scdn.co/image/ab67616d0000b273e6086b6305db342196d99e68",
                Duration = "4:30",
                ArtistId = 10
            });
            _songs.Add(new SongModel()
            {
                Id = 32,
                Name = "For the Love of You",
                Album = "Whitney",
                ImgAlbum = "https://ca-times.brightspotcdn.com/dims4/default/f0f5f24/2147483647/strip/true/crop/1500x1500+0+0/resize/840x840!/quality/90/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2Fcf%2Fe3%2Ff433ca2604e8566483a836a115fa%2F30243404507147b6bf4a8b8aaaf31ade",
                Duration = "5:31",
                ArtistId = 10
            });
            _songs.Add(new SongModel()
            {
                Id = 33,
                Name = "Greatest Love of All",
                Album = "Whitney Houston",
                ImgAlbum = "https://m.media-amazon.com/images/I/71n4sQ2CJpL._SL1024_.jpg",
                Duration = "4:51",
                ArtistId = 10
            });
        }
        public SongModel CreateSong(int artistId, SongModel newSong)
        {
            ValidateArtist(artistId);
            var lastSong = _songs.OrderByDescending(c => c.Id).FirstOrDefault();
            int nextId = lastSong != null ? lastSong.Id + 1 : 1;
            newSong.Id = nextId;
            newSong.ArtistId = artistId;
            _songs.Add(newSong);
            return newSong;
        }

        public bool DeleteSong(int artistId, int songId)
        {
            var song = GetSong(artistId, songId);
            _songs.Remove(song);
            return true;
        }

        public SongModel GetSong(int artistId, int songId)
        {
            ValidateArtist(artistId);
            var song = _songs.FirstOrDefault(s => s.ArtistId == artistId && s.Id == songId);
            return song;
        }

        public IEnumerable<SongModel> GetSongs(int artistId)
        {
            ValidateArtist(artistId);
            return _songs.Where(s => s.ArtistId == artistId);
        }

        public SongModel UpdateSong(int artistId, int songId, SongModel updatedSong)
        {
            var song = GetSong(artistId, songId);

            song.Name = updatedSong.Name ?? song.Name;
            song.Album = updatedSong.Album ?? song.Album;
            song.ImgAlbum = updatedSong.ImgAlbum ?? song.ImgAlbum;
            song.Duration = updatedSong.Duration ?? song.Duration;

            return song;
        }
        
        private void ValidateArtist(int artistId)
        {
            _artistsService.GetArtist(artistId);
        }
    }
}
