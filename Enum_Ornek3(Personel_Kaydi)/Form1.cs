using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_Ornek3_Personel_Kaydi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] departmann = Enum.GetNames(typeof(Departmanlar));
            cmbDepartman.Items.AddRange(departmann);
            cmbDepartman.Items.Clear();
            cmbDepartman.Items.AddRange(Enum.GetNames(typeof(Departmanlar)));
            cmbDepartman.SelectedIndex = 0;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.AdSoyad = txtAdSoyad.Text;
            personel.Departman = (Departmanlar).




            //personel.Departman = (Departmanlar).Enum.Parse(typeof(Departmanlar), cmbDepartman.Text);


            Departmanlar departman;
            bool sonuc = Enum.TryParse<Departmanlar>(cmbDepartman.Text, out departman);

            if (sonuc)
            {
                personel.Departman = departman;
                MessageBox.Show("Personel Kaydı Yapıldı!");
            }
            else
            {
                MessageBox.Show("Lütfen bir departman seçiniz");
            }
        }
    }
}
}
