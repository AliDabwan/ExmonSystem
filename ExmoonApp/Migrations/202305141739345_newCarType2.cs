namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newCarType2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "WashingCounterId", "dbo.WashingCounters");
            DropIndex("dbo.Transactions", new[] { "WashingCounterId" });
            RenameColumn(table: "dbo.Transactions", name: "WashingCounterId", newName: "WashingCounter_Id");
            AlterColumn("dbo.Transactions", "WashingCounter_Id", c => c.Int());
            CreateIndex("dbo.Transactions", "WashingCounter_Id");
            AddForeignKey("dbo.Transactions", "WashingCounter_Id", "dbo.WashingCounters", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "WashingCounter_Id", "dbo.WashingCounters");
            DropIndex("dbo.Transactions", new[] { "WashingCounter_Id" });
            AlterColumn("dbo.Transactions", "WashingCounter_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Transactions", name: "WashingCounter_Id", newName: "WashingCounterId");
            CreateIndex("dbo.Transactions", "WashingCounterId");
            AddForeignKey("dbo.Transactions", "WashingCounterId", "dbo.WashingCounters", "Id", cascadeDelete: true);
        }
    }
}
