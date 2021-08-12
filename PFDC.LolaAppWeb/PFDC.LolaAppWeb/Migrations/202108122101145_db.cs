namespace PFDC.LolaAppWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssistanceTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackgroundTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BodyMeasurementsHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MeasurementDate = c.DateTime(nullable: false),
                        PatientId = c.Int(nullable: false),
                        MeasurementsBodyTypeId = c.Int(nullable: false),
                        CmGr = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MeasurementsBodyTypes", t => t.MeasurementsBodyTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.MeasurementsBodyTypeId);
            
            CreateTable(
                "dbo.MeasurementsBodyTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DNI = c.String(nullable: false, maxLength: 8),
                        SexId = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Street = c.String(nullable: false),
                        StreetNumber = c.Int(nullable: false),
                        Neighbourhood = c.String(),
                        ZipCode = c.Int(nullable: false),
                        City = c.String(nullable: false),
                        Mobile = c.String(),
                        Email = c.String(nullable: false),
                        Sex_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sexes", t => t.Sex_Id)
                .Index(t => t.Sex_Id);
            
            CreateTable(
                "dbo.ClinicHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        Commentary = c.String(),
                        Surgery = c.Byte(nullable: false),
                        Photo = c.Byte(nullable: false),
                        Video = c.Byte(nullable: false),
                        FollowupTreatmentId = c.Int(nullable: false),
                        SurgeryProtocolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FollowupTreatments", t => t.FollowupTreatmentId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .ForeignKey("dbo.SurgeryProtocols", t => t.SurgeryProtocolId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.FollowupTreatmentId)
                .Index(t => t.SurgeryProtocolId);
            
            CreateTable(
                "dbo.FollowupTreatments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SessionNumber = c.Int(nullable: false),
                        PatientId = c.Int(),
                        UserId = c.Int(nullable: false),
                        Commentary = c.String(),
                        TreatmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientId)
                .ForeignKey("dbo.Treatments", t => t.TreatmentId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.UserId)
                .Index(t => t.TreatmentId);
            
            CreateTable(
                "dbo.Treatments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        AmountSession = c.Int(nullable: false),
                        DurationSession = c.Int(nullable: false),
                        FrequencyId = c.Int(nullable: false),
                        MachineId = c.Int(nullable: false),
                        StretcherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Frequencies", t => t.FrequencyId, cascadeDelete: true)
                .ForeignKey("dbo.Machines", t => t.MachineId, cascadeDelete: true)
                .ForeignKey("dbo.Stretchers", t => t.StretcherId, cascadeDelete: true)
                .Index(t => t.FrequencyId)
                .Index(t => t.MachineId)
                .Index(t => t.StretcherId);
            
            CreateTable(
                "dbo.Frequencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BodyArea = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Machines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stretchers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descrption = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SurgeryProtocols",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StepNumber = c.Int(nullable: false),
                        Commentary = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CommentCrms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CrmId = c.Int(nullable: false),
                        ContactDate = c.String(),
                        AnswerDate = c.String(),
                        Commentary = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Crms", t => t.CrmId, cascadeDelete: true)
                .Index(t => t.CrmId);
            
            CreateTable(
                "dbo.Crms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConsultantTypeId = c.Int(nullable: false),
                        MediaTypeId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        TreatmentId = c.Int(nullable: false),
                        SurgeryProtocolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ConsultantTypes", t => t.ConsultantTypeId, cascadeDelete: true)
                .ForeignKey("dbo.MediaTypes", t => t.MediaTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .ForeignKey("dbo.SurgeryProtocols", t => t.SurgeryProtocolId, cascadeDelete: true)
                .ForeignKey("dbo.Treatments", t => t.TreatmentId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ConsultantTypeId)
                .Index(t => t.MediaTypeId)
                .Index(t => t.PatientId)
                .Index(t => t.UserId)
                .Index(t => t.TreatmentId)
                .Index(t => t.SurgeryProtocolId);
            
            CreateTable(
                "dbo.ConsultantTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MediaTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PreviousAntecedents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        BackgroundTypeId = c.Int(nullable: false),
                        Commentary = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BackgroundTypes", t => t.BackgroundTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.BackgroundTypeId);
            
            CreateTable(
                "dbo.PriceLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TreatmentId = c.Int(nullable: false),
                        Cost = c.Int(nullable: false),
                        SalePrice = c.Int(nullable: false),
                        ProfessionalPorcent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Treatments", t => t.TreatmentId, cascadeDelete: true)
                .Index(t => t.TreatmentId);
            
            CreateTable(
                "dbo.QueryTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Turns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.DateTime(nullable: false),
                        TreatmentId = c.Int(nullable: false),
                        ProfessionalTimelineId = c.Int(nullable: false),
                        QueryTypeId = c.Int(nullable: false),
                        AssistanceTypeId = c.Int(nullable: false),
                        PatientId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssistanceTypes", t => t.AssistanceTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId)
                .ForeignKey("dbo.ProfessionalTimelines", t => t.ProfessionalTimelineId, cascadeDelete: true)
                .ForeignKey("dbo.QueryTypes", t => t.QueryTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Treatments", t => t.TreatmentId, cascadeDelete: true)
                .Index(t => t.TreatmentId)
                .Index(t => t.ProfessionalTimelineId)
                .Index(t => t.QueryTypeId)
                .Index(t => t.AssistanceTypeId)
                .Index(t => t.PatientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turns", "TreatmentId", "dbo.Treatments");
            DropForeignKey("dbo.Turns", "QueryTypeId", "dbo.QueryTypes");
            DropForeignKey("dbo.Turns", "ProfessionalTimelineId", "dbo.ProfessionalTimelines");
            DropForeignKey("dbo.Turns", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Turns", "AssistanceTypeId", "dbo.AssistanceTypes");
            DropForeignKey("dbo.PriceLists", "TreatmentId", "dbo.Treatments");
            DropForeignKey("dbo.PreviousAntecedents", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.PreviousAntecedents", "BackgroundTypeId", "dbo.BackgroundTypes");
            DropForeignKey("dbo.CommentCrms", "CrmId", "dbo.Crms");
            DropForeignKey("dbo.Crms", "UserId", "dbo.Users");
            DropForeignKey("dbo.Crms", "TreatmentId", "dbo.Treatments");
            DropForeignKey("dbo.Crms", "SurgeryProtocolId", "dbo.SurgeryProtocols");
            DropForeignKey("dbo.Crms", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Crms", "MediaTypeId", "dbo.MediaTypes");
            DropForeignKey("dbo.Crms", "ConsultantTypeId", "dbo.ConsultantTypes");
            DropForeignKey("dbo.ClinicHistories", "SurgeryProtocolId", "dbo.SurgeryProtocols");
            DropForeignKey("dbo.ClinicHistories", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.ClinicHistories", "FollowupTreatmentId", "dbo.FollowupTreatments");
            DropForeignKey("dbo.FollowupTreatments", "UserId", "dbo.Users");
            DropForeignKey("dbo.FollowupTreatments", "TreatmentId", "dbo.Treatments");
            DropForeignKey("dbo.Treatments", "StretcherId", "dbo.Stretchers");
            DropForeignKey("dbo.Treatments", "MachineId", "dbo.Machines");
            DropForeignKey("dbo.Treatments", "FrequencyId", "dbo.Frequencies");
            DropForeignKey("dbo.FollowupTreatments", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.BodyMeasurementsHistories", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Patients", "Sex_Id", "dbo.Sexes");
            DropForeignKey("dbo.BodyMeasurementsHistories", "MeasurementsBodyTypeId", "dbo.MeasurementsBodyTypes");
            DropIndex("dbo.Turns", new[] { "PatientId" });
            DropIndex("dbo.Turns", new[] { "AssistanceTypeId" });
            DropIndex("dbo.Turns", new[] { "QueryTypeId" });
            DropIndex("dbo.Turns", new[] { "ProfessionalTimelineId" });
            DropIndex("dbo.Turns", new[] { "TreatmentId" });
            DropIndex("dbo.PriceLists", new[] { "TreatmentId" });
            DropIndex("dbo.PreviousAntecedents", new[] { "BackgroundTypeId" });
            DropIndex("dbo.PreviousAntecedents", new[] { "PatientId" });
            DropIndex("dbo.Crms", new[] { "SurgeryProtocolId" });
            DropIndex("dbo.Crms", new[] { "TreatmentId" });
            DropIndex("dbo.Crms", new[] { "UserId" });
            DropIndex("dbo.Crms", new[] { "PatientId" });
            DropIndex("dbo.Crms", new[] { "MediaTypeId" });
            DropIndex("dbo.Crms", new[] { "ConsultantTypeId" });
            DropIndex("dbo.CommentCrms", new[] { "CrmId" });
            DropIndex("dbo.Treatments", new[] { "StretcherId" });
            DropIndex("dbo.Treatments", new[] { "MachineId" });
            DropIndex("dbo.Treatments", new[] { "FrequencyId" });
            DropIndex("dbo.FollowupTreatments", new[] { "TreatmentId" });
            DropIndex("dbo.FollowupTreatments", new[] { "UserId" });
            DropIndex("dbo.FollowupTreatments", new[] { "PatientId" });
            DropIndex("dbo.ClinicHistories", new[] { "SurgeryProtocolId" });
            DropIndex("dbo.ClinicHistories", new[] { "FollowupTreatmentId" });
            DropIndex("dbo.ClinicHistories", new[] { "PatientId" });
            DropIndex("dbo.Patients", new[] { "Sex_Id" });
            DropIndex("dbo.BodyMeasurementsHistories", new[] { "MeasurementsBodyTypeId" });
            DropIndex("dbo.BodyMeasurementsHistories", new[] { "PatientId" });
            DropTable("dbo.Turns");
            DropTable("dbo.QueryTypes");
            DropTable("dbo.PriceLists");
            DropTable("dbo.PreviousAntecedents");
            DropTable("dbo.MediaTypes");
            DropTable("dbo.ConsultantTypes");
            DropTable("dbo.Crms");
            DropTable("dbo.CommentCrms");
            DropTable("dbo.SurgeryProtocols");
            DropTable("dbo.Stretchers");
            DropTable("dbo.Machines");
            DropTable("dbo.Frequencies");
            DropTable("dbo.Treatments");
            DropTable("dbo.FollowupTreatments");
            DropTable("dbo.ClinicHistories");
            DropTable("dbo.Patients");
            DropTable("dbo.MeasurementsBodyTypes");
            DropTable("dbo.BodyMeasurementsHistories");
            DropTable("dbo.BackgroundTypes");
            DropTable("dbo.AssistanceTypes");
        }
    }
}
