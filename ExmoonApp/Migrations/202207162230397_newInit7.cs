namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newInit7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parcels", "IsFreezeStatue", c => c.Boolean(nullable: false));
            AddColumn("dbo.Parcels", "FreezeDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parcels", "FreezeDate");
            DropColumn("dbo.Parcels", "IsFreezeStatue");
        }
    }
}
