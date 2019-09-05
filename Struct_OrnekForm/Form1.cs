using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct_OrnekForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ogrenciler[] ogrenciler = new Ogrenciler[0];

        List<Ogrenciler> ogrencilers;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            btnListele.Enabled = true;

            Ogrenciler ogrenci = new Ogrenciler()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TCNo = txtTCNo.Text,
                Cinsiyet = radioErkek.Checked ? true : false,
                DogumTarihi = dtDogumTarihi.Value
            };
            Array.Resize(ref ogrenciler, ogrenciler.Length + 1);
            ogrenciler[ogrenciler.Length - 1] = ogrenci;





        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            string data = "";
            foreach (Ogrenciler item in ogrenciler)
            {
                data += item.ToString() + "\n";
            }
            MessageBox.Show(data);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioErkek.Checked = true;
            ogrencilers = new List<Ogrenciler>();

            btnListele.Enabled = false  ;
        }
    }
}
