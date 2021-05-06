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
    public partial class frmAdminPaneli : Form
    {
        public frmAdminPaneli()
        {
            InitializeComponent();
        }

        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\StokTakip.mdf'");
        SqlConnection sqlConnection = new SqlConnection("Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        private void btnUrun_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Bu zamana kadar girilen tüm ürün bilgileri sıfırlanacak. Bunu onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from urunBilgi", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Veri tabanındaki tüm ürün bilgileri sıfırlandı.");
            }
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Bu zamana kadar girilen tüm kategori bilgileri sıfırlanacak. Bunu onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from kategoriler", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Veri tabanındaki tüm kategori bilgileri sıfırlandı.");
            }
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Bu zamana kadar girilen tüm marka bilgileri sıfırlanacak. Bunu onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from markalar", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Veri tabanındaki tüm marka bilgileri sıfırlandı.");
            }
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Bu zamana kadar girilen tüm ürünlerin stoğu sıfırlanacak. Bunu onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update urunBilgi set miktari='" + 0 + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Veri tabanındaki tüm ürünlerin stoğu sıfırlandı.");
            }
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Bu zamana kadar yaptığınız tüm satışların bilgileri sıfırlanacak. Bunu onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from gecmisSatislar", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Veri tabanındaki gecmiş satışların bilgileri sıfırlandı.");
            }
        }

        private void btnIkram_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Bu zamana kadar yaptığınız tüm ikramların bilgileri sıfırlanacak. Bunu onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from gecmisIkramlar", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Veri tabanındaki geçmiş ikramların bilgileri sıfırlandı.");
            }
        }

        private void btnSeriNo_Click(object sender, EventArgs e)
        {
            frmSeriNo frmSeriNo = new frmSeriNo();
            frmSeriNo.ShowDialog();
        }

        private void frmAdminPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
