namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newInit4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemGovers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        GoverType = c.Int(nullable: false),
                        Sympol = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Parcels", "VoucherNo", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parcels", "VoucherNo");
            DropTable("dbo.ItemGovers");
        }
    }
}
