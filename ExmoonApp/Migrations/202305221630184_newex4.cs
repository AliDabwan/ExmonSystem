namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newex4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Note = c.String(),
                        DriverId = c.Int(nullable: false),
                        ExCompanyId = c.Int(nullable: false),
                        OrderCount = c.Int(nullable: false),
                        TotalAmount = c.Double(nullable: false),
                        TotalPaid = c.Double(nullable: false),
                        IsPaid = c.Boolean(nullable: false),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdateDate = c.DateTime(),
                        LastUpdateUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedUserId, cascadeDelete: false)
                .ForeignKey("dbo.Drivers", t => t.DriverId, cascadeDelete: false)
                .ForeignKey("dbo.ExCompanies", t => t.ExCompanyId, cascadeDelete: false)
                .Index(t => t.DriverId)
                .Index(t => t.ExCompanyId)
                .Index(t => t.CreatedUserId);
            
            CreateTable(
                "dbo.OrderSubs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OrderId = c.Long(nullable: false),
                        Note = c.String(),
                        DestinationId = c.Int(nullable: false),
                        AirlineId = c.Int(nullable: false),
                        SubCount = c.Int(nullable: false),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdateDate = c.DateTime(),
                        LastUpdateUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AirLines", t => t.AirlineId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.CreatedUserId, cascadeDelete: false)
                .ForeignKey("dbo.Destinations", t => t.DestinationId, cascadeDelete: false)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.DestinationId)
                .Index(t => t.AirlineId)
                .Index(t => t.CreatedUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderSubs", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderSubs", "DestinationId", "dbo.Destinations");
            DropForeignKey("dbo.OrderSubs", "CreatedUserId", "dbo.Users");
            DropForeignKey("dbo.OrderSubs", "AirlineId", "dbo.AirLines");
            DropForeignKey("dbo.Orders", "ExCompanyId", "dbo.ExCompanies");
            DropForeignKey("dbo.Orders", "DriverId", "dbo.Drivers");
            DropForeignKey("dbo.Orders", "CreatedUserId", "dbo.Users");
            DropIndex("dbo.OrderSubs", new[] { "CreatedUserId" });
            DropIndex("dbo.OrderSubs", new[] { "AirlineId" });
            DropIndex("dbo.OrderSubs", new[] { "DestinationId" });
            DropIndex("dbo.OrderSubs", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "CreatedUserId" });
            DropIndex("dbo.Orders", new[] { "ExCompanyId" });
            DropIndex("dbo.Orders", new[] { "DriverId" });
            DropTable("dbo.OrderSubs");
            DropTable("dbo.Orders");
        }
    }
}
