namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actalizaciónuser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Mobile", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Mobile", c => c.Int(nullable: false));
        }
    }
}
