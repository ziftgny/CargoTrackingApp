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
        Kargo GetByTc(string takip_no);
        List<Kargo> GetAll();
        void Add(Kargo entity);
        void Delete(string takip_no);
        void Update(Kargo entity);
        KargoDetail GetDetail(string takip_no);
    }
}
