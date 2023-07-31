namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.Orders", "IsPrinted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "PaidStatue", c => c.String());
            AddColumn("dbo.Orders", "PaidDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "PaidDate");
            DropColumn("dbo.Orders", "PaidStatue");
            DropColumn("dbo.Orders", "IsPrinted");
            DropColumn("dbo.Orders", "Price");
        }
    }
}
