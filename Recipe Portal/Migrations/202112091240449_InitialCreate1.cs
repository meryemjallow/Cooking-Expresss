namespace Recipe_Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recipes", "Ingredients", c => c.String());
            AddColumn("dbo.Recipes", "Steps", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recipes", "Steps");
            DropColumn("dbo.Recipes", "Ingredients");
        }
    }
}
