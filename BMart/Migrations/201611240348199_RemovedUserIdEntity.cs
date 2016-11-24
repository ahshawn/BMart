namespace BMart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedUserIdEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Carts", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Reviews", new[] { "UserId" });
            DropIndex("dbo.Carts", new[] { "UserId" });
            DropIndex("dbo.Orders", new[] { "UserId" });
            AlterColumn("dbo.Reviews", "UserId", c => c.String());
            AlterColumn("dbo.Carts", "UserId", c => c.String());
            AlterColumn("dbo.Orders", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Carts", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Reviews", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Orders", "UserId");
            CreateIndex("dbo.Carts", "UserId");
            CreateIndex("dbo.Reviews", "UserId");
            AddForeignKey("dbo.Orders", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Carts", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Reviews", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
