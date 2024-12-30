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
    public class EfCalisanDal : EfEntityRepositoryBase<Calisan, CargoTrackingDatabaseContext>, ICalisanDal
    {

        public void Delete(string tc_no)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                context.Database.ExecuteSqlRaw($"CALL calisansil('{tc_no}')");
                context.SaveChanges();
            }
        }


        public Calisan Get(string tc_no)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                var result = context.calisanlar.FromSqlRaw($"SELECT * FROM calisanoku('{tc_no}')").ToList()[0];
                return result;
            }
        }
    }
}
