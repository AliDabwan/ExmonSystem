namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newinit9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parcels", "TotalNetRtrn", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parcels", "TotalNetRtrn");
        }
    }
}
