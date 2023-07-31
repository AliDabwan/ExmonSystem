namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newInit6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parcels", "IsReturnToStoreStatue", c => c.Boolean(nullable: false));
            AddColumn("dbo.Parcels", "ReturnToStoreDate", c => c.DateTime());
            AddColumn("dbo.Parcels", "IsGoToEndStatue", c => c.Boolean(nullable: false));
            AddColumn("dbo.Parcels", "GoToEndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parcels", "GoToEndDate");
            DropColumn("dbo.Parcels", "IsGoToEndStatue");
            DropColumn("dbo.Parcels", "ReturnToStoreDate");
            DropColumn("dbo.Parcels", "IsReturnToStoreStatue");
        }
    }
}
