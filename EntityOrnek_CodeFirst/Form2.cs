using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityOrnek_CodeFirst
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();
        private void button1_Click(object sender, EventArgs e)
        {
            /*  ----GruopBy Kullanımı----
            var degerler = db.TblOgrenci.OrderBy(x => x.Sehir).GroupBy(y => y.Sehir).Select(z => new
            {
                Sehir = z.Key,
                Toplam = z.Count()
            }).OrderBy(t => t.Toplam);
            dataGridView1.DataSource = degerler.ToList();
            */

            //En yüksek not
            //label1.Text = db.TblNotlar.Max(x => x.Ortalama).ToString();


            //Toplam Not Sayısı
            //label1.Text = db.TblNotlar.Count().ToString();

            //Sınıfta Kaç Ali var
            //label1.Text = db.TblOgrenciler.Count(x=x.Ad=="Ali").ToString();

            //Notların Toplamı
            //label1.Text = db.TblNotlar.Sum(x=>x.Ortalama).ToString();

            //Notların Ortalaması
            //label1.Text = db.TblNotlar.Average(x=>x.Ortalama).ToString();

            /*  --En yüksek ortalaması olan kişiyi getir--
            label1.Text = (from x in db.TblNotlar
                           orderby x.Ortalama descending
                           select x.TblOgrenci.Ad).First();
            */
        }
    }
}
