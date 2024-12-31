using Core.DataAccess;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICalisanDal : IEntityRepository<Calisan>
    {
        bool CalisanLoginCheck(string tc_no, string sifre);
        List<Calisan> GetAllKurye();
        Calisan Get(string tc);
        void Delete(string tc);
    }
}
