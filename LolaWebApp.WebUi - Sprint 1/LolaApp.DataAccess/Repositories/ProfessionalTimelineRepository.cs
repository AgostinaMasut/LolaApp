using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;
using LolaApp.DataAccess.Repositories;

namespace LolaApp.DataAccess.Replositories
{
    public class ProfessionalTimelineRepository : RepositoryBase<ProfessionalTimeline>, IProfessionalTimelineRepository
    {
        public ProfessionalTimelineRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
