namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newInit5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parcels", "Barcode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parcels", "Barcode");
        }
    }
}
