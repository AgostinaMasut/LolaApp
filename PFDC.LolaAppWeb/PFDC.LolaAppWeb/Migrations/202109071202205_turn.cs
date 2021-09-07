namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class turn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turns", "Commentary", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Turns", "Commentary");
        }
    }
}
