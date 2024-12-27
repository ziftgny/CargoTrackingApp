using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Entities;
namespace Entity.Concretes
{
    public class Kargo : IEntity
    {
        public int id { get; set; }
        public int gonderici_id { get; set; }
        public int alici_id {get ; set; }   
        public DateTime kabul_tarihi { get; set; }
        public int paket_turu_id { get; set; }
        public double fiyat { get; set; }
        public double agirlik { get; set; }
        public DateTime? teslim_tarihi { get; set; }
        public int kargo_durumu_id { get; set; }
        public DateTime? son_islem_tarihi { get; set; }
        public string teslim_alan_kisi { get; set; }
        public int kurye_id { get; set; }

    }
}
