using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSprocApp.Data.Models;

namespace EntityFrameworkSprocApp.Data
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base("DefaultDbConnection")
        {
            
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
