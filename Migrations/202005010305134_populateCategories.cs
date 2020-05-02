namespace emarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCategories : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT categories ON");
            Sql("INSERT INTO categories (Id, Name, number_of_products) values (1,'mobiles',0)");
            Sql("INSERT INTO categories (Id, Name, number_of_products) values (2,'computers',0)");
            Sql("INSERT INTO categories (Id, Name, number_of_products) values (3,'clothes',0)");
            Sql("SET IDENTITY_INSERT categories off");
        }
        
        public override void Down()
        {
        }
    }
}
