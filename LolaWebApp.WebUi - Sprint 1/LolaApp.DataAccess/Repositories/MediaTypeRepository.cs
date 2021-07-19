using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class MediaTypeRepository : RepositoryBase<MediaType>, IMediaTypeRepository
    {
        public MediaTypeRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }


}


