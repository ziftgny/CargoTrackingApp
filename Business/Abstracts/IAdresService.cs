using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IAdresService
    {
        int getAddressIdByTcNo(string tc_no);

        List<Il> getIller();
        List<Ilce> getIlceler(int il_id);
        List<Adres> GetAll();
        void Add(Adres entity);
        void Delete(Adres entity);
        void Update(Adres entity);
    }
}
