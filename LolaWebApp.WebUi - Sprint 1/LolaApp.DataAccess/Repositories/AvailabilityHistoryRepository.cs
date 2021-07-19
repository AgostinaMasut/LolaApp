using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class AssistanceRepository
    {
        public class AvailabilityHistoryRepository : RepositoryBase<AvailabilityHistory>, IAvailabilityHistoryRepository
        {
            public AvailabilityHistoryRepository(DbContext repositoryContext) : base(repositoryContext)
            {
            }
        }
}
