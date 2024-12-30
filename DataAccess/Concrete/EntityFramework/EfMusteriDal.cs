using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMusteriDal : EfEntityRepositoryBase<Musteri, CargoTrackingDatabaseContext>, IMusteriDal
    {

        public void Delete(string tc)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                context.Database.ExecuteSqlRaw($"CALL musterisil('{tc}')");
                context.SaveChanges();
            }
        }


        public Musteri Get(string tc)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                var result = context.musteriler.FromSqlRaw($"SELECT * FROM musterioku('{tc}')").ToList()[0];
                return result;
            }

        }
    }
}
