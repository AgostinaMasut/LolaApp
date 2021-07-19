using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class AssistanceTypeRepository : RepositoryBase<AssistanceType>, IAssistanceTypeRepository
    {
        public AssistanceTypeRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
