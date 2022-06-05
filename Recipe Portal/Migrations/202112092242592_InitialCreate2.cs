namespace Recipe_Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recipes", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recipes", "Image");
        }
    }
}
