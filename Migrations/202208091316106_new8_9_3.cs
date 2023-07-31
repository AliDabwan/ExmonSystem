namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new8_9_3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParcelGroups", "GroupStatue", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ParcelGroups", "GroupStatue");
        }
    }
}
