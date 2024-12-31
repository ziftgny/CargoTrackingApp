using Core.DataAccess;
using Core.Entities;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAdresDal:IEntityRepository<Adres>
    {
        List<Il> getIller();
        List<Ilce> getIlceler(int il_id);
    }
}
