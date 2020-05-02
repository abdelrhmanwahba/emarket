namespace emarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameCartmoel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Carts", newName: "cart");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.cart", newName: "Carts");
        }
    }
}
