namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tratfol : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClinicHistories", "FollowupTreatmentId", "dbo.FollowupTreatments");
            DropForeignKey("dbo.ClinicHistories", "SurgeryProtocolId", "dbo.SurgeryProtocols");
            DropIndex("dbo.ClinicHistories", new[] { "FollowupTreatmentId" });
            DropIndex("dbo.ClinicHistories", new[] { "SurgeryProtocolId" });
            AddColumn("dbo.FollowupTreatments", "TreatmentId", c => c.Int(nullable: false));
            AddColumn("dbo.FollowupTreatments", "PatientId", c => c.Int(nullable: false));
            AddColumn("dbo.FollowupTreatments", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.ClinicHistories", "SurgeryProtocolId", c => c.Int());
            CreateIndex("dbo.ClinicHistories", "SurgeryProtocolId");
            CreateIndex("dbo.FollowupTreatments", "TreatmentId");
            CreateIndex("dbo.FollowupTreatments", "PatientId");
            CreateIndex("dbo.FollowupTreatments", "UserId");
            AddForeignKey("dbo.FollowupTreatments", "PatientId", "dbo.Patients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FollowupTreatments", "TreatmentId", "dbo.Treatments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FollowupTreatments", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ClinicHistories", "SurgeryProtocolId", "dbo.SurgeryProtocols", "Id");
            DropColumn("dbo.ClinicHistories", "FollowupTreatmentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClinicHistories", "FollowupTreatmentId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ClinicHistories", "SurgeryProtocolId", "dbo.SurgeryProtocols");
            DropForeignKey("dbo.FollowupTreatments", "UserId", "dbo.Users");
            DropForeignKey("dbo.FollowupTreatments", "TreatmentId", "dbo.Treatments");
            DropForeignKey("dbo.FollowupTreatments", "PatientId", "dbo.Patients");
            DropIndex("dbo.FollowupTreatments", new[] { "UserId" });
            DropIndex("dbo.FollowupTreatments", new[] { "PatientId" });
            DropIndex("dbo.FollowupTreatments", new[] { "TreatmentId" });
            DropIndex("dbo.ClinicHistories", new[] { "SurgeryProtocolId" });
            AlterColumn("dbo.ClinicHistories", "SurgeryProtocolId", c => c.Int(nullable: false));
            DropColumn("dbo.FollowupTreatments", "UserId");
            DropColumn("dbo.FollowupTreatments", "PatientId");
            DropColumn("dbo.FollowupTreatments", "TreatmentId");
            CreateIndex("dbo.ClinicHistories", "SurgeryProtocolId");
            CreateIndex("dbo.ClinicHistories", "FollowupTreatmentId");
            AddForeignKey("dbo.ClinicHistories", "SurgeryProtocolId", "dbo.SurgeryProtocols", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ClinicHistories", "FollowupTreatmentId", "dbo.FollowupTreatments", "Id", cascadeDelete: true);
        }
    }
}
