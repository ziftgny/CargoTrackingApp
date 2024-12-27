using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class Calisan:IEntity
    {
        public int id { get; set; }
        public String ad { get; set; }
        public String soyad { get; set; }
        public int sube_id { get; set; }
        public String tc_no { get; set; }
    }
}
