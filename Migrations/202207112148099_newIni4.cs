namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newIni4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Parcels", "FromVendorToStoreDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Parcels", "FromVendorToStoreDate", c => c.DateTime());
        }
    }
}
