using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class Ilce : IEntity
    {
        public int id { get; set; }
        public int il_id { get; set; }
        public String ilce_adi { get; set; }

    }
}
