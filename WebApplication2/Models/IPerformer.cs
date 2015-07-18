using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMusicDb.Models
{
    public interface IPerformer
    {
        ICollection<Album> Albums { get; set; }
        ICollection<Song> Songs { get; set; }
    }
}