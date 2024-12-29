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
        Calisan GetByTc(string tc);
        List<Calisan> GetAll();
        void Add(Calisan entity);
        void Delete(string tc);
        void Update(Calisan entity);
    }
}
