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

namespace Stok_Takip_Satis
{
    public partial class frmStokEnvanter : Form
    {
        public frmStokEnvanter()
        {
            InitializeComponent();
        }

        bool gecerliUrun;
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\StokTakip.mdf'");
        SqlConnection sqlConnection = new SqlConnection("Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        private void excelYazdir()
        {
            int i, j, k = 0;

            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            application.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = application.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            for (i = 0; i < dataStok.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1];
                range.Value2 = dataStok.Columns[i].HeaderText;
            }
            for (j = 0; j < dataStok.Columns.Count; j++)
            {
                for (k = 0; k < dataStok.Rows.Count; k++)
                {
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 2, j + 1];
                    range.Value2 = dataStok[j, k].Value;
                }
            }
            Microsoft.Office.Interop.Excel.Range range1 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 2, 1];
            range1.Value2 = "Toplam Stok Gideri=";
            Microsoft.Office.Interop.Excel.Range range2 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 2, 2];
            range2.Value2 = double.Parse(lblStokBedeliSayisi.Text);
            Microsoft.Office.Interop.Excel.Range range3 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 3, 1];
            range3.Value2 = "Toplam Net Kar=";
            Microsoft.Office.Interop.Excel.Range range4 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 3, 2];
            range4.Value2 = double.Parse(lblKarBedeliSayisi.Text);
            Microsoft.Office.Interop.Excel.Range range5 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 4, 1];
            range5.Value2 = "Toplam KDV=";
            Microsoft.Office.Interop.Excel.Range range6 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 4, 2];
            range6.Value2 = double.Parse(lblKDVTutariSayisi.Text);

            worksheet.Columns.AutoFit();
            try
            {
                workbook.SaveAs("Stok Listesi (" + DateTime.Today.ToString("yyyy.MM.dd") + ").xlsx");
            }
            catch (Exception)
            {
            }
        }

        private void karHesapla()
        {
            double alisToplam = 0;
            double satisToplam = 0;
            double netSatisToplam = 0;

            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("select alisFiyati, satisFiyati, netSatisFiyati, miktari from urunBilgi", sqlConnection);
            SqlDataReader dataReader1 = sqlCommand1.ExecuteReader();
            while (dataReader1.Read())
            {
                alisToplam += (double.Parse(dataReader1["alisFiyati"].ToString())) * (double.Parse(dataReader1["miktari"].ToString()));
                satisToplam += (double.Parse(dataReader1["satisFiyati"].ToString())) * (double.Parse(dataReader1["miktari"].ToString()));
                netSatisToplam += (double.Parse(dataReader1["netSatisFiyati"].ToString())) * (double.Parse(dataReader1["miktari"].ToString()));
            }
            sqlConnection.Close();

            lblStokBedeliSayisi.Text = alisToplam.ToString("0.00");
            lblKarBedeliSayisi.Text = (satisToplam - alisToplam).ToString("0.00");
            lblKDVTutariSayisi.Text = (netSatisToplam - satisToplam).ToString("0.00");
        }

        private void dataGet()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select top 30 barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', tarih as '" + "Tarih" + "' From urunBilgi", sqlConnection);
            sqlConnection.Open();
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "urunBilgi");
            dataStok.DataSource = dataSet.Tables["urunBilgi"];
            sqlConnection.Close();
        }

        private void frmStokEnvanter_Load(object sender, EventArgs e)
        {
            //dataGet();
            karHesapla();
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataStok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    }*/ //Burada txtBarkodNo.Text 'i de sildiğinden dolayı barkod ile seri okuma yapılacak ise bu kod kullanılmalı

                    txtUrunAdi.Text = "";
                    txtKategori.Text = "";
                    txtMarka.Text = "";
                    txtMiktari.Text = "";
                    txtAlisFiyati.Text = "";
                    txtSatisFiyati.Text = "";
                    txtKDV.Text = "";
                    txtNetFiyat.Text = "";
                    lblTopMiktarSayisi.Text = "0";
                    gecerliUrun = false;
                    txtUrunAdi.Enabled = true;
                    txtMiktari.Enabled = false;
                }
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from urunBilgi where barkodNo like '" + txtBarkodNo.Text + "'", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    txtUrunAdi.Text = sqlDataReader["urunAdi"].ToString();
                    txtKategori.Text = sqlDataReader["kategori"].ToString();
                    txtMarka.Text = sqlDataReader["marka"].ToString();
                    txtMiktari.Text = "1";
                    txtAlisFiyati.Text = sqlDataReader["alisFiyati"].ToString();
                    txtSatisFiyati.Text = sqlDataReader["satisFiyati"].ToString();
                    txtKDV.Text = sqlDataReader["kdv"].ToString();
                    txtNetFiyat.Text = sqlDataReader["netSatisFiyati"].ToString();
                    lblTopMiktarSayisi.Text = sqlDataReader["miktari"].ToString();
                    gecerliUrun = true;
                    txtUrunAdi.Enabled = false;
                    txtMiktari.Enabled = true;
                }
                sqlConnection.Close();
            }
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
                    }*/ //Burada txtBarkodNo.Text 'i de sildiğinden dolayı barkod ile seri okuma yapılacak ise bu kod kullanılmalı

                    txtBarkodNo.Text = "";
                    txtKategori.Text = "";
                    txtMarka.Text = "";
                    txtMiktari.Text = "";
                    txtAlisFiyati.Text = "";
                    txtSatisFiyati.Text = "";
                    txtKDV.Text = "";
                    txtNetFiyat.Text = "";
                    lblTopMiktarSayisi.Text = "0";
                    gecerliUrun = false;
                    txtBarkodNo.Enabled = true;
                    txtMiktari.Enabled = false;
                }
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from urunBilgi where urunAdi like '" + txtUrunAdi.Text + "'", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    txtBarkodNo.Text = sqlDataReader["barkodNo"].ToString();
                    txtKategori.Text = sqlDataReader["kategori"].ToString();
                    txtMarka.Text = sqlDataReader["marka"].ToString();
                    txtMiktari.Text = "1";
                    txtAlisFiyati.Text = sqlDataReader["alisFiyati"].ToString();
                    txtSatisFiyati.Text = sqlDataReader["satisFiyati"].ToString();
                    txtKDV.Text = sqlDataReader["kdv"].ToString();
                    txtNetFiyat.Text = sqlDataReader["netSatisFiyati"].ToString();
                    lblTopMiktarSayisi.Text = sqlDataReader["miktari"].ToString();
                    gecerliUrun = true;
                    txtBarkodNo.Enabled = false;
                    txtMiktari.Enabled = true;
                }
                sqlConnection.Close();
            }
        }

        private void dataStok_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!txtMiktari.Enabled)
            {
                MessageBox.Show("Lütfen var olan bir ürün giriniz!");
            }
            else if (int.Parse(txtMiktari.Text) > 0)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update urunBilgi set miktari=miktari+'" + int.Parse(txtMiktari.Text) + "' where barkodNo='" + txtBarkodNo.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                foreach (Control item in Controls)
                {
                    if (item is TextBox || item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
                lblTopMiktarSayisi.Text = "0";
                txtBarkodNo.Enabled = true;
                txtUrunAdi.Enabled = true;
                txtMiktari.Enabled = false;
                //dataGet();
                karHesapla();
                MessageBox.Show("Ekleme işlemi başarılı");
            }
            else if (txtMiktari.Text == "0")
            {
                MessageBox.Show("Eklemek istediğiniz miktar 0'dan yüksek olmalıdır");
            }
            else
            {
                MessageBox.Show("Geçersiz işlem!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtMiktari.Text == "")
            {
                MessageBox.Show("Lütfen var olan bir ürün giriniz!");
            }
            else if (int.Parse(lblTopMiktarSayisi.Text) < int.Parse(txtMiktari.Text))
            {
                MessageBox.Show("Silmek istediğiniz miktar, stok miktarından daha fazla olamaz!");
            }
            else if (int.Parse(lblTopMiktarSayisi.Text) >= int.Parse(txtMiktari.Text) && txtMiktari.Text != "0")
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update urunBilgi set miktari=miktari-'" + int.Parse(txtMiktari.Text) + "' where barkodNo='" + txtBarkodNo.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                foreach (Control item in Controls)
                {
                    if (item is TextBox || item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
                lblTopMiktarSayisi.Text = "0";
                txtBarkodNo.Enabled = true;
                txtUrunAdi.Enabled = true;
                txtMiktari.Enabled = false;
                //dataGet();
                karHesapla();
                MessageBox.Show("Silme işlemi başarılı");
            }
            else if (txtMiktari.Text == "0")
            {
                MessageBox.Show("Silmek istediğiniz miktar 0'dan yüksek olmalıdır");
            }
            else
            {
                MessageBox.Show("Geçersiz işlem!");
            }
        }

        private void txtMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataStok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataStok.Rows[e.RowIndex];
                txtBarkodNo.Text = row.Cells["Barkod No"].Value.ToString();
                txtUrunAdi.Text = row.Cells["Ürün Adı"].Value.ToString();
                txtKategori.Text = row.Cells["Kategori"].Value.ToString();
                txtMarka.Text = row.Cells["Barkod No"].Value.ToString();
                txtMiktari.Enabled = true;
                txtMiktari.Text = "1";
                txtAlisFiyati.Text = row.Cells["Alış Fiyatı"].Value.ToString();
                txtSatisFiyati.Text = row.Cells["Satış Fiyatı"].Value.ToString();
                txtKDV.Text = row.Cells["KDV"].Value.ToString();
                txtNetFiyat.Text = row.Cells["Net Satış Fiyatı"].Value.ToString();
                lblTopMiktarSayisi.Text = row.Cells["Miktar"].Value.ToString();
                gecerliUrun = true;
                txtBarkodNo.Enabled = true;
                txtUrunAdi.Enabled = true;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
            lblTopMiktarSayisi.Text = "0";
            txtMiktari.Enabled = false;
            txtBarkodNo.Enabled = true;
            txtUrunAdi.Enabled = true;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataTable searchTable = new DataTable();
            if (txtAra.Text.Length > 3)
            {
                sqlConnection.Open();
                if (comboAra.Text == "Barkod Numarasına Göre")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', tarih as '" + "Tarih" + "' from urunBilgi where barkodNo like '%" + txtAra.Text + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                }
                else if (comboAra.Text == "Ürün Adına Göre")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', tarih as '" + "Tarih" + "' from urunBilgi where urunAdi like '%" + txtAra.Text + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                }
                else if (comboAra.Text == "Kategoriye Göre")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', tarih as '" + "Tarih" + "' from urunBilgi where kategori like '%" + txtAra.Text + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                }
                else if (comboAra.Text == "Markaya Göre")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', tarih as '" + "Tarih" + "' from urunBilgi where marka like '%" + txtAra.Text + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                }
                sqlConnection.Close();
            }
            else
            {
                searchTable.Rows.Clear();
            }
            dataStok.DataSource = searchTable;
        }

        private void txtBarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            dataGet();
            excelYazdir();
            DataTable searchTable = new DataTable();
            searchTable.Rows.Clear();
            dataStok.DataSource = searchTable;
        }
    }
}
