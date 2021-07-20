using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
        public PatientRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }


}


