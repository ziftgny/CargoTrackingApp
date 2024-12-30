using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IKargoService
    {
        Kargo GetById(int id);
        List<Kargo> GetAll();
        void Add(Kargo entity);
        void Delete(int id);
        void Update(Kargo entity);
        KargoDetail GetDetail(int id);
    }
}
