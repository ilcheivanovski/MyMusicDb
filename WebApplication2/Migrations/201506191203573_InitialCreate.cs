namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        IssueDate = c.DateTime(nullable: false),
                        TotalDuration = c.Time(nullable: false, precision: 7),
                        MusicianID = c.Int(nullable: false),
                        Band_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Musicians", t => t.MusicianID)
                .ForeignKey("dbo.Bands", t => t.Band_ID)
                .Index(t => t.MusicianID)
                .Index(t => t.Band_ID);
            
            CreateTable(
                "dbo.Musicians",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Band_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Bands", t => t.Band_ID)
                .Index(t => t.Band_ID);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Duration = c.Time(nullable: false, precision: 7),
                        AlbumID = c.Int(nullable: false),
                        MusicianID = c.Int(nullable: false),
                        Band_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Albums", t => t.AlbumID)
                .ForeignKey("dbo.Musicians", t => t.MusicianID)
                .ForeignKey("dbo.Bands", t => t.Band_ID)
                .Index(t => t.AlbumID)
                .Index(t => t.MusicianID)
                .Index(t => t.Band_ID);
            
            CreateTable(
                "dbo.Bands",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MusicianID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Musicians", t => t.MusicianID)
                .Index(t => t.MusicianID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "Band_ID", "dbo.Bands");
            DropForeignKey("dbo.Bands", "MusicianID", "dbo.Musicians");
            DropForeignKey("dbo.Musicians", "Band_ID", "dbo.Bands");
            DropForeignKey("dbo.Albums", "Band_ID", "dbo.Bands");
            DropForeignKey("dbo.Songs", "MusicianID", "dbo.Musicians");
            DropForeignKey("dbo.Songs", "AlbumID", "dbo.Albums");
            DropForeignKey("dbo.Albums", "MusicianID", "dbo.Musicians");
            DropIndex("dbo.Bands", new[] { "MusicianID" });
            DropIndex("dbo.Songs", new[] { "Band_ID" });
            DropIndex("dbo.Songs", new[] { "MusicianID" });
            DropIndex("dbo.Songs", new[] { "AlbumID" });
            DropIndex("dbo.Musicians", new[] { "Band_ID" });
            DropIndex("dbo.Albums", new[] { "Band_ID" });
            DropIndex("dbo.Albums", new[] { "MusicianID" });
            DropTable("dbo.Bands");
            DropTable("dbo.Songs");
            DropTable("dbo.Musicians");
            DropTable("dbo.Albums");
        }
    }
}
