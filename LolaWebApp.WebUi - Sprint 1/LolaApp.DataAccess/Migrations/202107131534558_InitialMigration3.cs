namespace LolaApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Branch", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Branch", "PhoneNumber", c => c.Double(nullable: false));
        }
    }
}
