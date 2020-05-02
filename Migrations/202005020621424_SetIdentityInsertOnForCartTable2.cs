namespace emarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetIdentityInsertOnForCartTable2 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Cart ON");
        }
        
        public override void Down()
        {
        }
    }
}
