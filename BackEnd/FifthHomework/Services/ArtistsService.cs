using FifthHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FifthHomework.Services
{
    public class ArtistsService : IArtistsService
    {
        private List<ArtistModel> _artists;
        
        public ArtistsService()
        {
            _artists = new List<ArtistModel>();

            _artists.Add(new ArtistModel()
            {
                Id = 1,
                Name = "Adele",
                Img= "https://phantom-marca.unidadeditorial.es/51b530ba664d6228777a53da5c133b1f/resize/1320/f/jpg/assets/multimedia/imagenes/2021/11/20/16373638222232.jpg",
                Description= "Adele Laurie Blue Adkins, conocida simplemente como Adele, es una cantautora y multinstrumentista...",
                PlaceBorn = "Tottenham, Londres, Reino Unido",
                DateBorn = new DateTime(1988, 05, 5)
            });
            _artists.Add(new ArtistModel()
            {
                Id = 2,
                Name = "Billie Eilish",
                Img = "https://www.lahiguera.net/musicalia/artistas/billie_eilish/disco/11217/billie_eilish_happier_than_ever-portada.jpg",
                Description = "Pirate Baird O'Connell es una cantante y compositora estadounidense.Adquirió...",
                PlaceBorn = "Los Ángeles, California, Estados Unidos",
                DateBorn = new DateTime(2001, 12, 18)
            });
            _artists.Add(new ArtistModel()
            {
                Id = 3,
                Name = "Bob Marley",
                Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR1UfKxX4flfCcuDHC-RTOCq9joxFtdEQ9ZJsDH0Uio0W12UJNw8oKTTE6_AssWl-T75a0&usqp=CAU",
                Description = "Robert Nesta Marley, más conocido como Bob Marley, fue un músico, guitarrista y compositor...",
                PlaceBorn = "Nine Mile, Jamaica",
                DateBorn = new DateTime(1945, 02, 06)
            });
            _artists.Add(new ArtistModel()
            {
                Id = 4,
                Name = "Eminem",
                Img = "https://cdns-images.dzcdn.net/images/artist/19cc38f9d69b352f718782e7a22f9c32/500x500.jpg",
                Description = "Marshall Bruce Mathers III, conocido artísticamente como Eminem o como Slim Shady, es un rapero, productor...",
                PlaceBorn = "St. Joseph, Misuri, Estados Unidos",
                DateBorn = new DateTime(1972, 10, 17)
            });
            _artists.Add(new ArtistModel()
            {
                Id = 5,
                Name = "Freddie Mercury",
                Img = "https://barnebys.imgix.net/https%3A%2F%2Fimages.pristineauction.com%2F113%2F1134029%2Fmain_1548985911-Hector-Monroy-Signed-Freddie-Mercury-26x355-Original-Oil-Painting-on-Canvas-PA-LOA-PristineAuction.com.jpg?auto=format%2Ccompress&crop=0&cs=tinysrgb&fit=crop&h=400&ixlib=php-2.3.0&trim=auto&w=400&s=d369f8d2021b451a14508c6d631f5bb9",
                Description = "Freddie Mercury fue un cantante, compositor, pianista, guitarrista, diseñador gráfico​ y músico británico de...",
                PlaceBorn = "Stone Town, Tanzania",
                DateBorn = new DateTime(1946, 09, 05)
            });
            _artists.Add(new ArtistModel()
            {
                Id = 6,
                Name = "J Balvin",
                Img = "https://es.unbilgi.com/wp-content/uploads/2021/02/J-Balvin.jpg",
                Description = "José Álvaro Osorio Balvín, conocido como J Balvin, es un cantante y productor discográfico colombiano, que ha...",
                PlaceBorn = "Medellín, Colombia",
                DateBorn = new DateTime(1985, 05, 07)
            });
            _artists.Add(new ArtistModel()
            {
                Id = 7,
                Name = "Julio Iglesias",
                Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR6iFPQsnJoJdii-QMsv5yzoPeP20ju7yUZ7q-ox8REaLRTnPSey4zeeoeddQo77SheTEc&usqp=CAU",
                Description = "Julio José Iglesias de la Cueva, más conocido como Julio Iglesias, es un cantante, compositor, músico, productor...",
                PlaceBorn = "Madrid, España",
                DateBorn = new DateTime(1943, 09, 23)
            });
            _artists.Add(new ArtistModel()
            {
                Id = 8,
                Name = "Micro TDH",
                Img = "https://yt3.ggpht.com/ytc/AKedOLT7fO_lhmHszewTxT_UG_UTWHx8wZ6qzgUcpXtT_g=s900-c-k-c0x00ffffff-no-rj",
                Description = "ernando Daniel Morillo Rivas, conocido artísticamente como Micro TDH, ​ es un cantante, rapero...",
                PlaceBorn = "Mérida, Venezuela",
                DateBorn = new DateTime(1999, 04, 14)
            });
            _artists.Add(new ArtistModel()
            {
                Id = 9,
                Name = "Rihanna",
                Img = "https://www.lavanguardia.com/files/content_image_mobile_filter/files/fp/uploads/2021/03/04/6040b6fc95d08.r_d.542-450.jpeg",
                Description = "Robyn Rihanna Fenty, conocida simplemente como Rihanna, es una cantante, empresaria, diseñadora de moda, actriz...",
                PlaceBorn = "Parroquia de Saint Michael, Barbados",
                DateBorn = new DateTime(1988, 02, 20)
            });
            _artists.Add(new ArtistModel()
            {
                Id = 10,
                Name = "Whitney Houston",
                Img = "https://upload.wikimedia.org/wikipedia/commons/a/a7/Whitney_Houston_Welcome_Home_Heroes_1_cropped.jpg",
                Description = "Whitney Elizabeth Houston, conocida como Whitney Houston, fue una cantante estadounidense de R & B, soul, blues...",
                PlaceBorn = "Newark, Nueva Jersey, Estados Unidos",
                DateBorn = new DateTime(1963, 08, 09)
            });
        }

        public ArtistModel CreateArtist(ArtistModel newArtist)
        {
            var lastArtist = _artists.OrderByDescending(c => c.Id).FirstOrDefault();
            int nextId = lastArtist != null ? lastArtist.Id + 1 : 1;
            newArtist.Id = nextId;
            _artists.Add(newArtist);
            return newArtist;
        }

        public bool DeleteArtist(int artistId)
        {
            var artist = _artists.FirstOrDefault(a => a.Id == artistId);
            _artists.Remove(artist);
            return true;
        }

        public ArtistModel GetArtist(int artistId)
        {
            var artist = _artists.FirstOrDefault(a => a.Id == artistId);                
            return artist;
        }

        public IEnumerable<ArtistModel> GetArtists()
        {
            return _artists;
        }

        public ArtistModel UpdateArtist(int artistId, ArtistModel updatedArtist)
        {
            var artist = _artists.First(a => a.Id == artistId);

            artist.Name = updatedArtist.Name ?? artist.Name;
            artist.Img = updatedArtist.Img ?? artist.Img;
            artist.Description = updatedArtist.Description ?? artist.Description;
            artist.PlaceBorn = updatedArtist.PlaceBorn ?? artist.PlaceBorn;
            artist.DateBorn = updatedArtist.DateBorn ?? artist.DateBorn;

            return artist;
        }
    }
}
