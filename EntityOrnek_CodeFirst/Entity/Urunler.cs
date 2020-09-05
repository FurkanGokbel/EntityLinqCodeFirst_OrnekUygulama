using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOrnek_CodeFirst.Entity
{
    public class Urunler
    {
        public int ID { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set; }
        public string UrunKategori { get; set; }
        public int UrunStok { get; set; }
        public string Aciklama { get; set; }
        //bir ürünün sadece bir kategorisi olabilir
        public Kategori Kategori { get; set; }
    }
}
