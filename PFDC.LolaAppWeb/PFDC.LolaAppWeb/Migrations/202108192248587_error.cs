namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class error : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Turns", "ProfessionalTimelineId", "dbo.ProfessionalTimelines");
            DropIndex("dbo.Turns", new[] { "ProfessionalTimelineId" });
            AddColumn("dbo.Turns", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Turns", "UserId");
            AddForeignKey("dbo.Turns", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            DropColumn("dbo.Turns", "ProfessionalTimelineId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Turns", "ProfessionalTimelineId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Turns", "UserId", "dbo.Users");
            DropIndex("dbo.Turns", new[] { "UserId" });
            DropColumn("dbo.Turns", "UserId");
            CreateIndex("dbo.Turns", "ProfessionalTimelineId");
            AddForeignKey("dbo.Turns", "ProfessionalTimelineId", "dbo.ProfessionalTimelines", "Id", cascadeDelete: true);
        }
    }
}
