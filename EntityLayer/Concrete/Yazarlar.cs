using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
   public class Yazarlar
    {
        [Key]
        public int YazarID { get; set; }


        [StringLength(50), Required]
        public string YazarAdSoyad { get; set; }


        [StringLength(50)]
        public string YazarMail { get; set; }

        public virtual List<Yayinevleri> Yayınevleri { get; set; } = new List<Yayinevleri>();  //bir yazarın birden fazla yayınevi olacagı için
    }
}
