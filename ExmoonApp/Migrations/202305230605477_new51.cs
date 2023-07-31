namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new51 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ExCompanies", "PhoneNumber", c => c.Long(nullable: false));
            AlterColumn("dbo.ExCompanies", "AdminPhoneNumber", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ExCompanies", "AdminPhoneNumber", c => c.String());
            AlterColumn("dbo.ExCompanies", "PhoneNumber", c => c.String());
        }
    }
}
