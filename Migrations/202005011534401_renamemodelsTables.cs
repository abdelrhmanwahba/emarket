namespace emarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamemodelsTables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Products", newName: "Product");
            RenameTable(name: "dbo.Categories", newName: "Category");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Category", newName: "Categories");
            RenameTable(name: "dbo.Product", newName: "Products");
        }
    }
}
