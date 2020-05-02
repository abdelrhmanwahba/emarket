namespace emarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddcartModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Product_id = c.Int(nullable: false, identity: true),
                        Added_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Product_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carts");
        }
    }
}
