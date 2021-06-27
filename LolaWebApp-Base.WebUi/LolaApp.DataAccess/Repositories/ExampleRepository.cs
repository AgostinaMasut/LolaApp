using LolaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LolaApp.DataAccess.Concrete;
using System.Linq.Expressions;

namespace LolaApp.DataAccess.Repositories
{
    public class ExampleRepository : RepositoryBase<Example>, IExampleRepository 
    {
        public ExampleRepository(DbContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
