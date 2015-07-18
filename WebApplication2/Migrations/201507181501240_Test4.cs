namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test4 : DbMigration
    {
        public override void Up()
        {
            DropColumn(table: "dbo.Musicians", name: "Band_ID1");
        }
        
        public override void Down()
        {
        }
    }
}
