﻿using Core.DataAccess;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IKargoDal : IEntityRepository<Kargo>
    {
        Kargo Get(string takip_no);
        void Delete(string takip_no);
        KargoDetail GetKargoDetail(string takip_no);
    }
}
