using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class StretcherRepository : RepositoryBase<Stretcher>, IStretcherRepository
    {
        public StretcherRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}


