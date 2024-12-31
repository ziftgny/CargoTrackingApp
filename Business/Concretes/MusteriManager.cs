using Business.Abstracts;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _musteriDal;

        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }
        public void Add(Musteri entity)
        {
            _musteriDal.Add(entity);
        }

        public void Delete(string tc)
        {
            _musteriDal.Delete(tc);
        }

        public List<Musteri> GetAll()
        {
            return _musteriDal.GetAll();
        }

        public Musteri GetByTc(string tc)
        {
            return _musteriDal.Get(tc);
        }

        public MusteriDetail GetDetail(string tc)
        {
            return _musteriDal.GetDetail(tc);
        }

        public void Update(Musteri entity)
        {
            _musteriDal.Update(entity);
        }
    }
}
