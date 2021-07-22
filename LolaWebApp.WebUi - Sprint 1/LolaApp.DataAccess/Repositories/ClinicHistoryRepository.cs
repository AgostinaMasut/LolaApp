using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class ClinicHistoryRepository : RepositoryBase<ClinicHistory>, IClinicHistoryRepository
    {
        public ClinicHistoryRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
