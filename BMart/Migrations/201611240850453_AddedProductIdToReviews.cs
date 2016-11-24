namespace BMart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProductIdToReviews : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "Product_Id", "dbo.Products");
            DropIndex("dbo.Reviews", new[] { "Product_Id" });
            RenameColumn(table: "dbo.Reviews", name: "Product_Id", newName: "ProductId");
            AlterColumn("dbo.Reviews", "ProductId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reviews", "ProductId");
            AddForeignKey("dbo.Reviews", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "ProductId", "dbo.Products");
            DropIndex("dbo.Reviews", new[] { "ProductId" });
            AlterColumn("dbo.Reviews", "ProductId", c => c.Int());
            RenameColumn(table: "dbo.Reviews", name: "ProductId", newName: "Product_Id");
            CreateIndex("dbo.Reviews", "Product_Id");
            AddForeignKey("dbo.Reviews", "Product_Id", "dbo.Products", "Id");
        }
    }
}
