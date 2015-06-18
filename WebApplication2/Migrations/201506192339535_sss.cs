namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sss : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Musicians", "Band_ID1", "dbo.Bands");
            DropForeignKey("dbo.Bands", "MusicianID", "dbo.Musicians");
            DropForeignKey("dbo.Songs", "MusicianID", "dbo.Musicians");
            DropForeignKey("dbo.Albums", "MusicianID", "dbo.Musicians");
            DropIndex("dbo.Musicians", new[] { "Band_ID1" });
            DropIndex("dbo.Bands", new[] { "MusicianID" });
            DropColumn("dbo.Musicians", "ID");
            DropColumn("dbo.Musicians", "ID");
            RenameColumn(table: "dbo.Musicians", name: "Band_ID1", newName: "ID");
            RenameColumn(table: "dbo.Musicians", name: "MusicianID", newName: "ID");
            DropPrimaryKey("dbo.Musicians");
            AddColumn("dbo.Musicians", "BandID", c => c.Int(nullable: false));
            AlterColumn("dbo.Musicians", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Musicians", "ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Musicians", "ID");
            CreateIndex("dbo.Musicians", "ID");
            AddForeignKey("dbo.Musicians", "ID", "dbo.Bands", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Songs", "MusicianID", "dbo.Musicians", "ID");
            AddForeignKey("dbo.Albums", "MusicianID", "dbo.Musicians", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "MusicianID", "dbo.Musicians");
            DropForeignKey("dbo.Songs", "MusicianID", "dbo.Musicians");
            DropForeignKey("dbo.Musicians", "ID", "dbo.Bands");
            DropIndex("dbo.Musicians", new[] { "ID" });
            DropPrimaryKey("dbo.Musicians");
            AlterColumn("dbo.Musicians", "ID", c => c.Int());
            AlterColumn("dbo.Musicians", "ID", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Musicians", "BandID");
            AddPrimaryKey("dbo.Musicians", "ID");
            RenameColumn(table: "dbo.Musicians", name: "ID", newName: "MusicianID");
            RenameColumn(table: "dbo.Musicians", name: "ID", newName: "Band_ID1");
            AddColumn("dbo.Musicians", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Musicians", "ID", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.Bands", "MusicianID");
            CreateIndex("dbo.Musicians", "Band_ID1");
            AddForeignKey("dbo.Albums", "MusicianID", "dbo.Musicians", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Songs", "MusicianID", "dbo.Musicians", "ID");
            AddForeignKey("dbo.Bands", "MusicianID", "dbo.Musicians", "ID");
            AddForeignKey("dbo.Musicians", "Band_ID1", "dbo.Bands", "ID");
        }
    }
}
