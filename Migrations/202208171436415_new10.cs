namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new10 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ParcelGroups", "SenderId", "dbo.Accounts");
            DropIndex("dbo.ParcelGroups", new[] { "SenderId" });
            DropColumn("dbo.ParcelGroups", "SenderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ParcelGroups", "SenderId", c => c.Int(nullable: false));
            CreateIndex("dbo.ParcelGroups", "SenderId");
            AddForeignKey("dbo.ParcelGroups", "SenderId", "dbo.Accounts", "Id", cascadeDelete: true);
        }
    }
}
