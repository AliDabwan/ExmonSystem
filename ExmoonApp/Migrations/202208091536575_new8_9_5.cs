namespace ExmonSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new8_9_5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ItemGovers", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ItemGovers", "Name", c => c.String(nullable: false));
        }
    }
}
