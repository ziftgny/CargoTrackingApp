using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    
        public interface IEntityRepositoryTC<T> where T : class, IEntity, new()
        {
            public List<T> GetAll(Expression<Func<T, bool>> filter = null);
            public T Get(string tc);
            public void Add(T entity);
            public void Delete(string tc);
            public void Update(T entity);
        
    }
}
