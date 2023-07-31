namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editPassport : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "PassportNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PassportNo", c => c.Long(nullable: false));
        }
    }
}
