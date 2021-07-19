using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class ConsentRepository : RepositoryBase<Consent>, IConsentRepository
    {
        public ConsentRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
