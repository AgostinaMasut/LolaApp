using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class MeasurementsBodyTypeRepository : RepositoryBase<MeasurementsBodyType>, IMeasurementsBodyTypeRepository
    {
        public MeasurementsBodyTypeRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
