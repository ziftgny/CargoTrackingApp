using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IPaketTuruService
    {
        List<Paket_Turu> GetAll();
        Paket_Turu Get(int id);
        void Add(Paket_Turu entity);
        void Delete(Paket_Turu entity);
        void Update(Paket_Turu entity);
    }
}
