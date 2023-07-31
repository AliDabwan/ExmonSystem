namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "CreatedUserId", "dbo.Users");
            DropForeignKey("dbo.Transactions", "CarTypeId", "dbo.CarTypes");
            DropIndex("dbo.Transactions", new[] { "CarTypeId" });
            DropIndex("dbo.Transactions", new[] { "CreatedUserId" });
            AddColumn("dbo.Orders", "PrintedStatue", c => c.String());
            DropTable("dbo.Transactions");
        }
        
        public override void Down()
        {
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
                        TransDate = c.DateTime(nullable: false),
                        Total = c.Double(nullable: false),
                        TotalNetWords = c.String(),
                        CreatedUserId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastUpdateDate = c.DateTime(),
                        LastUpdateUserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Orders", "PrintedStatue");
            CreateIndex("dbo.Transactions", "CreatedUserId");
            CreateIndex("dbo.Transactions", "CarTypeId");
            AddForeignKey("dbo.Transactions", "CarTypeId", "dbo.CarTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Transactions", "CreatedUserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
