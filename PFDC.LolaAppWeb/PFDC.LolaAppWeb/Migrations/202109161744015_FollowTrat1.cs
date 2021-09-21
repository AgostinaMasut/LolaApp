namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FollowTrat1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Treatments", "Habilitado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Treatments", "Habilitado");
        }
    }
}
