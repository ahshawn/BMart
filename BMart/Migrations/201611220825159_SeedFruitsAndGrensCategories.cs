namespace BMart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedFruitsAndGrensCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Tomatoes')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Seasonal Veggies')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Salad Greens')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Sprouts & Microgreens')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Carrots & Beets')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Peppers')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Eggplants')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Potatoes')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Squash')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Root Vegetables')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Mushrooms')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Onions and Shallots')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Garlic & Other Alliums')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Herbs')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Specialty')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Apples')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Pears')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Tomatoes')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Berries')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Citrus')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Seasonal Fruit')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Tropical')");
            Sql("INSERT INTO [dbo].[Categories] ([Name]) VALUES ('Juicing Fruit')");
        }
        
        public override void Down()
        {
        }
    }
}
