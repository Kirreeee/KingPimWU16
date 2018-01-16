namespace KingPim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "CatalogName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CatalogName", c => c.String());
        }
    }
}
