using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IMusteriService
    {
        Musteri GetByTc(string tc);
        List<Musteri> GetAll();
        void Add(Musteri entity);
        void Delete(string tc);
        void Update(Musteri entity);
    }
}
