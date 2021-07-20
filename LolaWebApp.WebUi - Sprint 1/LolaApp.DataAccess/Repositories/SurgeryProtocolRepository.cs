using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class SurgeryProtocolRepository : RepositoryBase<SurgeryProtocol>, ISurgeryProtocolRepository
    {
        public SurgeryProtocolRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }

}


