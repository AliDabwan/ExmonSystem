namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editcomm2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountsTransactionSubs", "GroupId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AccountsTransactionSubs", "GroupId");
        }
    }
}
