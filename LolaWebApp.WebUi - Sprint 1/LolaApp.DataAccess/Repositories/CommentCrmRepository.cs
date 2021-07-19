using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class CommentCrmRepository : RepositoryBase<CommentCrm>, ICommentCrmRepository
    {
        public CommentCrmRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }

}


