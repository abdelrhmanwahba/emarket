namespace emarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edutcartModel : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Carts");
            AlterColumn("dbo.Carts", "Product_id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Carts", "Product_id");
            CreateIndex("dbo.Carts", "Product_id");
            AddForeignKey("dbo.Carts", "Product_id", "dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "Product_id", "dbo.Products");
            DropIndex("dbo.Carts", new[] { "Product_id" });
            DropPrimaryKey("dbo.Carts");
            AlterColumn("dbo.Carts", "Product_id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Carts", "Product_id");
        }
    }
}
