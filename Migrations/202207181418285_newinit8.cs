namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newinit8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parcels", "IsFreezeNote", c => c.String());
            AddColumn("dbo.Parcels", "TotalCom", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parcels", "TotalCom");
            DropColumn("dbo.Parcels", "IsFreezeNote");
        }
    }
}
