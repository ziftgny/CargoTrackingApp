using Core.DataAccess;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMusteriDal : IEntityRepository<Musteri>
    {
        MusteriDetail GetDetail(string tc);
        Musteri Get(string tc);
        void Delete(string tc);
      
    }
}
