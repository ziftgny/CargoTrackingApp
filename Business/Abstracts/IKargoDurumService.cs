using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IKargoDurumService
    {
         List<Kargo_Durum> GetAll();
         Kargo_Durum Get(int id);
         void Add(Kargo_Durum entity);
         void Delete(Kargo_Durum entity);
         void Update(Kargo_Durum entity);
    }
}
