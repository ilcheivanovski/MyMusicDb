using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMusicDb.Models
{
    public class Album
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime IssueDate { get; set; }
        public IPerformer Performer { get; set; }
        public List<Song> Songs { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public int MusicianID { get; set; }
        public Musician Musician { get; set; }
    }
}