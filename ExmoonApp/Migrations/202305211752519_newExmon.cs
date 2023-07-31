namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newExmon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AirLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Countries = c.String(),
                        ReportName = c.String(),
                        Sympol = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExCompanies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NameEn = c.String(),
                        GoverName = c.String(),
                        DistrictName = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        AdminName = c.String(),
                        AdminPhoneNumber = c.String(),
                        DriverId = c.Int(nullable: false),
                        SubscrberId = c.Int(nullable: false),
                        PriceForPassport = c.Double(nullable: false),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdateDate = c.DateTime(),
                        LastUpdateUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedUserId, cascadeDelete: true)
                .ForeignKey("dbo.Drivers", t => t.DriverId, cascadeDelete: true)
                .ForeignKey("dbo.Subscribers", t => t.SubscrberId, cascadeDelete: true)
                .Index(t => t.DriverId)
                .Index(t => t.SubscrberId)
                .Index(t => t.CreatedUserId);
            
            CreateTable(
                "dbo.Subscribers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExCompanies", "SubscrberId", "dbo.Subscribers");
            DropForeignKey("dbo.ExCompanies", "DriverId", "dbo.Drivers");
            DropForeignKey("dbo.ExCompanies", "CreatedUserId", "dbo.Users");
            DropIndex("dbo.ExCompanies", new[] { "CreatedUserId" });
            DropIndex("dbo.ExCompanies", new[] { "SubscrberId" });
            DropIndex("dbo.ExCompanies", new[] { "DriverId" });
            DropTable("dbo.Subscribers");
            DropTable("dbo.ExCompanies");
            DropTable("dbo.AirLines");
        }
    }
}
