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
    public class UserTypeRepository : RepositoryBase<UserType>, IUserTypeRepository
    {
        public UserTypeRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
