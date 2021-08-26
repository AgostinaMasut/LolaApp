namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorporalHistory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Turns", "UserId", "dbo.Users");
            DropIndex("dbo.Turns", new[] { "UserId" });
            AddColumn("dbo.Turns", "ProfessionalTimelineId", c => c.Int(nullable: false));
            AlterColumn("dbo.Patients", "DNI", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.ProfessionalTimelines", "Input", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProfessionalTimelines", "Output", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Turns", "ProfessionalTimelineId");
            AddForeignKey("dbo.Turns", "ProfessionalTimelineId", "dbo.ProfessionalTimelines", "Id", cascadeDelete: true);
            DropColumn("dbo.Turns", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Turns", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Turns", "ProfessionalTimelineId", "dbo.ProfessionalTimelines");
            DropIndex("dbo.Turns", new[] { "ProfessionalTimelineId" });
            AlterColumn("dbo.ProfessionalTimelines", "Output", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.ProfessionalTimelines", "Input", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Patients", "DNI", c => c.String(maxLength: 8));
            DropColumn("dbo.Turns", "ProfessionalTimelineId");
            CreateIndex("dbo.Turns", "UserId");
            AddForeignKey("dbo.Turns", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
