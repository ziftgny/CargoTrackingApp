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
    public class AdresManager : IAdresService
    {
        IAdresDal _adresDal;

        public AdresManager(IAdresDal adresDal)
        {
            _adresDal = adresDal;
        }

        public void Add(Adres entity)
        {
            _adresDal.Add(entity);
        }

        public void Delete(Adres entity)
        {
            _adresDal.Delete(entity);
        }

        public int getAddressIdByTcNo(string tc_no)
        {
            return _adresDal.getAddressIdByTcNo(tc_no);
        }

        public List<Adres> GetAll()
        {
            return _adresDal.GetAll();
        }

        public List<Ilce> getIlceler(int il_id)
        {
            return _adresDal.getIlceler(il_id);
        }

        public List<Il> getIller()
        {
            return _adresDal.getIller();
        }

        public void Update(Adres entity)
        {
            _adresDal.Update(entity);
        }
    }
}
