namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newIni3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parcels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        No = c.Long(nullable: false),
                        AttachmentName = c.String(),
                        AttachmentType = c.String(maxLength: 50),
                        AttachmeedFile = c.Binary(),
                        ReciverName = c.String(),
                        ReciverGover = c.String(),
                        ReciverPhone = c.String(),
                        Note = c.String(),
                        VendorIdTasleem = c.Int(nullable: false),
                        VendorIdTawseel = c.Int(),
                        SenderId = c.Int(nullable: false),
                        SenderPhone = c.String(),
                        FromVendorToStoreStatue = c.Boolean(nullable: false),
                        FromVendorToStoreDate = c.DateTime(),
                        FromStoreToVendorStatue = c.Boolean(nullable: false),
                        FromStoreToVendorDate = c.DateTime(),
                        Total = c.Double(nullable: false),
                        TasleemComm = c.Double(nullable: false),
                        TotalAmmount = c.Double(nullable: false),
                        TawseelComm = c.Double(nullable: false),
                        TotalNet = c.Double(nullable: false),
                        TotalNetWords = c.String(),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdateDate = c.DateTime(),
                        LastUpdateUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedUserId, cascadeDelete: false)
                .ForeignKey("dbo.Accounts", t => t.SenderId, cascadeDelete: false)
                .ForeignKey("dbo.Accounts", t => t.VendorIdTasleem, cascadeDelete: false)
                .ForeignKey("dbo.Accounts", t => t.VendorIdTawseel)
                .Index(t => t.VendorIdTasleem)
                .Index(t => t.VendorIdTawseel)
                .Index(t => t.SenderId)
                .Index(t => t.CreatedUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parcels", "VendorIdTawseel", "dbo.Accounts");
            DropForeignKey("dbo.Parcels", "VendorIdTasleem", "dbo.Accounts");
            DropForeignKey("dbo.Parcels", "SenderId", "dbo.Accounts");
            DropForeignKey("dbo.Parcels", "CreatedUserId", "dbo.Users");
            DropIndex("dbo.Parcels", new[] { "CreatedUserId" });
            DropIndex("dbo.Parcels", new[] { "SenderId" });
            DropIndex("dbo.Parcels", new[] { "VendorIdTawseel" });
            DropIndex("dbo.Parcels", new[] { "VendorIdTasleem" });
            DropTable("dbo.Parcels");
        }
    }
}
