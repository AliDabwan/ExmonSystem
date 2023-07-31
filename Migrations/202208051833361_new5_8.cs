namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new5_8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parcels", "SenderName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parcels", "SenderName");
        }
    }
}
