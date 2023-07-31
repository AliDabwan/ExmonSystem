namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editcomm3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parcels", "IsPaidTasleemStatue", c => c.Boolean(nullable: false));
            AddColumn("dbo.Parcels", "IsPaidTasleemStatueDate", c => c.DateTime());
            AddColumn("dbo.Parcels", "IsPaidTawseelStatue", c => c.Boolean(nullable: false));
            AddColumn("dbo.Parcels", "IsPaidTawseelStatueDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parcels", "IsPaidTawseelStatueDate");
            DropColumn("dbo.Parcels", "IsPaidTawseelStatue");
            DropColumn("dbo.Parcels", "IsPaidTasleemStatueDate");
            DropColumn("dbo.Parcels", "IsPaidTasleemStatue");
        }
    }
}
