namespace BMart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeModelClass1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Reviews_Id", "dbo.Reviews");
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.OrderDetails", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Orders", "OrderDetails_Id", "dbo.OrderDetails");
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropIndex("dbo.Products", new[] { "Reviews_Id" });
            DropIndex("dbo.OrderDetails", new[] { "Product_Id" });
            DropIndex("dbo.Orders", new[] { "OrderDetails_Id" });
            RenameColumn(table: "dbo.Products", name: "Category_Id", newName: "CategoryId");
            RenameColumn(table: "dbo.OrderDetails", name: "Product_Id", newName: "ProductId");
            RenameColumn(table: "dbo.Orders", name: "OrderDetails_Id", newName: "OrderDetailsId");
            AddColumn("dbo.Reviews", "Product_Id", c => c.Int());
            AlterColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderDetails", "ProductId", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "OrderDetailsId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategoryId");
            CreateIndex("dbo.OrderDetails", "ProductId");
            CreateIndex("dbo.Orders", "OrderDetailsId");
            CreateIndex("dbo.Reviews", "Product_Id");
            AddForeignKey("dbo.Reviews", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "OrderDetailsId", "dbo.OrderDetails", "Id", cascadeDelete: true);
            DropColumn("dbo.Products", "Reviews_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Reviews_Id", c => c.Int());
            DropForeignKey("dbo.Orders", "OrderDetailsId", "dbo.OrderDetails");
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Reviews", "Product_Id", "dbo.Products");
            DropIndex("dbo.Reviews", new[] { "Product_Id" });
            DropIndex("dbo.Orders", new[] { "OrderDetailsId" });
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            AlterColumn("dbo.Orders", "OrderDetailsId", c => c.Int());
            AlterColumn("dbo.OrderDetails", "ProductId", c => c.Int());
            AlterColumn("dbo.Products", "CategoryId", c => c.Int());
            DropColumn("dbo.Reviews", "Product_Id");
            RenameColumn(table: "dbo.Orders", name: "OrderDetailsId", newName: "OrderDetails_Id");
            RenameColumn(table: "dbo.OrderDetails", name: "ProductId", newName: "Product_Id");
            RenameColumn(table: "dbo.Products", name: "CategoryId", newName: "Category_Id");
            CreateIndex("dbo.Orders", "OrderDetails_Id");
            CreateIndex("dbo.OrderDetails", "Product_Id");
            CreateIndex("dbo.Products", "Reviews_Id");
            CreateIndex("dbo.Products", "Category_Id");
            AddForeignKey("dbo.Orders", "OrderDetails_Id", "dbo.OrderDetails", "Id");
            AddForeignKey("dbo.OrderDetails", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.Products", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Products", "Reviews_Id", "dbo.Reviews", "Id");
        }
    }
}
