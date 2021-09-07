using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PFDC.LolaAppWeb.Data
{
    public class PFDCLolaAppWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PFDCLolaAppWebContext() : base("name=DBconection")
        {
        }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.AssistanceType> AssistanceType{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.BackgroundType> BackgroundType{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.BodyMeasurementsHistory> BodyMeasurementsHistory{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.Branch> Branch { get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.ClinicHistory> ClinicHistory{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.CommentCrm> CommentCrm{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.ConsultantType> ConsultantType{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.Crm> Crm{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.FollowupTreatment> FollowupTreatments { get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.Frequency> Frequency{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.Machine> Machine{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.MeasurementsBodyType> MeasurementsBodyType{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.MediaType> MediaType{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.Patient> Patient{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.PreviousAntecedents> PreviousAntecedent{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.PriceList> PriceList{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.ProfessionalTimeline> ProfessionalTimeline { get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.QueryType> QueryType{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.Sex> Sex { get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.Stretcher> Stretcher{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.SurgeryProtocol> SurgeryProtocol{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.Treatment> Treatment{ get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.Turn> Turn { get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.TurnoPrueba> TurnoPrueba { get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.User> Users { get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.UserType> UserTypes { get; set; }
    }
}
