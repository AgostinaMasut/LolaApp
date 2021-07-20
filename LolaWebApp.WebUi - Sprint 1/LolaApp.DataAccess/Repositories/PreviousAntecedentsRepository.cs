using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class PreviousAntecedentsRepository : RepositoryBase<PreviousAntecedents>, IPreviousAntecedentsRepository
    {
        public PreviousAntecedentsRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
