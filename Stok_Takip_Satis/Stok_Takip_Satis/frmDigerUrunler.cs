using System;
using System.Collections;
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
    public partial class frmDigerUrunler : Form
    {
        public frmDigerUrunler()
        {
            InitializeComponent();
        }

        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\StokTakip.mdf'");
        SqlConnection sqlConnection = new SqlConnection("Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");
        bool gecerliUrun;

        private void urunEkle()
        {
            string geciciKategori = "", geciciMarka = "", geciciAlisFiyati = "", geciciSatisFiyati = "", geciciKDV = "", geciciNetSatisFiyati = "";
            string testUrunAdi = "";
            ArrayList geciciUrunSatistakiMiktar = new ArrayList();
            int geciciUrunSatisMiktarToplam = 0;
            int i = 0;

            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }

            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from urunBilgi where urunAdi like '" + txtUrunAdi.Text + "'", sqlConnection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                testUrunAdi= sqlDataReader["urunAdi"].ToString();
            }
            sqlConnection.Close();

            // YESSSS
            sqlConnection.Open();
            SqlCommand command2 = new SqlCommand("select * from urunSatis where urunAdi like '" + txtUrunAdi.Text + "'", sqlConnection);
            SqlDataReader sqlDataReader1 = command2.ExecuteReader();
            while (sqlDataReader1.Read())
            {
                geciciUrunSatistakiMiktar.Add(sqlDataReader1["miktari"].ToString());
                i++;
            }
            sqlConnection.Close();
            for (int j = 0; j < i; j++)
            {
                geciciUrunSatisMiktarToplam += int.Parse(geciciUrunSatistakiMiktar[j].ToString());
            }
            //

            if (txtUrunAdi.Text == "")
            {
                MessageBox.Show("Ürün Adı girmediniz!", "Uyarı");
            }
            else if (testUrunAdi == "")
            {
                MessageBox.Show("Girmeye çalıştığınız ürün kayıtlı değil!", "Uyarı");
            }
            else if ((txtMiktari.Text != "") && (int.Parse(txtMiktari.Text) > (int.Parse(lblTopMiktarSayisi.Text) - geciciUrunSatisMiktarToplam)))
            {
                MessageBox.Show("Stoktaki adet sayısından fazla satış yapamazsın!");
            }
            else
            {
                if (txtMiktari.Text == "")
                {
                    txtMiktari.Text = "1";
                }

                sqlConnection.Open();
                SqlCommand sqlCommand1 = new SqlCommand("select * from urunBilgi where urunAdi like '" + txtUrunAdi.Text + "'", sqlConnection);
                SqlDataReader sqlDataReader2 = sqlCommand1.ExecuteReader();
                while (sqlDataReader2.Read())
                {
                    geciciKategori = sqlDataReader2["kategori"].ToString();
                    geciciMarka = sqlDataReader2["marka"].ToString();
                    geciciAlisFiyati = sqlDataReader2["alisFiyati"].ToString();
                    geciciSatisFiyati = sqlDataReader2["satisFiyati"].ToString();
                    geciciKDV= sqlDataReader2["kdv"].ToString();
                    geciciNetSatisFiyati = sqlDataReader2["netSatisFiyati"].ToString();
                }
                sqlConnection.Close();

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into urunSatis(urunAdi, kategori, marka, miktari, alisFiyati, satisFiyati, iskonto, kdv, netSatisFiyati, tarih) values(@urunAdi, @kategori, @marka, @miktari, @alisFiyati, @satisFiyati, @iskonto, @kdv, @netSatisFiyati, @tarih)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
                sqlCommand.Parameters.AddWithValue("@kategori", geciciKategori);
                sqlCommand.Parameters.AddWithValue("@marka", geciciMarka);
                sqlCommand.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                sqlCommand.Parameters.AddWithValue("@alisFiyati", double.Parse(geciciAlisFiyati));
                sqlCommand.Parameters.AddWithValue("@satisFiyati", double.Parse(geciciSatisFiyati));
                sqlCommand.Parameters.AddWithValue("@iskonto", 0);
                sqlCommand.Parameters.AddWithValue("@kdv", double.Parse(geciciKDV));
                sqlCommand.Parameters.AddWithValue("@netSatisFiyati", double.Parse(geciciNetSatisFiyati));
                sqlCommand.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            this.ActiveControl = txtUrunAdi;
            txtUrunAdi.Text = "";
            txtMiktari.Text = "";
            lblTopMiktarSayisi.Text = "0";
        }

        private void dataGet()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', tarih as '" + "Tarih" + "' From urunBilgi where barkodNo is NULL", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataSet, "urunBilgi");
            dataDigerUrunler.DataSource = dataSet.Tables["urunBilgi"];
            sqlConnection.Close();
        }

        private void txtUrunAdiUrun_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunAdi.Focused == true)
            {
                if (gecerliUrun)
                {
                    txtMiktari.Text = "";
                    gecerliUrun = false;
                    lblTopMiktarSayisi.Text = "0";
                }
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from urunBilgi where barkodNo is NULL and urunAdi like '" + txtUrunAdi.Text + "'", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lblTopMiktarSayisi.Text = sqlDataReader["miktari"].ToString();
                    gecerliUrun = true;
                    if (txtMiktari.Text == "")
                    {
                        txtMiktari.Text = "1";
                    }
                }
                sqlConnection.Close();
            }
        }

        private void frmDigerUrunler_Load(object sender, EventArgs e)
        {
            dataGet();
            gecerliUrun = false;
        }

        private void dataDigerUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataDigerUrunler.Rows[e.RowIndex];
                txtUrunAdi.Text = row.Cells["Ürün Adı"].Value.ToString();
                lblTopMiktarSayisi.Text = row.Cells["Miktar"].Value.ToString();
                if (txtMiktari.Text == "")
                {
                    txtMiktari.Text = "1";
                }
                this.ActiveControl = txtMiktari;
                gecerliUrun = true;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            urunEkle();
        }

        private void txtUrunAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                urunEkle();
            }
        }

        private void txtMiktari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                urunEkle(); 
            }
        }
    }
}
