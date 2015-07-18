using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyMusicDb.Models
{
    public class Band : IPerformer
    {
        public Band()
        {
            Members = new HashSet<Musician>();
            Songs = new HashSet<Song>();
            Albums = new HashSet<Album>();
        }
        [Key]
        public int ID { get; set; }
        public ICollection<Album> Albums { get; set; }
        public ICollection<Song> Songs { get; set; }
        public string Name { get; set; }
        public ICollection<Musician> Members { get; set; }
    }
}