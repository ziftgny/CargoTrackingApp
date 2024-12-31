using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class KargoDetail :IEntity
    {

        public string? takip_no { get; set; }
        public string gonderici_tc { get; set; }
        public string alici_tc { get; set; }
        public DateOnly kabul_tarihi { get; set; }
        public string paket_turu_adi { get; set; }
        public double fiyat { get; set; }
        public double agirlik { get; set; }
        public DateOnly? teslim_tarihi { get; set; }
        public string kargo_durumu_adi { get; set; }
        public DateOnly? son_islem_tarihi { get; set; }
        public string? teslim_alan_kisi { get; set; }
        public string? kurye_ad_soyad { get; set; }
    }
}
