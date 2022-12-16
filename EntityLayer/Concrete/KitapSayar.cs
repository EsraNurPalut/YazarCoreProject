using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
     public class KitapSayar
    {
        public int KitapSayarID { get; set; }

        public int KitapID { get; set; }

        public int KitapToplamStok { get; set; }

        public int KitapSayisi { get; set; }
    }
}
