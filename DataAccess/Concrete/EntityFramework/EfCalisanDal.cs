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
    public class EfCalisanDal : ICalisanDal
    {
        public void Add(Calisan calisan)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                string query = $"CALL calisanekle('{calisan.ad}','{calisan.soyad}'"
                    + $",{calisan.sube_id},'{calisan.tc_no}');";
                context.Database.ExecuteSqlRaw(query);
                context.SaveChanges();
            }
        }

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


        public List<Calisan> GetAll(Expression<Func<Calisan, bool>> filter = null)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                var result = context.calisanlar.FromSqlRaw("SELECT * FROM calisanlar").ToList();
                return result;
            }
        }

        public void Update(Calisan calisan)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                string query = $"CALL calisanguncelle('{calisan.tc_no}','{calisan.ad}','{calisan.soyad}',{calisan.sube_id});";
                context.Database.ExecuteSqlRaw(query);
                context.SaveChanges();
            }
        }
    }
}
