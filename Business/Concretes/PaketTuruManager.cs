using Business.Abstracts;
using DataAccess.Abstract;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class PaketTuruManager : IPaketTuruService
    {
        IPaketTuruDal _paketTuruDal;

        public PaketTuruManager(IPaketTuruDal paketTuruDal)
        {
            _paketTuruDal = paketTuruDal;
        }

        public void Add(Paket_Turu entity)
        {
            _paketTuruDal.Add(entity);
        }

        public void Delete(Paket_Turu entity)
        {
            _paketTuruDal.Delete(entity);
        }

        public Paket_Turu Get(int id)
        {
            return _paketTuruDal.Get(p=>p.id==id);
        }

        public List<Paket_Turu> GetAll()
        {
           return _paketTuruDal.GetAll();
        }

        public void Update(Paket_Turu entity)
        {
            _paketTuruDal.Update(entity);
        }
    }
}
