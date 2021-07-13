namespace LolaApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Branch", "PhoneNumber", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Branch", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
