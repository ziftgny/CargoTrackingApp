using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class CalisanDetail:IEntity
    {
        public int id {  get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string sube { get; set; }
        public string tc_no { get; set; }
        public string sifre { get; set; }
        public string yetki { get;set; }
        
    }
}
