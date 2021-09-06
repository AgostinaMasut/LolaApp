namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class error1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FollowupTreatments", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.FollowupTreatments", "TreatmentId", "dbo.Treatments");
            DropForeignKey("dbo.FollowupTreatments", "UserId", "dbo.Users");
            DropIndex("dbo.FollowupTreatments", new[] { "PatientId" });
            DropIndex("dbo.FollowupTreatments", new[] { "UserId" });
            DropIndex("dbo.FollowupTreatments", new[] { "TreatmentId" });
            DropColumn("dbo.FollowupTreatments", "PatientId");
            DropColumn("dbo.FollowupTreatments", "UserId");
            DropColumn("dbo.FollowupTreatments", "TreatmentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FollowupTreatments", "TreatmentId", c => c.Int(nullable: false));
            AddColumn("dbo.FollowupTreatments", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.FollowupTreatments", "PatientId", c => c.Int());
            CreateIndex("dbo.FollowupTreatments", "TreatmentId");
            CreateIndex("dbo.FollowupTreatments", "UserId");
            CreateIndex("dbo.FollowupTreatments", "PatientId");
            AddForeignKey("dbo.FollowupTreatments", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FollowupTreatments", "TreatmentId", "dbo.Treatments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FollowupTreatments", "PatientId", "dbo.Patients", "Id");
        }
    }
}
