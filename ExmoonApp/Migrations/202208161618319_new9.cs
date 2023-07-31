namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parcels", "IsReturnToSenderStatue", c => c.Boolean(nullable: false));
            AddColumn("dbo.Parcels", "ReturnToSenderDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parcels", "ReturnToSenderDate");
            DropColumn("dbo.Parcels", "IsReturnToSenderStatue");
        }
    }
}
