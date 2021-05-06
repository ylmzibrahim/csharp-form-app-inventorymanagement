using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Data.SqlClient;

namespace Stok_Takip_Satis
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\StokTakip.mdf'");
        SqlConnection sqlConnection = new SqlConnection("Data Source="+ System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string testAcilanBiosSerial = "", acilanBiosSerial = "", kullanıcıBiosSerial = "", testKullanıcıBiosSerial = "";

            ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, SMBIOSBIOSVersion, ReleaseDate FROM Win32_BIOS");
            ManagementObjectCollection collection = mSearcher.Get();
            foreach (ManagementObject obj in collection)
            {
                testAcilanBiosSerial = (string)obj["SerialNumber"];
            }

            acilanBiosSerial = String.Concat(testAcilanBiosSerial.Where(c => !Char.IsWhiteSpace(c)));

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select seriNo from seriNolar", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                testKullanıcıBiosSerial = sqlDataReader["seriNo"].ToString();
            }
            sqlConnection.Close();

            kullanıcıBiosSerial = String.Concat(testKullanıcıBiosSerial.Where(c => !Char.IsWhiteSpace(c)));

            if (acilanBiosSerial != kullanıcıBiosSerial)
            {
                MessageBox.Show("Bu programın tüm hakları Mate Bilişim'e aittir.\n\"matebilisim.com\" adresinden bize ulaşıp programı satın alabilirsiniz.");
                Application.Exit();
            }
            else if (acilanBiosSerial == kullanıcıBiosSerial)
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
        }

        private void frmGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.Alt && e.Control && e.KeyCode == Keys.D)
            {
                frmSifre frmSifre = new frmSifre();
                frmSifre.ShowDialog();
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            frmSifre frmSifre = new frmSifre();
            frmSifre.ShowDialog();
        }
    }
}
