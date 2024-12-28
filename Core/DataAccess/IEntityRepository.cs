﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        public List<T> GetAll(Expression<Func<T,bool>> filter=null);
        public T Get(int id);
        public void Add(T entity);
        public void Delete(int id);
        public void Update(T entity);
    }
}
