namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editcomm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountsTransactionSubs", "Details", c => c.String());
            AddColumn("dbo.Parcels", "TawseelSenderAmmount", c => c.Double(nullable: false));
            AddColumn("dbo.Parcels", "TotalNetAfterTawseelSenderAmmount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parcels", "TotalNetAfterTawseelSenderAmmount");
            DropColumn("dbo.Parcels", "TawseelSenderAmmount");
            DropColumn("dbo.AccountsTransactionSubs", "Details");
        }
    }
}
