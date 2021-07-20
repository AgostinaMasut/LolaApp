using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public class TurnRepository : RepositoryBase<Turn>, ITurnRepository
    {
        public TurnRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
