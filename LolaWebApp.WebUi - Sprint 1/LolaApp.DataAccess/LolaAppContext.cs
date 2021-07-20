using LolaApp.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LolaApp.DataAccess
{
    public class LolaAppContext : DbContext
    {
        public LolaAppContext() : base("CS")
        {

        }
        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            dbModelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<AestheticPathologies> AestheticPathologies { get; set; }
        public DbSet<Assistance> Assistance { get; set; }
        public DbSet<AssistanceType> AssistanceType { get; set; }
        public DbSet<AvailabilityHistory> AvailabilityHistory { get; set; }
        public DbSet<BackgroundType> BackgroundType { get; set; }
        public DbSet<BodyArea> BodyArea { get; set; }
        public DbSet<BodyMeasurements> BodyMeasurements { get; set; }
        public DbSet<BodyMeasurementsHistory> BodyMeasurementsHistory { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<CommentCrm> CommentCrm { get; set; }
        public DbSet<Consent> Consent { get; set; }
        public DbSet<ConsultantType> ConsultantType { get; set; }
        public DbSet<Crm> Crm { get; set; }
        public DbSet<Example> Example { get; set; }
        public DbSet<Frequency> Frequency { get; set; }
        public DbSet<Machine> Machine { get; set; }
        public DbSet<MachineAvailability> MachineAvailability { get; set; }
        public DbSet<MachineType> MachineType { get; set; }
        public DbSet<MeasurementsBodyType> MeasurementsBodyType { get; set; }
        public DbSet<MediaType> MediaType { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<PreviousAntecedents> PreviousAntecedents { get; set; }
        public DbSet<PriceList> PriceList { get; set; }
        public DbSet<ProfessionalTimeline> ProfessionalTimeline { get; set; }
        public DbSet<Protocol> Protocol { get; set; }
        public DbSet<QueryType> QueryType { get; set; }
        public DbSet<Risks> Risks { get; set; }
        public DbSet<Sex> Sex { get; set; }
        public DbSet<Stretcher> Stretcher { get; set; }
        public DbSet<StretcherAvailability> StretcherAvailability { get; set; }
        public DbSet<SurgeriesType> SurgeriesType { get; set; }
        public DbSet<SurgeryProtocol> SurgeryProtocol { get; set; }
        public DbSet<Treatment> Treatment { get; set; }
        public DbSet<Turn> Turn { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserType> UserType { get; set; }
        
        


    }
}
