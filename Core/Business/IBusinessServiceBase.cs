using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business
{
    public interface IBusinessServiceBase<Entity>
    {
        Entity GetById(int id);
        List<Entity> GetAll();
        void Add(Entity entity);
        void Delete(Entity entity);
        void Update(Entity entity);
    }
}
