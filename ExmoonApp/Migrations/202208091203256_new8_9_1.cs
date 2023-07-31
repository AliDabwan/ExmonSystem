namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new8_9_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParcelGroups", "VendorIdTasleem", c => c.Int(nullable: false));
            CreateIndex("dbo.ParcelGroups", "VendorIdTasleem");
            AddForeignKey("dbo.ParcelGroups", "VendorIdTasleem", "dbo.Accounts", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParcelGroups", "VendorIdTasleem", "dbo.Accounts");
            DropIndex("dbo.ParcelGroups", new[] { "VendorIdTasleem" });
            DropColumn("dbo.ParcelGroups", "VendorIdTasleem");
        }
    }
}
