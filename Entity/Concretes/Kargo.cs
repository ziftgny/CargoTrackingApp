using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Entities;
namespace Entity.Concretes
{
    public class Kargo : IEntity
    {
        [Key]
        public string? takip_no { get; set; }
        public string gonderici_tc { get; set; }
        public string alici_tc {get ; set; }   
        public DateOnly kabul_tarihi { get; set; }
        public int paket_turu_id { get; set; }
        public double fiyat { get; set; }
        public double agirlik { get; set; }
        public DateOnly? teslim_tarihi { get; set; }
        public int kargo_durumu_id { get; set; }
        public DateOnly? son_islem_tarihi { get; set; }
        public string? teslim_alan_kisi { get; set; }
        public int? kurye_id { get; set; }

    }
}
