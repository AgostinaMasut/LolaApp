using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class CrmRepository : RepositoryBase<Crm>, ICrmRepository
    {
        public CrmRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }

}


