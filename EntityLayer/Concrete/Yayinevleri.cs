﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Yayinevleri
    {
        [Key]
        public int YayineviID { get; set; }

        [StringLength(50), Required]
        public string YayineviAd { get; set; }

        [StringLength(50)]
        public string YayineviAdres { get; set; }

        [ForeignKey("Yazarlar")]
        public int YazarID { get; set; }
        public virtual Yazarlar Yazarlar { get; private set; }
    }
}
