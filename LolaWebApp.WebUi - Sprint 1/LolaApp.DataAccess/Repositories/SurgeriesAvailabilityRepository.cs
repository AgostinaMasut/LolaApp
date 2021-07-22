using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class SurgeriesAvailabilityRepository : RepositoryBase<SurgeriesAvailability>, ISurgeriesAvailabilityRepository
    {
        public SurgeriesAvailabilityRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
