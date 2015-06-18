using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMusicDb.Models
{
    public interface IPerformer
    {
        List<Album> Albums { get; set; }
        List<Song> Songs { get; set; }
    }
}