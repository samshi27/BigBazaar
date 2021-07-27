using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using BigBazaar.Entities;

namespace BigBazaar.Database
{
    public class BBContext : DbContext 
    {
        public BBContext(): base("BigBazaarConnection")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
