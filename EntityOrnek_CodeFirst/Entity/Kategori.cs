using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityOrnek_CodeFirst.Entity
{
   public class Kategori
    {
        public int ID { get; set; }
        public string KategoriAd { get; set; }//KategoriAdi => KategoriAd yaptık verileri kaybetmeden(migration içinde sql komutu)
        //kategori içinde birden fazla urun olabilir
        public ICollection<Urunler> Urunlers { get; set; }
    }
}
