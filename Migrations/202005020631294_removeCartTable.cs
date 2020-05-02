namespace emarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeCartTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cart", "Product_id", "dbo.Product");
            DropIndex("dbo.Cart", new[] { "Product_id" });
            DropTable("dbo.Cart");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Cart",
                c => new
                    {
                        Product_id = c.Int(nullable: false),
                        Added_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Product_id);
            
            CreateIndex("dbo.Cart", "Product_id");
            AddForeignKey("dbo.Cart", "Product_id", "dbo.Product", "Id");
        }
    }
}
