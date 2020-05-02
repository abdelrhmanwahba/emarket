namespace emarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetIdentityInsertOnForCartTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT cart ON");
        }
        
        public override void Down()
        {
        }
    }
}
