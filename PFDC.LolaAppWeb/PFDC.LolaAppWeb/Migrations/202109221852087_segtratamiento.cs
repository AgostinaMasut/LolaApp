namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class segtratamiento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FollowupTreatments", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FollowupTreatments", "Date");
        }
    }
}
