﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class Adres:IEntity
    {
        public int id { get; set; }
        public int il_id { get; set; }
        public int ilce_id { get; set; }
        public String mah_sokak { get; set; }
        public String numara { get; set; }
        public String acik_adres { get; set; }
        public int musteri_id { get; set; }

    }
}