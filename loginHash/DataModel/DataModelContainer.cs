using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginHash.DataModel
{
    public  class DataModelContainer : DbContext
    {
        public DataModelContainer():base("name=DefaultConnection")
        {

        }
        public DbSet<User> ApplicationUsers { get; set; }
        public DbSet<SystemUser> SystemUser { get; set; }
    }
}
