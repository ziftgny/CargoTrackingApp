using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAdresDal: EfEntityRepositoryBase<Adres,CargoTrackingDatabaseContext> ,IAdresDal
    {
        public int getAddressIdByTcNo(string tc_no)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                var result = from i in context.adresler
                             where i.musteri_tc==tc_no
                             select new Adres
                             {
                                id = i.id
                             };
                return  result.ToList()[0].id;
            }
        }

        
        public List<Il> getIller()
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                var result = from i in context.iller
                             
                             select new Il
                             {
                                 id = i.id,
                                 il_adi = i.il_adi,
                             };
                return result.ToList();
            }
        }
        public List<Ilce> getIlceler(int il_id)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                var result = from i in context.ilceler
                             where i.il_id == il_id
                             select new Ilce
                             {
                                 id = i.id,
                                 ilce_adi = i.ilce_adi,
                             };
                return result.ToList();
            }
        }
    }
}
