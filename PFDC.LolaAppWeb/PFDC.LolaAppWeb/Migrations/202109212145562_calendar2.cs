namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class calendar2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FollowupTreatments", "TrackingNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FollowupTreatments", "TrackingNumber");
        }
    }
}
