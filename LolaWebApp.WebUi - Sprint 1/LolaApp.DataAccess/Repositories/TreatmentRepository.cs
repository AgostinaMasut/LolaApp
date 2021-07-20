using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public class TreatmentRepository : RepositoryBase<Treatment>, ITreatmentRepository
    {
        public TreatmentRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
