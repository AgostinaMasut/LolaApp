using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class SurgeriesTypeRepository : RepositoryBase<SurgeriesType>, ISurgeriesTypeRepository
    {
        public SurgeriesTypeRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }


}


