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
            cmbDepartman.SelectedIndex = 0;
        }
    }
}
