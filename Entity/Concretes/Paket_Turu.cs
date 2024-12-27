using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class Paket_Turu : IEntity
    {
        public int id { get; set; }
        public String tur_adi { get; set; }
    }
}
