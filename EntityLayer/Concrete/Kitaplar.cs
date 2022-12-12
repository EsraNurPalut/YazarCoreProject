using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.Concrete
{
  public  class Kitaplar
    {
        [Key]
        public int KitapID { get; set; }


        [StringLength(50) ,Required]
        public string KitapAd { get; set; }


        [StringLength(4)]
        public string KitapBasimYili { get; set; }

        [ForeignKey("Yazarlar")]
        public int YazarID { get; set; }  //bir kitabın bir yazarı oldugu için virtual oluyor.list olmaz.
        public virtual Yazarlar Yazarlar { get; private set; }



    }
}
