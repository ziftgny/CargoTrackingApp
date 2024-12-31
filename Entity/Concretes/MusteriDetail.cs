using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class MusteriDetail:IEntity
    {
       public string tc_no { get; set; }
       public string ad { get; set; }
       public string soyad { get; set; }
       public string telefon_no { get; set; }
       public string il { get; set; }
       public string ilce { get; set; }
       public string mah_sokak { get; set; }
       public string numara { get; set; }
       public string acik_adres { get; set; }
    }
}
