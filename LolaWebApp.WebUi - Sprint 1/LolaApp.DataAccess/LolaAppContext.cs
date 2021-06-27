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
        }

        public DbSet<Example> Example { get; set; }
    }
}
