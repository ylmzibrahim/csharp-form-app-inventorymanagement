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
using System.Reflection;

namespace Stok_Takip_Satis
{
    public partial class frmUrunEkleme : Form
    {
        public frmUrunEkleme()
        {
            InitializeComponent();
        }

        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\StokTakip.mdf'");
        SqlConnection sqlConnection = new SqlConnection("Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");
        bool gecerliUrun;
        bool isNew;

        private void kategoriEngelle()
        {
            isNew = true;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from kategoriler", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if ((txtKategori.Text).ToLower() == (sqlDataReader["kategori"].ToString()).ToLower())
                {
                    isNew = false;
                }
            }
            sqlConnection.Close();
        }

        private void markaEngelle()
        {
            isNew = true;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from markalar", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if ((comboKategori.Text).ToLower() == (sqlDataReader["kategori"].ToString()).ToLower() && (txtMarka.Text).ToLower() == (sqlDataReader["marka"].ToString()).ToLower())
                {
                    isNew = false;
                }
            }
            sqlConnection.Close();
        }

        private void urunEngelle()
        {
            isNew = true;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from urunBilgi", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if ((txtBarkodNoUrun.Text).ToLower() == (sqlDataReader["barkodNo"].ToString()).ToLower() || (txtUrunAdiUrun.Text).ToLower() == (sqlDataReader["urunAdi"].ToString()).ToLower())
                {
                    isNew = false;
                }
            }
            sqlConnection.Close();
        }

        public void kategoriGet()
        {
            comboKategoriUrun.Items.Clear();
            comboKategori.Items.Clear();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select *from kategoriler", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                comboKategoriUrun.Items.Add(sqlDataReader["kategori"].ToString());
                comboKategori.Items.Add(sqlDataReader["kategori"].ToString());
            }
            sqlConnection.Close();
        }

        public void kategoriSelectedItemGet()
        {
            if (txtBarkodNoUrun.Focused == false && txtUrunAdiUrun.Focused == false) {
                int sqlState = 0;
                comboMarkaUrun.Items.Clear();
                comboMarkaUrun.Text = "";
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlState = 1;
                    sqlConnection.Open();
                }
                SqlCommand sqlCommand = new SqlCommand("select * from markalar where kategori='" + comboKategoriUrun.SelectedItem + "'", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    comboMarkaUrun.Items.Add(sqlDataReader["marka"].ToString());
                }
                if (sqlState == 1)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKategoricombo.Text = comboKategori.Text;
        }

        private void frmUrunEkleme_Load(object sender, EventArgs e)
        {
            kategoriGet();
        }

        //private void dataGetEkleme()
        //{
        //    DataSet dataSet = new DataSet();

        //    sqlConnection.Open();
        //    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("Select barkodNo as '"+ "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', tarih as '" + "Tarih" + "' From urunBilgi", sqlConnection);
        //    sqlDataAdapter1.Fill(dataSet, "urunBilgi");
        //    dataUrun.DataSource = dataSet.Tables["urunBilgi"];

        //    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("Select kategori as '" + "Kategori" + "' From kategoriler", sqlConnection);
        //    sqlDataAdapter2.Fill(dataSet, "kategoriler");
        //    dataKategori.DataSource = dataSet.Tables["kategoriler"];

        //    SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter("Select kategori as '" + "Kategori" + "', marka as '" + "Marka" + "' From markalar", sqlConnection);
        //    sqlDataAdapter3.Fill(dataSet, "markalar");
        //    dataMarka.DataSource = dataSet.Tables["markalar"];
        //    sqlConnection.Close();
        //}

        private void comboMarkaUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboKategoriUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            kategoriSelectedItemGet();
        }

        private void btnEkleUrun_Click(object sender, EventArgs e)
        {
            urunEngelle();
            bool nullControl = false;
            foreach (Control item in groupUrun.Controls)
            {
                if (txtUrunAdiUrun.Text == "" && txtMiktariUrun.Text == "" && txtAlisFiyatiUrun.Text == "" && txtSatisFiyatiUrun.Text == "" && comboKDVUrun.SelectedItem == null && txtNetFiyatUrun.Text == "")
                {
                    nullControl = true;
                }
            }
            if (nullControl)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı");
            }
            else if (txtUrunAdiUrun.Text.Length < 4)
            {
                MessageBox.Show("'Ürün Adı'nın uzunluğu en az 4 olmalıdır", "Uyarı");
            }
            else if (isNew)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into urunBilgi(barkodNo, kategori, marka, urunAdi, miktari, alisFiyati, satisFiyati, kdv, netSatisFiyati, tarih) values(@barkodNo, @kategori, @marka, @urunAdi, @miktari, @alisFiyati, @satisFiyati, @kdv, @netSatisFiyati, @tarih)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@barkodNo", txtBarkodNoUrun.Text);
                sqlCommand.Parameters.AddWithValue("@kategori", comboKategoriUrun.SelectedItem);
                sqlCommand.Parameters.AddWithValue("@marka", comboMarkaUrun.SelectedItem);
                sqlCommand.Parameters.AddWithValue("@urunAdi", txtUrunAdiUrun.Text);
                sqlCommand.Parameters.AddWithValue("@miktari", int.Parse(txtMiktariUrun.Text));
                sqlCommand.Parameters.AddWithValue("@alisFiyati", double.Parse(txtAlisFiyatiUrun.Text));
                sqlCommand.Parameters.AddWithValue("@satisFiyati", double.Parse(txtSatisFiyatiUrun.Text));
                sqlCommand.Parameters.AddWithValue("@kdv", int.Parse(comboKDVUrun.Text));
                sqlCommand.Parameters.AddWithValue("@netSatisFiyati", double.Parse(txtNetFiyatUrun.Text));
                sqlCommand.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                //dataGetEkleme();
                MessageBox.Show("Ürün Başarıyla Eklendi");

                foreach (Control item in groupUrun.Controls)
                {
                    if (item is TextBox)
                        item.Text = "";
                }
                comboKategoriUrun.SelectedItem = null;
                comboMarkaUrun.Items.Clear();
                comboKDVUrun.SelectedItem = null;
            }
            else if (!isNew)
            {
                MessageBox.Show("Böyle bir ürün zaten var", "Uyarı");
            }
            else
            {
                MessageBox.Show("Geçersiz işlem", "Uyarı");
            }
        }

        private void btnEkleKategori_Click(object sender, EventArgs e)
        {
            kategoriEngelle();
            if (txtKategori.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı");
            }
            else if (txtKategori.Text.Length < 4)
            {
                MessageBox.Show("'Kategori'nin uzunluğu en az 4 olmalıdır", "Uyarı");
            }
            else if (isNew)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into kategoriler values('" + txtKategori.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                kategoriGet();
                //dataGetEkleme();
                MessageBox.Show("Kategori Eklendi.");
            }
            else if (!isNew)
            {
                MessageBox.Show("Böyle bir kategori zaten var", "Uyarı");
            }
            else
            {
                MessageBox.Show("Geçersiz işlem", "Uyarı");
            }
            txtKategori.Text = "";
        }

        private void btnEkleMarka_Click(object sender, EventArgs e)
        {
            markaEngelle();
            if (comboKategori.Text == "" || txtMarka.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı");
            }
            else if (txtMarka.Text.Length < 4)
            {
                MessageBox.Show("'Marka'nın uzunluğu en az 4 olmalıdır", "Uyarı");
            }
            else if (isNew)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into markalar(kategori, marka) values('" + comboKategori.Text + "', '" + txtMarka.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                //dataGetEkleme();
                MessageBox.Show("Marka Eklendi.");
            }
            else if (!isNew)
            {
                MessageBox.Show("Bu kategoride bu marka zaten var", "Uyarı");
            }
            else
            {
                MessageBox.Show("Geçersiz işlem", "Uyarı");
            }
            comboKategori.Text = "";
            txtMarka.Text = "";
        }

        private void txtBarkodNoUrun_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNoUrun.Focused)
            {
                DataTable searchTable = new DataTable();
                if (txtBarkodNoUrun.Text.Length > 3)
                {
                    sqlConnection.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', tarih as '" + "Tarih" + "' from urunBilgi where barkodNo like '%" + txtBarkodNoUrun.Text + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                    sqlConnection.Close();
                    isUrunBilgi = true;
                }
                else
                {
                    searchTable.Rows.Clear();
                }
                dataUrun.DataSource = searchTable;

                if (gecerliUrun)
                {
                    /*foreach (Control item in groupUrun.Controls)
                    {
                        if (item is TextBox || item is ComboBox)
                        {
                            item.Text = "";
                        }
                    }*/ //Burada txtBarkodNo.Text 'i de sildiğinden dolayı barkod ile seri okuma yapılacak ise bu kod kullanılmalı

                    txtUrunAdiUrun.Text = "";
                    comboKategoriUrun.SelectedItem = null;
                    comboMarkaUrun.SelectedItem = null;
                    txtMiktariUrun.Text = "";
                    txtAlisFiyatiUrun.Text = "";
                    txtSatisFiyatiUrun.Text = "";
                    comboKDVUrun.SelectedItem = null;
                    txtNetFiyatUrun.Text = "";
                    gecerliUrun = false;
                }

                string geciciMarka = "";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from urunBilgi where barkodNo like '" + txtBarkodNoUrun.Text + "'", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    comboKategoriUrun.SelectedItem = sqlDataReader["kategori"].ToString();
                    geciciMarka = sqlDataReader["marka"].ToString();
                    txtUrunAdiUrun.Text = sqlDataReader["urunAdi"].ToString();
                    txtMiktariUrun.Text = sqlDataReader["miktari"].ToString();
                    txtAlisFiyatiUrun.Text = sqlDataReader["alisFiyati"].ToString();
                    txtSatisFiyatiUrun.Text = sqlDataReader["satisFiyati"].ToString();
                    comboKDVUrun.SelectedItem = sqlDataReader["kdv"].ToString();
                    txtNetFiyatUrun.Text = sqlDataReader["netSatisFiyati"].ToString();
                    gecerliUrun = true;
                }
                sqlConnection.Close();
                
                int sqlState = 0;
                comboMarkaUrun.Items.Clear();
                comboMarkaUrun.Text = "";
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlState = 1;
                    sqlConnection.Open();
                }
                SqlCommand sqlCommand1 = new SqlCommand("select * from markalar where kategori='" + comboKategoriUrun.SelectedItem + "'", sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                while (sqlDataReader1.Read())
                {
                    comboMarkaUrun.Items.Add(sqlDataReader1["marka"].ToString());
                }
                if (sqlState == 1)
                {
                    sqlConnection.Close();
                }
                comboMarkaUrun.SelectedItem = geciciMarka;
            }
        }

        private void txtUrunAdiUrun_TextChanged(object sender, EventArgs e)
        {
            //Ürün adını güncellemek isteyeceği için txtUrunAdiUrun'e yazı yazarken otomatik aramayı kapattım.
            if (txtUrunAdiUrun.Focused)
            {
                DataTable searchTable = new DataTable();
                if (txtUrunAdiUrun.Text.Length > 3)
                {
                    sqlConnection.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', tarih as '" + "Tarih" + "' from urunBilgi where urunAdi like '%" + txtUrunAdiUrun.Text + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                    sqlConnection.Close();
                    isUrunBilgi = true;
                }
                else
                {
                    searchTable.Rows.Clear();
                }
                dataUrun.DataSource = searchTable;

                if (gecerliUrun)
                {
                    /*foreach (Control item in groupUrun.Controls)
                    {
                        if (item is TextBox || item is ComboBox)
                        {
                            item.Text = "";
                        }
                    }*/ //Burada txtBarkodNo.Text 'i de sildiğinden dolayı barkod ile seri okuma yapılacak ise bu kod kullanılmalı

                    txtBarkodNoUrun.Text = "";
                    comboKategoriUrun.SelectedItem = null;
                    comboMarkaUrun.SelectedItem = null;
                    txtMiktariUrun.Text = "";
                    txtAlisFiyatiUrun.Text = "";
                    txtSatisFiyatiUrun.Text = "";
                    comboKDVUrun.SelectedItem = null;
                    txtNetFiyatUrun.Text = "";
                    gecerliUrun = false;
                }

                string geciciMarka = "";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from urunBilgi where barkodNo like '" + txtUrunAdiUrun.Text + "'", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    comboKategoriUrun.SelectedItem = sqlDataReader["kategori"].ToString();
                    geciciMarka = sqlDataReader["marka"].ToString();
                    txtBarkodNoUrun.Text = sqlDataReader["barkodNo"].ToString();
                    txtMiktariUrun.Text = sqlDataReader["miktari"].ToString();
                    txtAlisFiyatiUrun.Text = sqlDataReader["alisFiyati"].ToString();
                    txtSatisFiyatiUrun.Text = sqlDataReader["satisFiyati"].ToString();
                    comboKDVUrun.SelectedItem = sqlDataReader["kdv"].ToString();
                    txtNetFiyatUrun.Text = sqlDataReader["netSatisFiyati"].ToString();
                    gecerliUrun = true;
                }
                sqlConnection.Close();

                int sqlState = 0;
                comboMarkaUrun.Items.Clear();
                comboMarkaUrun.Text = "";
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlState = 1;
                    sqlConnection.Open();
                }
                SqlCommand sqlCommand1 = new SqlCommand("select * from markalar where kategori='" + comboKategoriUrun.SelectedItem + "'", sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
                while (sqlDataReader1.Read())
                {
                    comboMarkaUrun.Items.Add(sqlDataReader1["marka"].ToString());
                }
                if (sqlState == 1)
                {
                    sqlConnection.Close();
                }
                comboMarkaUrun.SelectedItem = geciciMarka;
            }
        }

        private void dataUrun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSilUrun_Click(object sender, EventArgs e)
        {
            string testBarkodNo = "";
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from urunBilgi where barkodNo like '"+ txtBarkodNoUrun.Text +"'", sqlConnection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                testBarkodNo = sqlDataReader["barkodNo"].ToString();
            }
            sqlConnection.Close();

            bool nullControl = false;
            foreach (Control item in groupUrun.Controls)
            {
                if (txtUrunAdiUrun.Text == "" && txtMiktariUrun.Text == "" && txtAlisFiyatiUrun.Text == "" && txtSatisFiyatiUrun.Text == "" && comboKDVUrun.SelectedItem == null && txtNetFiyatUrun.Text == "")
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
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from urunBilgi where urunAdi='"+ txtUrunAdiUrun.Text +"'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                //dataGetEkleme();
                MessageBox.Show("Ürün Başarıyla Silindi");
                
                foreach (Control item in groupUrun.Controls)
                {
                    if (item is TextBox)
                        item.Text = "";
                }
                comboKategoriUrun.SelectedItem = null;
                comboMarkaUrun.Items.Clear();
                comboKDVUrun.SelectedItem = null;
            }
        }

        private void btnGuncelleUrun_Click(object sender, EventArgs e)
        {
            bool nullControl = false;
            foreach (Control item in groupUrun.Controls)
            {
                if (txtUrunAdiUrun.Text == "" && txtMiktariUrun.Text == "" && txtAlisFiyatiUrun.Text == "" && txtSatisFiyatiUrun.Text == "" && comboKDVUrun.SelectedItem == null && txtNetFiyatUrun.Text == "")
                {
                    nullControl = true;
                }
            }
            if (nullControl)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı");
            }
            else if (txtUrunAdiUrun.Text.Length < 4)
            {
                MessageBox.Show("'Ürün Adı'nın uzunluğu en az 4 olmalıdır", "Uyarı");
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update urunBilgi set barkodNo=@barkodNo, kategori=@kategori, marka=@marka, miktari=@miktari, alisFiyati=@alisFiyati, satisFiyati=@satisFiyati, kdv=@kdv, netSatisFiyati=@netSatisFiyati where urunAdi=@urunAdi", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@barkodNo", txtBarkodNoUrun.Text);
                sqlCommand.Parameters.AddWithValue("@kategori", comboKategoriUrun.Text);
                sqlCommand.Parameters.AddWithValue("@marka", comboMarkaUrun.Text);
                sqlCommand.Parameters.AddWithValue("@urunAdi", txtUrunAdiUrun.Text);
                sqlCommand.Parameters.AddWithValue("@miktari", int.Parse(txtMiktariUrun.Text));
                sqlCommand.Parameters.AddWithValue("@alisFiyati", double.Parse(txtAlisFiyatiUrun.Text));
                sqlCommand.Parameters.AddWithValue("@satisFiyati", double.Parse(txtSatisFiyatiUrun.Text));
                sqlCommand.Parameters.AddWithValue("@kdv", int.Parse(comboKDVUrun.Text));
                sqlCommand.Parameters.AddWithValue("@netSatisFiyati", double.Parse(txtNetFiyatUrun.Text));
                sqlCommand.Parameters.AddWithValue("@tarih", DateTime.Now);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                //dataGetEkleme();
                MessageBox.Show("Ürün Başarıyla Güncellendi");

                foreach (Control item in groupUrun.Controls)
                {
                    if (item is TextBox)
                        item.Text = "";
                }
                comboKategoriUrun.SelectedItem = null;
                comboMarkaUrun.Items.Clear();
                comboKDVUrun.SelectedItem = null;
            }
        }

        private void dataUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (isUrunBilgi)
                {
                    DataGridViewRow row = this.dataUrun.Rows[e.RowIndex];
                    txtBarkodNoUrun.Text = row.Cells["Barkod No"].Value.ToString();
                    txtUrunAdiUrun.Text = row.Cells["Ürün Adı"].Value.ToString();
                    comboKategoriUrun.SelectedItem = row.Cells["Kategori"].Value.ToString();
                    comboMarkaUrun.SelectedItem = row.Cells["Marka"].Value.ToString();
                    txtMiktariUrun.Text = row.Cells["Miktar"].Value.ToString();
                    txtAlisFiyatiUrun.Text = row.Cells["Alış Fiyatı"].Value.ToString();
                    txtSatisFiyatiUrun.Text = row.Cells["Satış Fiyatı"].Value.ToString();
                    comboKDVUrun.SelectedItem = row.Cells["KDV"].Value.ToString();
                    txtNetFiyatUrun.Text = row.Cells["Net Satış Fiyatı"].Value.ToString();
                    gecerliUrun = true;
                }
                else
                {
                    DataGridViewRow row = this.dataUrun.Rows[e.RowIndex];
                    txtYanUrunBarkodNo.Text = row.Cells["Yan Barkod No"].Value.ToString();
                }
            }
        }

        private void dataKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataKategori.Rows[e.RowIndex];
                txtKategori.Text = row.Cells["Kategori"].Value.ToString();
                lblKategoritxt.Text = txtKategori.Text;
            }
        }

        private void dataMarka_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataMarka.Rows[e.RowIndex];
                comboKategori.SelectedItem = row.Cells["kategori"].Value.ToString();
                lblKategoricombo.Text = comboKategori.SelectedItem.ToString();
                txtMarka.Text = row.Cells["marka"].Value.ToString();
                lblMarkatxt.Text = txtMarka.Text;
            }
        }

        private void btnGuncelleKategori_Click(object sender, EventArgs e)
        {
            if (txtKategori.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı");
            }
            else if (txtKategori.Text.Length < 4)
            {
                MessageBox.Show("'Kategori'nin uzunluğu en az 4 olmalıdır", "Uyarı");
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update kategoriler set kategori=@kategori where kategori='"+ lblKategoritxt.Text +"'", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@kategori", txtKategori.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                kategoriGet();
                //dataGetEkleme();
                MessageBox.Show("Kategori Başarıyla Güncellendi");
            }
            txtKategori.Text = "";
        }

        private void btnGuncelleMarka_Click(object sender, EventArgs e)
        {
            if (comboKategori.Text == "" || txtMarka.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı");
            }
            else if (txtMarka.Text.Length < 4)
            {
                MessageBox.Show("'Marka'nın uzunluğu en az 4 olmalıdır", "Uyarı");
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update markalar set marka=@marka where marka='" + lblMarkatxt.Text + "' and kategori='"+ lblKategoricombo.Text +"' ", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@marka", txtMarka.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                //dataGetEkleme();
                MessageBox.Show("Marka Başarıyla Güncellendi");
            }
            comboKategori.Text = "";
            txtMarka.Text = "";
        }

        private void btnSilKategori_Click(object sender, EventArgs e)
        {
            if (txtKategori.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı");
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from kategoriler where kategori='" + txtKategori.Text + "'", sqlConnection);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                kategoriGet();
                //dataGetEkleme();
                MessageBox.Show("Kategori Başarıyla Silindi");
                txtKategori.Text = "";
            }
        }

        private void btnSilMarka_Click(object sender, EventArgs e)
        {
            if (lblKategoricombo.Text == "" || txtMarka.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı");
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from markalar where kategori='"+ lblKategoricombo.Text + "' and marka='"+ txtMarka.Text +"'", sqlConnection);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                //dataGetEkleme();
                MessageBox.Show("Marka Başarıyla Silindi");
                comboKategori.SelectedItem = null;
                lblKategoricombo.Text = "";
                txtMarka.Text = "";
            }
        }

        private void txtMiktariUrun_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarkodNoUrun_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMiktariUrun_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAlisFiyatiUrun_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != ',' || !Decimal.TryParse(txtAlisFiyatiUrun.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void txtSatisFiyatiUrun_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != ',' || !Decimal.TryParse(txtSatisFiyatiUrun.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void txtNetFiyatUrun_TextChanged(object sender, EventArgs e)
        {
            if (txtNetFiyatUrun.Focused)
            {
                if (txtNetFiyatUrun.Text == "")
                {
                    txtSatisFiyatiUrun.Text = "";
                }
                else if (comboKDVUrun.Text == "0")
                {
                    txtSatisFiyatiUrun.Text = txtNetFiyatUrun.Text;
                }
                else if (comboKDVUrun.Text != "" && comboKDVUrun.Text != "0")
                {
                    txtSatisFiyatiUrun.Text = ((double.Parse(txtNetFiyatUrun.Text) / (100 + double.Parse(comboKDVUrun.Text))) * 100).ToString("0.00");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboKDVUrun.Text == "")
            {
                txtNetFiyatUrun.Text = "";
            }
            else if (txtSatisFiyatiUrun.Text != "")
            {
                txtNetFiyatUrun.Text = (((double.Parse(txtSatisFiyatiUrun.Text) / 100) * double.Parse(comboKDVUrun.Text)) + double.Parse(txtSatisFiyatiUrun.Text)).ToString();
            }
        }

        private void txtSatisFiyatiUrun_TextChanged(object sender, EventArgs e)
        {
            if (txtSatisFiyatiUrun.Focused)
            {
                if (txtSatisFiyatiUrun.Text == "")
                {
                    txtNetFiyatUrun.Text = "";
                }
                else if (comboKDVUrun.Text == "0")
                {
                    txtNetFiyatUrun.Text = txtSatisFiyatiUrun.Text;
                }
                else if (comboKDVUrun.Text != "")
                {
                    txtNetFiyatUrun.Text = (((double.Parse(txtSatisFiyatiUrun.Text) / 100) * double.Parse(comboKDVUrun.Text)) + double.Parse(txtSatisFiyatiUrun.Text)).ToString("0.00");
                }
            }
        }

        private void groupUrun_Enter(object sender, EventArgs e)
        {

        }

        private void cbKDVDahil_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbKDVDahil.Checked)
            {
                txtSatisFiyatiUrun.Enabled = true;
                txtNetFiyatUrun.Enabled = false;
            }
            else
            {
                txtSatisFiyatiUrun.Enabled = false;
                txtNetFiyatUrun.Enabled = true;
            }
        }

        private void txtNetFiyatUrun_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != ',' || !Decimal.TryParse(txtNetFiyatUrun.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void txtKategori_TextChanged(object sender, EventArgs e)
        {
            DataTable searchTable = new DataTable();
            if (txtKategori.Text.Length > 3)
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select kategori as '" + "Kategori" + "' from kategoriler where kategori like '%" + txtKategori.Text + "%'", sqlConnection);
                sqlDataAdapter.Fill(searchTable);
                sqlConnection.Close();
            }
            else
            {
                searchTable.Rows.Clear();
            }
            dataKategori.DataSource = searchTable;
        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {
            DataTable searchTable = new DataTable();
            if (txtMarka.Text.Length > 3)
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select kategori as '" + "Kategori" + "', marka as '" + "Marka" + "' from markalar where kategori='" + comboKategori.Text + "' and marka like '%" + txtMarka.Text + "%'", sqlConnection);
                sqlDataAdapter.Fill(searchTable);
                sqlConnection.Close();
            }
            else
            {
                searchTable.Rows.Clear();
            }
            dataMarka.DataSource = searchTable;
        }

        private void btnEkleYanBarkod_Click(object sender, EventArgs e)
        {
            bool yanBarkodIsNew = true;

            isNew = true;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from yanBarkodlar", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if ((txtYanUrunBarkodNo.Text).ToLower() == (sqlDataReader["yanBarkodNo"].ToString()).ToLower())
                {
                    isNew = false;
                }
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("select barkodNo from urunBilgi", sqlConnection);
            SqlDataReader sqlDataReader1 = sqlCommand2.ExecuteReader();
            while (sqlDataReader1.Read())
            {
                if ((txtYanUrunBarkodNo.Text).ToLower() == (sqlDataReader1["barkodNo"].ToString()).ToLower())
                {
                    yanBarkodIsNew = false;
                }
            }
            sqlConnection.Close();

            if (txtYanUrunBarkodNo.Text == "")
            {
                MessageBox.Show("Yan ürünün 'Barkod No'sunu giriniz.", "Uyarı");
            }
            else if (txtBarkodNoUrun.Text == "")
            {
                MessageBox.Show("Ana ürünün 'Barkod No'sunu giriniz.", "Uyarı");
            }
            else if (!gecerliUrun)
            {
                MessageBox.Show("Ana ürünün 'Barkod No'su geçersiz!", "Uyarı");
            }
            else if (!isNew)
            {
                MessageBox.Show("Girmeye çalıştığınız yan ürün, zaten bir ana ürün ile bağlantılı olarak sistemde kayıtlı.", "Uyarı");
            }
            else if (!yanBarkodIsNew)
            {
                MessageBox.Show("Girmeye çalıştığınız yan ürünün, zaten bir ana ürün olarak kaydı bulunuyor.", "Uyarı");
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand1 = new SqlCommand("insert into yanBarkodlar(anaBarkodNo, yanBarkodNo) values(@anaBarkodNo, @yanBarkodNo)", sqlConnection);
                sqlCommand1.Parameters.AddWithValue("@anaBarkodNo", txtBarkodNoUrun.Text);
                sqlCommand1.Parameters.AddWithValue("@yanBarkodNo", txtYanUrunBarkodNo.Text);
                sqlCommand1.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Yan Ürün Başarıyla Eklendi");

                txtYanUrunBarkodNo.Text = "";
            }
        }

        private void txtYanUrunBarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //if (isUrunBilgi)
            //{
            //    sqlConnection.Open();
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select anaBarkodNo as '" + "Ana Barkod No" + "', yanBarkodNo as '" + "Yan Barkod No" + "' from yanBarkodlar", sqlConnection);
            //    sqlDataAdapter.Fill(searchTable);
            //    sqlConnection.Close();
            //    isUrunBilgi = false;
            //}
            //else
            //{
            //    searchTable.Rows.Clear();
            //}

            
        }

        bool isUrunBilgi = false;

        private void txtYanUrunBarkodNo_TextChanged(object sender, EventArgs e)
        {
            DataTable searchTable = new DataTable();
            if (txtYanUrunBarkodNo.Text.Length > 3)
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select anaBarkodNo as '" + "Ana Barkod No" + "', yanBarkodNo as '" + "Yan Barkod No" + "' from yanBarkodlar where yanBarkodNo like '%" + txtYanUrunBarkodNo.Text + "%'", sqlConnection);
                sqlDataAdapter.Fill(searchTable);
                sqlConnection.Close();
                isUrunBilgi = false;
            }
            else
            {
                searchTable.Rows.Clear();
            }
            dataUrun.DataSource = searchTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string testBarkodNo = "";
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from yanBarkodlar where yanBarkodNo like '" + txtYanUrunBarkodNo.Text + "'", sqlConnection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                testBarkodNo = sqlDataReader["yanBarkodNo"].ToString();
            }
            sqlConnection.Close();

            if (txtYanUrunBarkodNo.Text == "")
            {
                MessageBox.Show("Lütfen bir barkod no giriniz", "Uyarı");
            }
            else if (testBarkodNo == "")
            {
                MessageBox.Show("Girdiğiniz barkod no geçerli değil", "Uyarı");
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from yanBarkodlar where yanBarkodNo='" + txtYanUrunBarkodNo.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Ürün Başarıyla Silindi");

                txtYanUrunBarkodNo.Text = "";
            }
        }
    }
}
