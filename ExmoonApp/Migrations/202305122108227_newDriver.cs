namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDriver : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemCompanyTorism",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Sympol = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemDistricts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Sympol = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemDrivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Sympol = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ItemDrivers");
            DropTable("dbo.ItemDistricts");
            DropTable("dbo.ItemCompanyTorism");
        }
    }
}
