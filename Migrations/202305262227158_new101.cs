namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new101 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Parcels", "CreatedUserId", "dbo.Users");
            DropForeignKey("dbo.Parcels", "ParcelGroupId", "dbo.ParcelGroups");
            DropForeignKey("dbo.Parcels", "SenderId", "dbo.Accounts");
            DropForeignKey("dbo.Parcels", "VendorIdTasleem", "dbo.Accounts");
            DropForeignKey("dbo.Parcels", "VendorIdTawseel", "dbo.Accounts");
            DropForeignKey("dbo.ParcelGroups", "VendorIdTasleem", "dbo.Accounts");
            DropIndex("dbo.ParcelGroups", new[] { "VendorIdTasleem" });
            DropIndex("dbo.Parcels", new[] { "VendorIdTasleem" });
            DropIndex("dbo.Parcels", new[] { "VendorIdTawseel" });
            DropIndex("dbo.Parcels", new[] { "SenderId" });
            DropIndex("dbo.Parcels", new[] { "ParcelGroupId" });
            DropIndex("dbo.Parcels", new[] { "CreatedUserId" });
            DropTable("dbo.ParcelGroups");
            DropTable("dbo.Parcels");
            DropTable("dbo.WashingCounters");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.WashingCounters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AdminName = c.String(),
                        Statue = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parcels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        No = c.Long(nullable: false),
                        VoucherNo = c.Long(nullable: false),
                        Barcode = c.String(),
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
                        SenderName = c.String(),
                        ParcelGroupId = c.Int(nullable: false),
                        FromVendorToStoreStatue = c.Boolean(nullable: false),
                        FromVendorToStoreDate = c.DateTime(nullable: false),
                        FromStoreToVendorStatue = c.Boolean(nullable: false),
                        FromStoreToVendorDate = c.DateTime(),
                        IsReturnToStoreStatue = c.Boolean(nullable: false),
                        ReturnToStoreDate = c.DateTime(),
                        IsReturnToSenderStatue = c.Boolean(nullable: false),
                        ReturnToSenderDate = c.DateTime(),
                        IsGoToEndStatue = c.Boolean(nullable: false),
                        GoToEndDate = c.DateTime(),
                        IsPaidStatue = c.Boolean(nullable: false),
                        PaidStatueDate = c.DateTime(),
                        IsPaidTasleemStatue = c.Boolean(nullable: false),
                        IsPaidTasleemStatueDate = c.DateTime(),
                        IsPaidTawseelStatue = c.Boolean(nullable: false),
                        IsPaidTawseelStatueDate = c.DateTime(),
                        IsFreezeStatue = c.Boolean(nullable: false),
                        IsFreezeNote = c.String(),
                        FreezeDate = c.DateTime(),
                        Total = c.Double(nullable: false),
                        TasleemComm = c.Double(nullable: false),
                        TotalAmmount = c.Double(nullable: false),
                        TawseelComm = c.Double(nullable: false),
                        TotalCom = c.Double(nullable: false),
                        TotalNetRtrn = c.Double(nullable: false),
                        TotalNet = c.Double(nullable: false),
                        TawseelSenderAmmount = c.Double(nullable: false),
                        TotalNetAfterTawseelSenderAmmount = c.Double(nullable: false),
                        TotalNetWords = c.String(),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdateDate = c.DateTime(),
                        LastUpdateUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ParcelGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReciverGover = c.String(),
                        TasleemComm = c.Double(nullable: false),
                        VendorIdTasleem = c.Int(nullable: false),
                        GroupStatue = c.Boolean(nullable: false),
                        CreatedUserId = c.Int(nullable: false),
                        IsPaidTasleemStatue = c.Boolean(nullable: false),
                        IsPaidTasleemStatueDate = c.DateTime(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdateDate = c.DateTime(),
                        LastUpdateUserId = c.Int(),
                        Parcelcount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Parcels", "CreatedUserId");
            CreateIndex("dbo.Parcels", "ParcelGroupId");
            CreateIndex("dbo.Parcels", "SenderId");
            CreateIndex("dbo.Parcels", "VendorIdTawseel");
            CreateIndex("dbo.Parcels", "VendorIdTasleem");
            CreateIndex("dbo.ParcelGroups", "VendorIdTasleem");
            AddForeignKey("dbo.ParcelGroups", "VendorIdTasleem", "dbo.Accounts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Parcels", "VendorIdTawseel", "dbo.Accounts", "Id");
            AddForeignKey("dbo.Parcels", "VendorIdTasleem", "dbo.Accounts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Parcels", "SenderId", "dbo.Accounts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Parcels", "ParcelGroupId", "dbo.ParcelGroups", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Parcels", "CreatedUserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
