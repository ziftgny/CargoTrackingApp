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

        public MusteriDetail GetDetail(string tc) {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {

               
                    var result = from m in context.musteriler
                                 join a in context.adresler 
                                 on m.tc_no equals a.musteri_tc
                                 join il in context.iller
                                 on a.il_id equals il.id
                                 join ilc in context.ilceler
                                 on a.ilce_id equals ilc.id
                                 where m.tc_no == tc
                                 select new MusteriDetail
                                 {
                                     tc_no = m.tc_no,
                                     ad=m.ad,
                                     soyad=m.soyad,
                                     telefon_no=m.telefon_no,
                                     acik_adres=a.acik_adres,
                                     il=il.il_adi,
                                     ilce=ilc.ilce_adi,
                                     mah_sokak=a.mah_sokak,
                                     numara=a.numara,
                                     
                                 };
                    return result.ToList()[0];
               

            }
        }
    }
    }

