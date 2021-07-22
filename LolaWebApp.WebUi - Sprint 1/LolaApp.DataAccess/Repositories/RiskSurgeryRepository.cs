using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class RiskSurgeryRepository : RepositoryBase<RiskSurgery>, IRiskSurgeryRepository
    {
        public RiskSurgeryRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
