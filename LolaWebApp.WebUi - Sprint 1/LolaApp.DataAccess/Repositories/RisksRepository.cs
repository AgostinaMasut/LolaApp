using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class RisksRepository : RepositoryBase<Risks>, IRisksRepository
    {
        public RisksRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
