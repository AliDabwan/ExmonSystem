namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new8_9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ParcelGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReciverGover = c.String(),
                        TasleemComm = c.Double(nullable: false),
                        Parcelcount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Parcels", "ParcelGroupId", c => c.Int(nullable: false));
            CreateIndex("dbo.Parcels", "ParcelGroupId");
            AddForeignKey("dbo.Parcels", "ParcelGroupId", "dbo.ParcelGroups", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parcels", "ParcelGroupId", "dbo.ParcelGroups");
            DropIndex("dbo.Parcels", new[] { "ParcelGroupId" });
            DropColumn("dbo.Parcels", "ParcelGroupId");
            DropTable("dbo.ParcelGroups");
        }
    }
}
