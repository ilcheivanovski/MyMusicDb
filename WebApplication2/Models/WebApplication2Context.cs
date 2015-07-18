using MyMusicDb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class WebApplication2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public WebApplication2Context()
            : base("name=WebApplication2Context")
        {
        }

        public System.Data.Entity.DbSet<MyMusicDb.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<MyMusicDb.Models.Musician> Musicians { get; set; }

        public System.Data.Entity.DbSet<MyMusicDb.Models.Band> Bands { get; set; }

        public System.Data.Entity.DbSet<MyMusicDb.Models.Song> Songs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Album>()
                .HasRequired(t => t.Musician)
                .WithMany(t => t.Albums)
                .HasForeignKey(d => d.MusicianID)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Song>()
                .HasRequired(t => t.Album)
                .WithMany(t => t.Songs)
                .HasForeignKey(d => d.AlbumID)
                .WillCascadeOnDelete(true);


            //// Configure Band as FK for Musician
            modelBuilder.Entity<Band>()
                        .HasMany(b => b.Members) // Mark Musician is optional for Band
                        .WithOptional(m => m.Band) // Create inverse relationship
                        .WillCascadeOnDelete(false);
        }
    }
}
