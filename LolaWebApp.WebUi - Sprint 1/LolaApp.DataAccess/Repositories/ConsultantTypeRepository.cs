using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class ConsultantTypeRepository : RepositoryBase<ConsultantType>, IConsultantTypeRepository
    {
        public ConsultantTypeRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }

}


