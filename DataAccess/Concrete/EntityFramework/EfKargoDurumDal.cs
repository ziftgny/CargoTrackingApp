﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKargoDurumDal : EfEntityRepositoryBase<Kargo_Durum, CargoTrackingDatabaseContext>, IKargoDurumDal
    {

    }
}
