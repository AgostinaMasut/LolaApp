namespace LolaApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Enable", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Enable", c => c.Byte(nullable: false));
        }
    }
}
