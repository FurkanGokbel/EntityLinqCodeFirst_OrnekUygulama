using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EntityOrnek_CodeFirst.Entity;
namespace EntityOrnek_CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Context c = new Context();
            //c.Database.Create();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                var degerler = db.TblNotlar.Where(x => x.Sinav1 < 50);
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton2.Checked == true)
            {
                var degerler = db.TblOgrenci.Where(x => x.Ad == "Ali");
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton3.Checked == true)
            {
                var degerler = db.TblOgrenci.Where(x => x.Ad == textBox1.Text || x.Soyad == textBox1.Text);
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton4.Checked == true)
            {
                var degerler = db.TblOgrenci.Select(x => new { soyadi = x.Soyad });
                dataGridView1.DataSource = degerler.ToList();
            }

            if (radioButton5.Checked == true)
            {
                var degerler = db.TblOgrenci.Select(x =>
                new { ad = x.Ad.ToUpper(), Soyadi = x.Soyad.ToLower() });
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton6.Checked == true)
            {
                var degerler = db.TblOgrenci.Select(x =>
                new
                {
                    ad = x.Ad.ToUpper(),
                    Soyadi = x.Soyad.ToLower()
                }).Where(x => x.ad != "Ali");
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton7.Checked == true)
            {
                var degerler = db.TblNotlar.Select(x => new
                {
                    OgrenciAd = x.OgrID,
                    Ortalaması = x.Ortalama,
                    Durumu = x.Durum == true ? "Geçti" : "Kaldı"
                });
                dataGridView1.DataSource = degerler.ToList();

            }
            if (radioButton8.Checked == true)
            {
                //Notlardaki OGRID ile Ogrencilerdeki ID yi eşle adı,ortalamayı ve durumunu al
                var degerler = db.TblNotlar.SelectMany(x =>
                db.TblOgrenci.Where(y => y.ID == x.OgrID), (x, y) => new
                {
                    y.Ad,
                    x.Ortalama,
                    Durum = x.Durum == true ? "Geçti" :
                    "Kaldı"
                });
                dataGridView1.DataSource = degerler.ToList();

            }
            if (radioButton9.Checked == true)
            {
                //ilk 3 değeri al
                var degerler = db.TblOgrenci.OrderBy(x => x.ID).Take(3);
                dataGridView1.DataSource = degerler.ToList();

            }
            if (radioButton10.Checked == true)
            {               
                //son 3 değeri al
                var degerler = db.TblOgrenci.OrderByDescending(x => x.ID).Take(3);
                dataGridView1.DataSource = degerler.ToList();

            }
            if (radioButton11.Checked == true)
            {
                //ada göre sırala
                var degerler = db.TblOgrenci.OrderByDescending(x => x.Ad);
                dataGridView1.DataSource = degerler.ToList();

            }
            if (radioButton12.Checked == true)
            {
                //ilk 5 değeri atla
                var degerler = db.TblOgrenci.OrderByDescending(x => x.ID).Skip(5);
                dataGridView1.DataSource = degerler.ToList();

            }
            if (radioButton12.Checked == true)
            {
                //ilk 5 değeri atla
                var degerler = db.TblOgrenci.OrderByDescending(x => x.ID).Skip(5);
                dataGridView1.DataSource = degerler.ToList();

            }
        }
    }
}
