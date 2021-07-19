using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class AssistanceRepository
    {
        public partial class QueryTypeRepository : RepositoryBase<QueryType>, IQueryTypeRepository
        {
            public QueryTypeRepository(DbContext repositoryContext) : base(repositoryContext)
            {
            }
        }
    }
}
