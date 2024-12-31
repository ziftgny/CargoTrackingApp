using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICalisanService 
    {
        bool CalisanLoginCheck(string tc_no, string sifre);
        Calisan GetByTc(string tc);
        List<Calisan> GetAllKurye();
        List<Calisan> GetAll();
        void Add(Calisan entity);
        void Delete(string tc);
        void Update(Calisan entity);
    }
}
