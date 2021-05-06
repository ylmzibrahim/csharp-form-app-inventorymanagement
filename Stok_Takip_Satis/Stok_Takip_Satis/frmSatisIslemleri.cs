using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Stok_Takip_Satis
{
    public partial class frmSatisIslemleri : Form
    {
        public frmSatisIslemleri()
        {
            InitializeComponent();
        }

        bool gecerliUrun;
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\StokTakip.mdf'");
        SqlConnection sqlConnection = new SqlConnection("Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");


        private void urunEkle()
        {
            string geciciKategori = "", geciciMarka = "", geciciAlisFiyati = "";
            string testBarkodNo = "";
            ArrayList geciciUrunSatistakiMiktar = new ArrayList();
            int geciciUrunSatisMiktarToplam = 0;
            int i = 0;

            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }

            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from urunBilgi where barkodNo like '" + txtBarkodNo.Text + "'", sqlConnection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                testBarkodNo = sqlDataReader["barkodNo"].ToString();
            }
            sqlConnection.Close();

            // YESSSS
            sqlConnection.Open();
            SqlCommand command2 = new SqlCommand("select * from urunSatis where barkodNo like '" + txtBarkodNo.Text + "'", sqlConnection);
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

            if (txtBarkodNo.Text == "")
            {
                MessageBox.Show("Barkod no girmediniz!", "Uyarı");
            }
            else if (testBarkodNo == "")
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
                SqlCommand sqlCommand1 = new SqlCommand("select * from urunBilgi where barkodNo='" + txtBarkodNo.Text + "'", sqlConnection);
                SqlDataReader sqlDataReader2 = sqlCommand1.ExecuteReader();
                while (sqlDataReader2.Read())
                {
                    geciciKategori = sqlDataReader2["kategori"].ToString();
                    geciciMarka = sqlDataReader2["marka"].ToString();
                    geciciAlisFiyati = sqlDataReader2["alisFiyati"].ToString();
                }
                sqlConnection.Close();

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into urunSatis(barkodNo, kategori, marka, urunAdi, miktari, alisFiyati, satisFiyati, iskonto, kdv, netSatisFiyati, tarih) values(@barkodNo, @kategori, @marka, @urunAdi, @miktari, @alisFiyati, @satisFiyati, @iskonto, @kdv, @netSatisFiyati, @tarih)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@barkodNo", txtBarkodNo.Text);
                sqlCommand.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
                sqlCommand.Parameters.AddWithValue("@kategori", geciciKategori);
                sqlCommand.Parameters.AddWithValue("@marka", geciciMarka);
                sqlCommand.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                sqlCommand.Parameters.AddWithValue("@alisFiyati", double.Parse(geciciAlisFiyati));
                sqlCommand.Parameters.AddWithValue("@satisFiyati", double.Parse(txtSatisFiyati.Text));
                sqlCommand.Parameters.AddWithValue("@iskonto", 0);
                sqlCommand.Parameters.AddWithValue("@kdv", double.Parse(txtKDV.Text));
                sqlCommand.Parameters.AddWithValue("@netSatisFiyati", double.Parse(txtNetFiyat.Text));
                sqlCommand.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }

            txtUrunAdi.Enabled = true;
            txtBarkodNo.Enabled = true;
            lblTopMiktarSayisi.Text = "0";
            this.ActiveControl = txtBarkodNo;

            lblToplamFiyatGet();
            dataGet();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
        }

        public void lblToplamFiyatGet()
        {
            ArrayList geciciBarkodNolar = new ArrayList();
            ArrayList geciciMiktarlar = new ArrayList();
            ArrayList geciciSatisFiyatlari = new ArrayList();
            ArrayList geciciNetSatisFiyatlari = new ArrayList();
            ArrayList geciciIskontolar = new ArrayList();
            int i = 0;
            lblToplamFiyat.Text = "0";

            sqlConnection.Open();
            SqlCommand sqlCommandFiyat = new SqlCommand("select * from urunSatis", sqlConnection);
            SqlDataReader sqlDataReaderFiyat = sqlCommandFiyat.ExecuteReader();
            while (sqlDataReaderFiyat.Read())
            {
                geciciBarkodNolar.Add(sqlDataReaderFiyat["barkodNo"].ToString());
                geciciMiktarlar.Add(sqlDataReaderFiyat["miktari"].ToString());
                geciciIskontolar.Add(sqlDataReaderFiyat["iskonto"].ToString());
                geciciSatisFiyatlari.Add(sqlDataReaderFiyat["satisFiyati"].ToString());
                geciciNetSatisFiyatlari.Add(sqlDataReaderFiyat["netSatisFiyati"].ToString());
                i++;
            }
            sqlConnection.Close();

            for (int j = 0; j < i; j++)
            {
                lblToplamFiyat.Text = (double.Parse(lblToplamFiyat.Text) + (double.Parse(geciciMiktarlar[j].ToString()) * (((double.Parse(geciciNetSatisFiyatlari[j].ToString()) * (100 - int.Parse(geciciIskontolar[j].ToString()))) / 100)))).ToString();
            }
        }

        public void dataGet()
        {
            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("select id as '" + "ID" + "', fisNo as '" + "Fiş No" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', satisFiyati as '" + "Satış Fiyatı" + "', iskonto as '" + "İskonto" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', tarih as '" + "Tarih" + "' from urunSatis", sqlConnection);
            sqlDataAdapter2.Fill(dataSet, "urunSatis");
            dataSatis.DataSource = dataSet.Tables["urunSatis"];
            sqlConnection.Close();
        }

        private void dataClear()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from urunSatis", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNo.Focused == true)
            {
                if (gecerliUrun)
                {
                    /*foreach (Control item in Controls)
                    {
                        if (item is TextBox || item is ComboBox)
                        {
                            item.Text = "";
                        }
                    }*/ // Eğer barkod no okunduğu an ürünü ekleyip diğer ürünü okumak için satırları silecek ise bu kodu çalıştır.

                    txtUrunAdi.Text = "";
                    txtMiktari.Text = "";
                    txtSatisFiyati.Text = "";
                    txtKDV.Text = "";
                    txtNetFiyat.Text = "";
                    gecerliUrun = false;
                    txtUrunAdi.Enabled = true;
                    lblTopMiktarSayisi.Text = "0";
                }

                string geciciAnaBarkodNo = "";
                sqlConnection.Open();
                SqlCommand sqlCommand1 = new SqlCommand("select * from yanBarkodlar where yanBarkodNo like '" + txtBarkodNo.Text + "'", sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                while (sqlDataReader1.Read())
                {
                    geciciAnaBarkodNo = sqlDataReader1["anaBarkodNo"].ToString();
                }
                sqlConnection.Close();

                if (geciciAnaBarkodNo != "")
                {
                    txtBarkodNo.Text = geciciAnaBarkodNo;
                }

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from urunBilgi where barkodNo like '" + txtBarkodNo.Text + "'", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    txtUrunAdi.Text = sqlDataReader["urunAdi"].ToString();
                    txtSatisFiyati.Text = sqlDataReader["satisFiyati"].ToString();
                    txtKDV.Text = sqlDataReader["kdv"].ToString();
                    txtNetFiyat.Text = sqlDataReader["netSatisFiyati"].ToString();
                    lblTopMiktarSayisi.Text = sqlDataReader["miktari"].ToString();

                    gecerliUrun = true;
                    txtUrunAdi.Enabled = false;
                    if (txtMiktari.Text == "")
                    {
                        txtMiktari.Text = "1";
                    }
                }
                sqlConnection.Close();
            }
        }

        public void frmSatisIslemleri_Load(object sender, EventArgs e)
        {
            gecerliUrun = false;
            dataClear();
            dataGet();
        }

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunAdi.Focused == true)
            {
                if (gecerliUrun)
                {
                    /*foreach (Control item in Controls)
                    {
                        if (item is TextBox || item is ComboBox)
                        {
                            item.Text = "";
                        }
                    }*/ // Eğer barkod no (veya ürün adı) okunduğu an ürünü ekleyip diğer ürünü okumak için satırları silecek ise bu kodu çalıştır.

                    txtBarkodNo.Text = "";
                    txtMiktari.Text = "";
                    txtSatisFiyati.Text = "";
                    txtKDV.Text = "";
                    txtNetFiyat.Text = "";
                    gecerliUrun = false;
                    txtBarkodNo.Enabled = true;
                    lblTopMiktarSayisi.Text = "0";
                }
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from urunBilgi where urunAdi like '" + txtUrunAdi.Text + "'", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    txtBarkodNo.Text = sqlDataReader["barkodNo"].ToString();
                    txtSatisFiyati.Text = sqlDataReader["satisFiyati"].ToString();
                    txtKDV.Text = sqlDataReader["kdv"].ToString();
                    txtNetFiyat.Text = sqlDataReader["netSatisFiyati"].ToString();
                    lblTopMiktarSayisi.Text = sqlDataReader["miktari"].ToString();

                    gecerliUrun = true;
                    txtBarkodNo.Enabled = false;
                    if (txtMiktari.Text == "")
                    {
                        txtMiktari.Text = "1";
                    }
                }
                sqlConnection.Close();
            }
        }

        

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            urunEkle();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            frmSatisSayfasi frmSatis = new frmSatisSayfasi();
            frmSatis.ShowDialog();
        }

        private void btnUrunCikar_Click(object sender, EventArgs e)
        {
            string testBarkodNo = "";
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from urunSatis where barkodNo like '" + txtBarkodNo.Text + "'", sqlConnection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                testBarkodNo = sqlDataReader["barkodNo"].ToString();
            }
            sqlConnection.Close();

            bool nullControl = false;
            foreach (Control item in Controls)
            {
                if (item is TextBox && item.Text == "")
                {
                    nullControl = true;
                }
            }
            if (nullControl)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı");
            }
            else if (testBarkodNo == "")
            {
                MessageBox.Show("Girdiğiniz barkod no geçerli değil", "Uyarı");
            }
            else if (int.Parse(txtMiktari.Text) > int.Parse(lblTopMiktarSayisi.Text))
            {
                MessageBox.Show("Çıkarmak istediğiniz miktar eklenen miktardan fazla olamaz!");
            }
            else if (txtMiktari.Text == lblTopMiktarSayisi.Text)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from urunSatis where id='" + geciciID + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                dataGet();
                lblToplamFiyatGet();
                txtUrunAdi.Enabled = true;
                MessageBox.Show("Ürün Başarıyla Çıkarıldı");

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                        item.Text = "";
                }
                lblTopMiktarSayisi.Text = "0";
                this.ActiveControl = txtBarkodNo;
            }
            else if (int.Parse(txtMiktari.Text) < int.Parse(lblTopMiktarSayisi.Text))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update urunSatis set miktari=@miktari where id='"+ geciciID + "'", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@miktari", (int.Parse(lblTopMiktarSayisi.Text) - int.Parse(txtMiktari.Text)));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                dataGet();
                lblToplamFiyatGet();
                txtUrunAdi.Enabled = true;
                MessageBox.Show("Ürün Miktari Güncellendi");

                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                        item.Text = "";
                }
                lblTopMiktarSayisi.Text = "0";
                this.ActiveControl = txtBarkodNo;
            }
        }

        string geciciID = "0";

        private void dataSatis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataSatis.Rows[e.RowIndex];
                geciciID = row.Cells["id"].Value.ToString();
                txtBarkodNo.Text = row.Cells["Barkod No"].Value.ToString();
                txtUrunAdi.Text = row.Cells["Ürün Adı"].Value.ToString();
                txtMiktari.Text = row.Cells["Miktar"].Value.ToString();
                txtSatisFiyati.Text = row.Cells["Satış Fiyatı"].Value.ToString();
                txtKDV.Text = row.Cells["KDV"].Value.ToString();
                txtNetFiyat.Text = row.Cells["Net Satış Fiyatı"].Value.ToString();
                lblTopMiktarSayisi.Text = row.Cells["Miktar"].Value.ToString();
                gecerliUrun = true;
                txtUrunAdi.Enabled = false;
                this.ActiveControl = txtMiktari;
            }
        }

        private void btnIkram_Click(object sender, EventArgs e)
        {
            /*
            ArrayList geciciBarkodNolar = new ArrayList();
            ArrayList geciciSatilanMiktarlar = new ArrayList();
            ArrayList geciciMiktarlar = new ArrayList();
            ArrayList oncekiMiktarlar = new ArrayList();
            int i = 0;

            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("select * from urunSatis", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            while (sqlDataReader.Read())
            {
                geciciBarkodNolar.Add(sqlDataReader["barkodNo"].ToString());
                geciciSatilanMiktarlar.Add(sqlDataReader["miktari"].ToString());
                i++;
            }
            sqlConnection.Close();

            for (int j = 0; j < i; j++)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand2 = new SqlCommand("select * from urunBilgi where barkodNo='" + geciciBarkodNolar[j] + "' ", sqlConnection);
                SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
                while (sqlDataReader2.Read())
                {
                    geciciMiktarlar.Add(sqlDataReader2["miktari"].ToString());
                }
                sqlConnection.Close();

                sqlConnection.Open();
                SqlCommand sqlCommand3 = new SqlCommand("update urunBilgi set miktari=@miktari where barkodNo='" + geciciBarkodNolar[j] + "' ", sqlConnection);
                sqlCommand3.Parameters.AddWithValue("@miktari", (int.Parse(geciciMiktarlar[j].ToString()) - int.Parse(geciciSatilanMiktarlar[j].ToString())).ToString());
                sqlCommand3.ExecuteNonQuery();
                sqlConnection.Close();
            }
            lblToplamFiyat.Text = "0";
            dataClear();
            dataGet();
            */


            ArrayList geciciBarkodNolar = new ArrayList();
            ArrayList geciciVerilenMiktarlar = new ArrayList();
            ArrayList geciciMiktarlar = new ArrayList();
            int i = 0;

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into gecmisIkramlar select barkodNo, urunAdi, kategori, marka, miktari, alisFiyati, satisFiyati, kdv, netSatisFiyati, '" + "0" + "', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss") + "' from urunSatis", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("select * from urunSatis", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            while (sqlDataReader.Read())
            {
                geciciBarkodNolar.Add(sqlDataReader["barkodNo"].ToString());
                geciciVerilenMiktarlar.Add(sqlDataReader["miktari"].ToString());
                i++;
            }
            sqlConnection.Close();


            for (int j = 0; j < i; j++)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand2 = new SqlCommand("select * from urunBilgi where barkodNo='" + geciciBarkodNolar[j] + "' ", sqlConnection);
                SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
                while (sqlDataReader2.Read())
                {
                    geciciMiktarlar.Add(sqlDataReader2["miktari"].ToString());
                }
                sqlConnection.Close();



                sqlConnection.Open();
                SqlCommand sqlCommand3 = new SqlCommand("update urunBilgi set miktari=@miktari where barkodNo='" + geciciBarkodNolar[j] + "' ", sqlConnection);
                sqlCommand3.Parameters.AddWithValue("@miktari", (int.Parse(geciciMiktarlar[j].ToString()) - int.Parse(geciciVerilenMiktarlar[j].ToString())).ToString());
                sqlCommand3.ExecuteNonQuery();
                sqlConnection.Close();

            }
            lblToplamFiyat.Text = "0";
            this.ActiveControl = txtBarkodNo;
            dataClear();
            dataGet();
        }

        private void txtBarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBarkodNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                urunEkle();
            }
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
                if (gecerliUrun == true)
                {
                    urunEkle();
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGet();
            lblToplamFiyatGet();
        }

        private void btnDigerUrunler_Click(object sender, EventArgs e)
        {
            frmDigerUrunler digerUrunler = new frmDigerUrunler();
            digerUrunler.ShowDialog();
        }
    }
}