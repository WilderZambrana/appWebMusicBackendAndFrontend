using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FifthHomework.Models
{
    public class ArtistModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public string PlaceBorn { get; set; }
        public DateTime?  DateBorn { get; set; }
    }
}
