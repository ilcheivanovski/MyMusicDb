namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationBandMembers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bands", "MusicianID", "dbo.Musicians");
            DropIndex("dbo.Musicians", new[] { "Band_ID1" });
            DropIndex("dbo.Bands", new[] { "MusicianID" });
            RenameColumn(table: "dbo.Musicians", name: "Band_ID", newName: "BandId");
            RenameIndex(table: "dbo.Musicians", name: "IX_Band_ID", newName: "IX_BandId");
            DropColumn("dbo.Bands", "MusicianID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bands", "MusicianID", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Musicians", name: "IX_BandId", newName: "IX_Band_ID");
            RenameColumn(table: "dbo.Musicians", name: "BandId", newName: "Band_ID");
            CreateIndex("dbo.Bands", "MusicianID");
            CreateIndex("dbo.Musicians", "Band_ID");
            AddForeignKey("dbo.Bands", "MusicianID", "dbo.Musicians", "ID");
        }
    }
}
