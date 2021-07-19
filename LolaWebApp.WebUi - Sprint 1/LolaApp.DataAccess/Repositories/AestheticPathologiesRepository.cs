using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class AestheticPathologiesRepository : RepositoryBase<AestheticPathologies>, IAestheticPathologiesRepository
    {
        public AestheticPathologiesRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
