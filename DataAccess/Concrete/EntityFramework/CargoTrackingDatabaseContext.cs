using Microsoft.EntityFrameworkCore;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CargoTrackingDatabaseContext : DbContext
    {
        public CargoTrackingDatabaseContext(DbContextOptions<CargoTrackingDatabaseContext> options)
            : base(options)
        {

        }
        public DbSet<Kargo> kargolar { get; set; }
    }
}
