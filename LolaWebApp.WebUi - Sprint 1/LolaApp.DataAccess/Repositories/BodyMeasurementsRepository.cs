using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class BodyMeasurementsRepository : RepositoryBase<BodyMeasurements>, IBodyMeasurementsRepository
    {
        public BodyMeasurementsRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
