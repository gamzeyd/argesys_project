using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using Argesys.Entities.Concrete;


namespace Argesys.DataAccess.Concrete.EntityFramework
{
    public class ArgesysContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet <Brand> Brands { get; set; }
    }
}
