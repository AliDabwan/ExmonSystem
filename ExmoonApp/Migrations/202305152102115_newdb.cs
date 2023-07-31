namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdb : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ItemCompanyTorism", newName: "CompanyTorism");
            RenameTable(name: "dbo.ItemDistricts", newName: "Districts");
            RenameTable(name: "dbo.ItemDrivers", newName: "Drivers");
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        No = c.Long(nullable: false),
                        Barcode = c.String(),
                        AttachmentName = c.String(),
                        AttachmentType = c.String(maxLength: 50),
                        AttachmeedFile = c.Binary(),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        LastName = c.String(),
                        FamilyName = c.String(),
                        EnName = c.String(),
                        Gender = c.String(),
                        MotherName = c.String(),
                        PhoneNumber = c.String(),
                        PassportNo = c.Long(nullable: false),
                        IssuedDate = c.DateTime(nullable: false),
                        ExpierDate = c.DateTime(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdateDate = c.DateTime(),
                        LastUpdateUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedUserId, cascadeDelete: true)
                .Index(t => t.CreatedUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CreatedUserId", "dbo.Users");
            DropIndex("dbo.Customers", new[] { "CreatedUserId" });
            DropTable("dbo.Customers");
            RenameTable(name: "dbo.Drivers", newName: "ItemDrivers");
            RenameTable(name: "dbo.Districts", newName: "ItemDistricts");
            RenameTable(name: "dbo.CompanyTorism", newName: "ItemCompanyTorism");
        }
    }
}
