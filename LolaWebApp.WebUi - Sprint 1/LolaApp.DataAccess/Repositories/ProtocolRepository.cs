using LolaApp.Entities;
using System.Data.Entity;
using LolaApp.DataAccess.Concrete;

namespace LolaApp.DataAccess.Repositories
{
    public class ProtocolRepository : RepositoryBase<Protocol>, IProtocolRepository
    {
        public ProtocolRepository(DbContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
