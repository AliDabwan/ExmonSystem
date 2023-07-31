namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newex3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExCompanies", "Statu", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExCompanies", "Statu");
        }
    }
}
