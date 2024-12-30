using Business.Abstracts;
using DataAccess.Abstract;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class KargoDurumManager : IKargoDurumService
    {
        IKargoDurumDal _kargoDurumDal;

        public KargoDurumManager(IKargoDurumDal kargoDurumDal)
        {
            _kargoDurumDal = kargoDurumDal;
        }

        public void Add(Kargo_Durum entity)
        {
            _kargoDurumDal.Add(entity);
        }

        public void Delete(Kargo_Durum entity)
        {
            _kargoDurumDal.Delete(entity);
        }

        public Kargo_Durum Get(int id)
        {
            return _kargoDurumDal.Get(p=>p.id==id);
        }

        public List<Kargo_Durum> GetAll()
        {
            return _kargoDurumDal.GetAll();
        }

        public void Update(Kargo_Durum entity)
        {
            _kargoDurumDal.Update(entity);  
        }
    }
}
