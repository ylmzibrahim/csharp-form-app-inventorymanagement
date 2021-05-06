using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_Satis
{
    public partial class frmSeriNo : Form
    {
        public frmSeriNo()
        {
            InitializeComponent();
        }

        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\StokTakip.mdf'");
        SqlConnection sqlConnection = new SqlConnection("Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen geçerli bir Seri Numarası giriniz.");
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update seriNolar set seriNo='"+ textBox1.Text +"' where id='"+ 1 +"'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Seri Numarası başarıyla güncellendi.");
            }
        }

        private void frmSeriNo_Load(object sender, EventArgs e)
        {

        }
    }
}
