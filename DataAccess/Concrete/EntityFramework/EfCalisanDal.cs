using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public List<Calisan> GetAllKurye()
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                var result = from c in context.calisanlar
                             join g in context.yetkili_kullanicilar
                             on c.id equals g.calisan_id
                             join y in context.yetkiler
                             on g.yetki_id equals y.id
                             where y.id == 4
                             
                             select new Calisan
                             {
                                id = c.id,
                                ad = c.ad,
                                soyad = c.soyad,
                                sube_id = c.sube_id,
                                tc_no = c.tc_no
                             };
                return result.ToList();
            }
        }
        public bool CalisanLoginCheck(string tc_no,string sifre)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                var query = from c in context.calisanlar
                             join y in context.yetkili_kullanicilar
                             on c.id equals y.calisan_id
                             where tc_no == c.tc_no && sifre == y.sifre
                             select new Calisan
                             {
                                 id = c.id,
                                 ad = c.ad,
                                 soyad = c.soyad,
                                 sube_id = c.sube_id,
                                 tc_no = c.tc_no
                             };
                var result = query.ToList();
                if (result.Count==1)
                {
                    return true;
                }
                else { return false; }
            }
        }
        //public List<CalisanDetail> getAllCalisanDetail()
        //{
        //    using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
        //    {
        //        var query = from c in context.calisanlar
        //                    join y in context.yetkili_kullanicilar
        //                    on c.id equals y.calisan_id
        //                    where tc_no == c.tc_no && sifre == y.sifre
        //                    select new Calisan
        //                    {
        //                        id = c.id,
        //                        ad = c.ad,
        //                        soyad = c.soyad,
        //                        sube_id = c.sube_id,
        //                        tc_no = c.tc_no
        //                    };
        //        var result = query.ToList();
        //        if (result.Count == 1)
        //        {
        //            return true;
        //        }
        //        else { return false; }
        //    }
        //}

    }
}
