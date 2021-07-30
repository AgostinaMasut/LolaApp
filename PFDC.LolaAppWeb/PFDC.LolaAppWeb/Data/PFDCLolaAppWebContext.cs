using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PFDC.LolaAppWeb.Data
{
    public class PFDCLolaAppWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PFDCLolaAppWebContext() : base("name=DBconection")
        {
        }

        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.User> Users { get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.UserType> UserTypes { get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.Sex> Sex { get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.ProfessionalTimeline> ProfessionalTimeline { get; set; }
        public System.Data.Entity.DbSet<PFDC.LolaAppWeb.Models.Branch> Branch { get; set; }
        

    }
}
