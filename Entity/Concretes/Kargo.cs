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
        public int Id { get; set; }
        public int GondericiId { get; set; }
        public int AliciId {get ; set; }   
        public DateTime KabulTarihi { get; set; }
        public int PaketTuruId { get; set; }
        public double Fiyat { get; set; }
        public double Agirlik { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public int KargoDurumId { get; set; }
        public DateTime SonIslemTarihi { get; set; }
        public String? TeslimAlanKisi { get; set; }
        public int? KuryeId { get; set; }
    }
}
