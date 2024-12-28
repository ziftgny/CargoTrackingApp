using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKargoDal : EfEntityRepositoryBase<Kargo, CargoTrackingDatabaseContext>, IKargoDal
    {
       
        override public  List<Kargo> GetAll(Expression<Func<Kargo, bool>> filter = null)
        {
            using (CargoTrackingDatabaseContext context = new CargoTrackingDatabaseContext())
            {
                var result = context.kargolar.FromSqlRaw("SELECT * FROM kargooku(1325235)").ToList();
                return result;
            }
        }
    }
}
