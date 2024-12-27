using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class Musteri : IEntity
    {
        public int id { get; set; }
        public String tc_no { get; set; }
        public String ad { get; set; }
        public String soyad { get; set; }
        public String telefon_no { get; set; }
    }
}
