namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new8_9_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParcelGroups", "SenderId", c => c.Int(nullable: false));
            CreateIndex("dbo.ParcelGroups", "SenderId");
            AddForeignKey("dbo.ParcelGroups", "SenderId", "dbo.Accounts", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParcelGroups", "SenderId", "dbo.Accounts");
            DropIndex("dbo.ParcelGroups", new[] { "SenderId" });
            DropColumn("dbo.ParcelGroups", "SenderId");
        }
    }
}
