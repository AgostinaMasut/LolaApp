using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class FollowupTreatmentRepository : RepositoryBase<FollowupTreatment>, IFollowupTreatmentRepository
    {
        public FollowupTreatmentRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
