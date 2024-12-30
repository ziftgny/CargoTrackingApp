using Core.DataAccess.EntityFramework;
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
    public class EfKargoDal : EfEntityRepositoryBase<Kargo, CargoTrackingDatabaseContext>, IKargoDal
    {
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
        
        public KargoDetail GetKargoDetail(int id)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                var result = from k in context.kargolar
                             join g in context.musteriler
                             on k.gonderici_tc equals g.tc_no 
                             join a in context.musteriler
                             on k.alici_tc equals a.tc_no
                             join p in context.paket_turu
                             on k.paket_turu_id equals p.id
                             join kd in context.kargo_durum
                             on k.kargo_durumu_id equals kd.id
                             join ku in context.calisanlar
                             on k.kurye_id equals ku.id
                             where k.id == id
                             select new KargoDetail
                             {
                                 id = k.id,
                                 gonderici_TC=g.tc_no,
                                 alici_TC = a.tc_no,
                                 agirlik=k.agirlik,
                                 fiyat=k.fiyat,
                                 kabul_tarihi = k.kabul_tarihi,
                                 kargo_durumu_adi = kd.durum_adi,
                                 kurye_ad_soyad = ku.ad+" "+ku.soyad,
                                 paket_turu_adi = p.tur_adi,
                                 son_islem_tarihi = k.son_islem_tarihi,
                                 teslim_alan_kisi = k.teslim_alan_kisi,
                                 teslim_tarihi = k.teslim_tarihi
                             };
                return result.ToList()[0];
            }
        }
    }
}
