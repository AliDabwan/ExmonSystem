namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newCarType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        No = c.Long(nullable: false),
                        Barcode = c.String(),
                        AttachmentName = c.String(),
                        AttachmentType = c.String(maxLength: 50),
                        AttachmeedFile = c.Binary(),
                        CarNumber = c.String(),
                        CustomerName = c.String(),
                        CustomerPhone = c.String(),
                        Note = c.String(),
                        CarTypeId = c.Int(nullable: false),
                        WashingCounterId = c.Int(nullable: false),
                        TransDate = c.DateTime(nullable: false),
                        Total = c.Double(nullable: false),
                        TotalNetWords = c.String(),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdateDate = c.DateTime(),
                        LastUpdateUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedUserId, cascadeDelete: true)
                .ForeignKey("dbo.CarTypes", t => t.CarTypeId, cascadeDelete: true)
                .ForeignKey("dbo.WashingCounters", t => t.WashingCounterId, cascadeDelete: true)
                .Index(t => t.CarTypeId)
                .Index(t => t.WashingCounterId)
                .Index(t => t.CreatedUserId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "WashingCounterId", "dbo.WashingCounters");
            DropForeignKey("dbo.Transactions", "CarTypeId", "dbo.CarTypes");
            DropForeignKey("dbo.Transactions", "CreatedUserId", "dbo.Users");
            DropIndex("dbo.Transactions", new[] { "CreatedUserId" });
            DropIndex("dbo.Transactions", new[] { "WashingCounterId" });
            DropIndex("dbo.Transactions", new[] { "CarTypeId" });
            DropTable("dbo.WashingCounters");
            DropTable("dbo.Transactions");
            DropTable("dbo.CarTypes");
        }
    }
}
