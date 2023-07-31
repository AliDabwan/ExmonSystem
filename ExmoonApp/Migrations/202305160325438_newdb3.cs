namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdb3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReportName = c.String(),
                        IsVisa = c.Boolean(nullable: false),
                        Sympol = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "FullName", c => c.String());
            AddColumn("dbo.Customers", "Job", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Job");
            DropColumn("dbo.Customers", "FullName");
            DropTable("dbo.Destinations");
        }
    }
}
