namespace Recipe_Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Recipes", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Recipes", "Image", c => c.String());
        }
    }
}
