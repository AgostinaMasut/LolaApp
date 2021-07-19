using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class BodyMeasurementsHistoryRepository : RepositoryBase<BodyMeasurementsHistory>, IBodyMeasurementsHistoryRepository
    {
        public BodyMeasurementsHistoryRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
