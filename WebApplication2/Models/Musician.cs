using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMusicDb.Models
{
    public class Musician : IPerformer
    {
        public Musician()
        {
            Albums = new HashSet<Album>();
            Songs = new HashSet<Song>();
        }

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Album> Albums { get; set; }
        public ICollection<Song> Songs { get; set; }
        public Band Band { get; set; }
        //public Nullable<int> BandId { get; set; }
    }
}