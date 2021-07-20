using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class BodyAreaRepository : RepositoryBase<BodyArea>, IBodyAreaRepository
    {
        public BodyAreaRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
