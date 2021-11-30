using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FifthHomework.Models
{
    public class SongModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Album { get; set; }
        public string ImgAlbum { get; set; }
        public string Duration { get; set; }
        public int ArtistId { get; set; }
    }
}
