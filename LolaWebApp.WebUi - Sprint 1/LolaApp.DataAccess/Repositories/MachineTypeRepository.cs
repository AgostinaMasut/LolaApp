using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class MachineTypeRepository : RepositoryBase<MachineType>, IMachineTypeRepository
    {
        public MachineTypeRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
