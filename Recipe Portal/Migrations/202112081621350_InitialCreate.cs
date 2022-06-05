namespace Recipe_Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        RecipeID = c.Int(nullable: false, identity: true),
                        RecipeName = c.String(),
                        Category = c.String(),
                        ImageUrl = c.String(),
                        CookingTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecipeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Recipes");
        }
    }
}
