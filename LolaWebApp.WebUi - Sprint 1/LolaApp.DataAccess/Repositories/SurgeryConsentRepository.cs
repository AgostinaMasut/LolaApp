using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class SurgeryConsentRepository : RepositoryBase<SurgeryConsent>, ISurgeryConsentRepository
    {
        public SurgeryConsentRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
