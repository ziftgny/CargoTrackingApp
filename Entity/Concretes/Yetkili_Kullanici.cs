using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class Yetkili_Kullanici : IEntity
    {
        public int id { get; set; }
        public int yetki_id { get; set; }
        public String sifre { get; set; }
        public int calisan_id { get; set; }
  
    }
}
