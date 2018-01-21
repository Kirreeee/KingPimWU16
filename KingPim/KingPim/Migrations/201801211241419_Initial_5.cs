namespace KingPim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "SubCategoryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "SubCategoryName", c => c.String());
        }
    }
}
