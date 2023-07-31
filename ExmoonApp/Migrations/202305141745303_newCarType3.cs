namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newCarType3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "WashingCounter_Id", "dbo.WashingCounters");
            DropIndex("dbo.Transactions", new[] { "WashingCounter_Id" });
            DropColumn("dbo.Transactions", "WashingCounter_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "WashingCounter_Id", c => c.Int());
            CreateIndex("dbo.Transactions", "WashingCounter_Id");
            AddForeignKey("dbo.Transactions", "WashingCounter_Id", "dbo.WashingCounters", "Id");
        }
    }
}
