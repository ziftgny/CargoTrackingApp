using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class Sube : IEntity
    {
        public int id { get; set; }
        public int il_id { get; set; }
        public int ilce_id { get; set; }
        public String sube_ad { get; set; }
        public String telefon_no { get; set; }
   
    }
}
