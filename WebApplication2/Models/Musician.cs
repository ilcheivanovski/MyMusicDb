using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMusicDb.Models
{
    public class Musician : IPerformer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
        public List<Song> Songs { get; set; }
        public Band Band { get; set; }
    }
}