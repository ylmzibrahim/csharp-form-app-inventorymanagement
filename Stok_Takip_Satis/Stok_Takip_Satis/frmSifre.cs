using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_Satis
{
    public partial class frmSifre : Form
    {
        public frmSifre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "3258965471450qr")
            {
                this.Close();
                frmAdminPaneli frmAdmin = new frmAdminPaneli();
                frmAdmin.ShowDialog();
            }
        }
    }
}
