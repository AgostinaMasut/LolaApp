using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolaApp.DataAccess.Repositories
{
    public class SexRepository : RepositoryBase<Sex>, ISexRepository
    {
        public SexRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
