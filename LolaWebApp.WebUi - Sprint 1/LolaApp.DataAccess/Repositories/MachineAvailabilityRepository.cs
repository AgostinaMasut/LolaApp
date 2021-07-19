﻿using LolaApp.DataAccess.Concrete;
using LolaApp.Entities;
using System.Data.Entity;

namespace LolaApp.DataAccess.Repositories
{
    public partial class MachineAvailabilityRepository : RepositoryBase<MachineAvailability>, IMachineAvailabilityRepository
    {
        public MachineAvailabilityRepository(DbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
