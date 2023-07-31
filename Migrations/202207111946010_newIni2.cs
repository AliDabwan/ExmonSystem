namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newIni2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "VendorType", c => c.String());
            DropColumn("dbo.Accounts", "IsVendorType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "IsVendorType", c => c.Boolean(nullable: false));
            DropColumn("dbo.Accounts", "VendorType");
        }
    }
}
