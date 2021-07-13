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

        public DbSet<Example> Example { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<ProfessionalTimeline> ProfessionalTimeline { get; set; }
        public DbSet<Sex> Sex { get; set; }
        public DbSet<UserType> UserType { get; set; }
        public DbSet<Protocol> Protocol { get; set; }

    }
}
