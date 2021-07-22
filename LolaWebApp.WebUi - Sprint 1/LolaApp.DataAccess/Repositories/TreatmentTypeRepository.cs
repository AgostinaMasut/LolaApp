using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class TreatmentTypeRepository : RepositoryBase<TreatmentType>, ITreatmentTypeRepository
    {
        public TreatmentTypeRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
