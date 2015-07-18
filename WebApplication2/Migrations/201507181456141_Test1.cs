namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Musicians", name: "BandId", newName: "Band_ID");
            RenameIndex(table: "dbo.Musicians", name: "IX_BandId", newName: "IX_Band_ID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Musicians", name: "IX_Band_ID", newName: "IX_BandId");
            RenameColumn(table: "dbo.Musicians", name: "Band_ID", newName: "BandId");
        }
    }
}
