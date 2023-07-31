namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTasleemStatueToGroup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParcelGroups", "IsPaidTasleemStatue", c => c.Boolean(nullable: false));
            AddColumn("dbo.ParcelGroups", "IsPaidTasleemStatueDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ParcelGroups", "IsPaidTasleemStatueDate");
            DropColumn("dbo.ParcelGroups", "IsPaidTasleemStatue");
        }
    }
}
