namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new8_9_4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParcelGroups", "CreatedUserId", c => c.Int(nullable: false));
            AddColumn("dbo.ParcelGroups", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ParcelGroups", "LastUpdateDate", c => c.DateTime());
            AddColumn("dbo.ParcelGroups", "LastUpdateUserId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ParcelGroups", "LastUpdateUserId");
            DropColumn("dbo.ParcelGroups", "LastUpdateDate");
            DropColumn("dbo.ParcelGroups", "CreatedDate");
            DropColumn("dbo.ParcelGroups", "CreatedUserId");
        }
    }
}
