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
    public class CalisanManager : ICalisanService
    {
        ICalisanDal _calisanDal;

        public CalisanManager(ICalisanDal calisanDal)
        {
            _calisanDal = calisanDal;
        }

        public void Add(Calisan entity)
        {
            _calisanDal.Add(entity);
        }

        

        public void Delete(string tc)
        {
            _calisanDal.Delete(tc);
        }

        public List<Calisan> GetAll()
        {
            return _calisanDal.GetAll();
        }
   
       
        public Calisan GetByTc(string tc)
        {
            return _calisanDal.Get(tc);
        }

        public void Update(Calisan entity)
        {
        _calisanDal.Update(entity);
        }
    }
}
