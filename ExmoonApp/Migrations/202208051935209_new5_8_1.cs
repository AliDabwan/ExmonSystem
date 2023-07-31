namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new5_8_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parcels", "IsPaidStatue", c => c.Boolean(nullable: false));
            AddColumn("dbo.Parcels", "PaidStatueDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parcels", "PaidStatueDate");
            DropColumn("dbo.Parcels", "IsPaidStatue");
        }
    }
}
