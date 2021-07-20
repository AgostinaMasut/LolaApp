using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class MachineRepository : RepositoryBase<Machine>, IMachineRepository
    {
        public MachineRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
