using Core.Entities;
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
    public class EfKargoDal : IKargoDal
    {
         public List<Kargo> GetAll(Expression<Func<Kargo, bool>> filter = null)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                var result = context.kargolar.FromSqlRaw("SELECT * FROM kargolar").ToList();
                return result;
            }
        }
         public void Delete(int id)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                context.Database.ExecuteSqlRaw($"CALL kargosil({id})");
                context.SaveChanges();
            }
        }

        public Kargo Get(int id)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                var result = context.kargolar.FromSqlRaw($"SELECT * FROM kargooku({id})").ToList()[0];
                return result;
            }
        }

        public void Add(Kargo kargo)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                string query = $"CALL kargoekleveyaguncelle(NULL,{kargo.gonderici_id},{kargo.alici_id}"
                    + $",'{kargo.kabul_tarihi}',{kargo.paket_turu_id},{kargo.fiyat},{kargo.agirlik}"
                    + $",NULL,{kargo.kargo_durumu_id},'{kargo.son_islem_tarihi}',NULL"
                    + $",NULL);";
                context.Database.ExecuteSqlRaw(query);
                context.SaveChanges();
            }
        }

        public void Update(Kargo kargo)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                string query = $"CALL kargoekleveyaguncelle({kargo.id},{kargo.gonderici_id},{kargo.alici_id}"
                    + $",'{kargo.kabul_tarihi}',{kargo.paket_turu_id},{kargo.fiyat},{kargo.agirlik}"
                    + $",'{kargo.teslim_tarihi}',{kargo.kargo_durumu_id},'{kargo.son_islem_tarihi}','{kargo.teslim_alan_kisi}'"
                    + $",{kargo.kurye_id});";
                context.Database.ExecuteSqlRaw(query);
                context.SaveChanges();
            }
        }
    }
}
