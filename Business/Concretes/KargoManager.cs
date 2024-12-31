using Business.Abstracts;
using Core.Entities;
using DataAccess.Abstract;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class KargoManager : IKargoService
    {
        IKargoDal _kargoDal;

        public KargoManager(IKargoDal kargoDal)
        {
            _kargoDal = kargoDal;
        }

        public void Add(Kargo entity)
        {
            _kargoDal.Add(entity);
        }

        public void Delete(string takip_no)
        {
            _kargoDal.Delete(takip_no);
        }

        public List<Kargo> GetAll()
        {
            return _kargoDal.GetAll();
        }

        public Kargo GetByTc(string takip_no)
        {
           return _kargoDal.Get(takip_no);
        }

        public KargoDetail GetDetail(string takip_no)
        {
            return _kargoDal.GetKargoDetail(takip_no);
        }

        public void Update(Kargo entity)
        {
            _kargoDal.Update(entity);
        }
    }
}
