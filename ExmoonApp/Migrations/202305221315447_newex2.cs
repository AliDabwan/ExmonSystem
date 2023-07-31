namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newex2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subscribers", "Desc", c => c.String());
            AddColumn("dbo.Subscribers", "IsPassport", c => c.Boolean(nullable: false));
            AddColumn("dbo.Subscribers", "IsTicket", c => c.Boolean(nullable: false));
            AddColumn("dbo.Subscribers", "IsVisa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Subscribers", "IsExcell", c => c.Boolean(nullable: false));
            AddColumn("dbo.Subscribers", "IsVoucher", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subscribers", "IsVoucher");
            DropColumn("dbo.Subscribers", "IsExcell");
            DropColumn("dbo.Subscribers", "IsVisa");
            DropColumn("dbo.Subscribers", "IsTicket");
            DropColumn("dbo.Subscribers", "IsPassport");
            DropColumn("dbo.Subscribers", "Desc");
        }
    }
}
