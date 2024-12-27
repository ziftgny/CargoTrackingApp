using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class Kargo_Durum : IEntity
    {
        public int id { get; set; }
        public String durum_adi { get; set; }
    }
}
