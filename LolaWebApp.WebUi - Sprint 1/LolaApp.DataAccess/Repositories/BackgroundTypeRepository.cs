using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class BackgroundTypeRepository : RepositoryBase<BackgroundType>, IBackgroundTypeRepository
    {
        public BackgroundTypeRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
