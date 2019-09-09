using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_Ornek2_Plaka_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Sehirler : short
        {
            Ankara = 6,
            İzmir = 35,
            İstanbul = 34,
            Antalya = 7,
            Konya = 42,
            Yalova = 77,
            Malatya = 44,
            Kocaeli = 41,
            Eskişehir = 26,
            Tekirdağ = 59
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sehirler = Enum.GetNames(typeof(Sehirler));
            comboBox1.Items.AddRange(sehirler);

          

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPlaka.Text = ((short)Enum.Parse(typeof(Sehirler), comboBox1.Text)).ToString();

        }
    }
}
