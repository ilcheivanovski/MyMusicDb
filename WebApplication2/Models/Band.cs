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
        public int ID { get; set; }
        public List<Album> Albums { get; set; }
        public List<Song> Songs { get; set; }
        public string Name { get; set; }
        public List<Musician> Members { get; set; }
        public int MusicianID { get; set; }
        public Musician Musician { get; set; }
    }
}