namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tun : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Turns", "StartTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Turns", "EndTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Turns", "Fecha");
            DropColumn("dbo.Turns", "Hora");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Turns", "Hora", c => c.DateTime(nullable: false));
            AddColumn("dbo.Turns", "Fecha", c => c.DateTime(nullable: false));
            DropColumn("dbo.Turns", "EndTime");
            DropColumn("dbo.Turns", "StartTime");
        }
    }
}
