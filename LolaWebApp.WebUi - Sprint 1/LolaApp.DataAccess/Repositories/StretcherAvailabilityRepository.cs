using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public class StretcherAvailabilityRepository : RepositoryBase<StretcherAvailability>, IStretcherAvailabilityRepository
    {
        public StretcherAvailabilityRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }


}
