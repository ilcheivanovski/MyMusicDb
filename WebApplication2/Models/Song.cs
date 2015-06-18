using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMusicDb.Models
{
    public class Song
    {
        public int ID { get; set; }
        public IPerformer Performer { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public int AlbumID { get; set; }
        public Album Album { get; set; }
        public int MusicianID { get; set; }
        public Musician Musician { get; set; }

        public void Play(string title)
        {
            title = Title;
        }
    }
}