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
    public class EfMusteriDal : IMusteriDal
    {
        public void Add(Musteri musteri)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                string query = $"CALL musteriekle('{musteri.tc_no}','{musteri.ad}','{musteri.soyad}'"
                    + $",'{musteri.telefon_no}');";
                context.Database.ExecuteSqlRaw(query);
                context.SaveChanges();
            }
        }

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

        public List<Musteri> GetAll(Expression<Func<Musteri, bool>> filter = null)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                var result = context.musteriler.FromSqlRaw("SELECT * FROM musteriler").ToList();
                return result;
            }
        }

        public void Update(Musteri musteri)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                string query = $"CALL musteriguncelle('{musteri.tc_no}','{musteri.ad}','{musteri.soyad}','{musteri.telefon_no}');";
                context.Database.ExecuteSqlRaw(query);
                context.SaveChanges();
            }
        }
    }
}
