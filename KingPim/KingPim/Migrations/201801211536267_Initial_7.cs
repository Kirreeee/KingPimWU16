namespace KingPim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Published", c => c.Boolean(nullable: false));
            AddColumn("dbo.Subcategories", "Published", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "Published", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Published");
            DropColumn("dbo.Subcategories", "Published");
            DropColumn("dbo.Categories", "Published");
        }
    }
}
