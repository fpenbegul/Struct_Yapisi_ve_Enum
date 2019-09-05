using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_Ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Gunler
        {
            Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar
        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            int guno = int.Parse(txtGunNo.Text);
            Gunler gunAdi = (Gunler)guno - 1;

            txtGunNo.Text = "";
            MessageBox.Show(gunAdi.ToString());


        }




    }
}
