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
    public partial class frmSatisListesi : Form
    {
        public frmSatisListesi()
        {
            InitializeComponent();
        }

        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\StokTakip.mdf'");
        SqlConnection sqlConnection = new SqlConnection("Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");


        private void dataSatisIslemleri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void excelYazdir()
        {
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            application.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = application.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            for (int i = 0; i < dataSatisListesi.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1];
                range.Value2 = dataSatisListesi.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataSatisListesi.Columns.Count; i++)
            {
                for (int j = 0; j < dataSatisListesi.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[j + 2, i + 1];
                    range.Value2 = dataSatisListesi[i, j].Value;
                }
            }

            worksheet.Columns.AutoFit();

            if (comboListeler.Text == "Geçmiş Satışlar")
            {
                try
                {
                    workbook.SaveAs("Geçmiş Satışlar (" + DateTime.Today.ToString("yyyy.MM.dd") + ").xlsx");
                }
                catch (Exception)
                {
                }
            }
            else
            {
                try
                {
                    workbook.SaveAs("Geçmiş İkramlar (" + DateTime.Today.ToString("yyyy.MM.dd") + ").xlsx");
                }
                catch (Exception)
                {
                }
            }
        }

        private void satilanMiktarGet()
        {
            ArrayList geciciBarkodNo = new ArrayList();
            ArrayList geciciMiktar = new ArrayList();
            ArrayList geciciSatilanMiktar = new ArrayList();
            string geciciSatilanMiktar2 = "0";
            int i = 0;

            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("update gecmisSatislar set satilanMiktar='" + "0" + "'", sqlConnection);
            sqlCommand2.ExecuteNonQuery();
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("select * from gecmisSatislar", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand3.ExecuteReader();
            while (sqlDataReader.Read())
            {
                geciciMiktar.Add(sqlDataReader["miktari"].ToString());
                geciciBarkodNo.Add(sqlDataReader["barkodNo"].ToString());
                i++;
            }
            sqlConnection.Close();

            for (int j = 0; j < i; j++)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand4 = new SqlCommand("select * from gecmisSatislar where barkodNo='"+ geciciBarkodNo[j].ToString() +"'", sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand4.ExecuteReader();
                while (sqlDataReader1.Read())
                {
                    geciciSatilanMiktar2 = (sqlDataReader1["satilanMiktar"].ToString());
                }
                sqlConnection.Close();
                
                sqlConnection.Open();
                SqlCommand sqlCommand1 = new SqlCommand("update gecmisSatislar set satilanMiktar=@satilanMiktar where barkodNo='" + geciciBarkodNo[j].ToString() + "'", sqlConnection);
                sqlCommand1.Parameters.AddWithValue("@satilanMiktar", (int.Parse(geciciSatilanMiktar2) + int.Parse(geciciMiktar[j].ToString())).ToString());
                sqlCommand1.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        private void verilenMiktarGet()
        {
            ArrayList geciciBarkodNo = new ArrayList();
            ArrayList geciciMiktar = new ArrayList();
            ArrayList geciciVerilenMiktar = new ArrayList();
            string geciciVerilenMiktar2 = "0";
            int i = 0;

            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("update gecmisIkramlar set verilenMiktar='" + "0" + "'", sqlConnection);
            sqlCommand2.ExecuteNonQuery();
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("select * from gecmisIkramlar", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand3.ExecuteReader();
            while (sqlDataReader.Read())
            {
                geciciMiktar.Add(sqlDataReader["miktari"].ToString());
                geciciBarkodNo.Add(sqlDataReader["barkodNo"].ToString());
                i++;
            }
            sqlConnection.Close();

            for (int j = 0; j < i; j++)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand4 = new SqlCommand("select * from gecmisIkramlar where barkodNo='" + geciciBarkodNo[j].ToString() + "'", sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand4.ExecuteReader();
                while (sqlDataReader1.Read())
                {
                    geciciVerilenMiktar2 = (sqlDataReader1["verilenMiktar"].ToString());
                }
                sqlConnection.Close();

                sqlConnection.Open();
                SqlCommand sqlCommand1 = new SqlCommand("update gecmisIkramlar set verilenMiktar=@verilenMiktar where barkodNo='" + geciciBarkodNo[j].ToString() + "'", sqlConnection);
                sqlCommand1.Parameters.AddWithValue("@verilenMiktar", (int.Parse(geciciVerilenMiktar2) + int.Parse(geciciMiktar[j].ToString())).ToString());
                sqlCommand1.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        private void fisNoGet()
        {
            ArrayList oncekiFisNo = new ArrayList();
            int sayac = 0;

            sqlConnection.Open();
            SqlCommand sqlCommand4 = new SqlCommand("select * from gecmisSatislar", sqlConnection);
            SqlDataReader sqlDataReader3 = sqlCommand4.ExecuteReader();
            while (sqlDataReader3.Read())
            {
                oncekiFisNo.Add(sqlDataReader3["fisNo"].ToString());
                sayac++;
            }
            sqlConnection.Close();

            if (sayac == 0)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into gecmisSatislar select '" + 0 + "', barkodNo, urunAdi, kategori, marka, miktari, alisFiyati, satisFiyati, '" + "0" + "', '" + (DateTime.Now).ToString() + "' from urunSatis", sqlConnection); //değişecek txtmiktar.text
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into gecmisSatislar select '" + (int.Parse(oncekiFisNo[sayac - 1].ToString()) + 1) + "', barkodNo, urunAdi, kategori, marka, miktari, alisFiyati, satisFiyati, '" + "0" + "', '" + (DateTime.Now).ToString() + "' from urunSatis", sqlConnection); //değişecek txtmiktar.text
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        private void dataGecmisSatislarGet()
        {
            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("select id as '" + "ID" + "', fisNo as '" + "Fiş No" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', satisSekli as '" + "Ödeme Türü" + "', iskonto as '" + "İskonto" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', satilanMiktar as '" + "Satılan Miktar" + "', tarih as '" + "Tarih" + "' from gecmisSatislar where tarih like '%" + dateTimePicker1.Value.ToString("yyyy.MM.dd") + "%'", sqlConnection);
            sqlDataAdapter2.Fill(dataSet, "gecmisSatislar");
            dataSatisListesi.DataSource = dataSet.Tables["gecmisSatislar"];
            sqlConnection.Close();
        }

        private void dataGecmisIkramlarGet()
        {
            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("select id as '" + "ID" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', verilenMiktar as '" + "Verilen Miktar" + "', tarih as '" + "Tarih" + "' from gecmisIkramlar where tarih like '%" + dateTimePicker1.Value.ToString("yyyy.MM.dd") + "%'", sqlConnection);
            sqlDataAdapter2.Fill(dataSet, "gecmisIkramlar");
            dataSatisListesi.DataSource = dataSet.Tables["gecmisIkramlar"];
            sqlConnection.Close();
        }

        private void dataClear()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from gecmisSatisIptal", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void dataGet()
        {
            if (comboListeler.Text == "Geçmiş Satışlar")
            {
                DataTable searchTable = new DataTable();
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id as '" + "ID" + "', fisNo as '" + "Fiş No" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', satisSekli as '" + "Ödeme Türü" + "', iskonto as '" + "İskonto" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', satilanMiktar as '" + "Satılan Miktar" + "', tarih as '" + "Tarih" + "' from gecmisSatislar", sqlConnection);
                sqlDataAdapter.Fill(searchTable);
                dataSatisListesi.DataSource = searchTable;
                sqlConnection.Close();
            }
            else
            {
                DataTable searchTable = new DataTable();
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id as '" + "ID" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', verilenMiktar as '" + "Verilen Miktar" + "', tarih as '" + "Tarih" + "' from gecmisIkramlar", sqlConnection);
                sqlDataAdapter.Fill(searchTable);
                dataSatisListesi.DataSource = searchTable;
                sqlConnection.Close();
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (comboListeler.Text == "Geçmiş Satışlar")
            {
                DataTable searchTable = new DataTable();
                sqlConnection.Open();
                if (comboAra.Text == "Fiş Numarasına Göre")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id as '" + "ID" + "', fisNo as '" + "Fiş No" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', satisSekli as '" + "Ödeme Türü" + "', iskonto as '" + "İskonto" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', satilanMiktar as '" + "Satılan Miktar" + "', tarih as '" + "Tarih" + "' from gecmisSatislar where fisNo like '%" + txtAra.Text + "%' and tarih like '%" + dateTimePicker1.Value.ToString("yyyy.MM.dd") + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                    dataSatisListesi.DataSource = searchTable;
                }
                else if (comboAra.Text == "Barkod Numarasına Göre")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id as '" + "ID" + "', fisNo as '" + "Fiş No" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', satisSekli as '" + "Ödeme Türü" + "', iskonto as '" + "İskonto" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', satilanMiktar as '" + "Satılan Miktar" + "', tarih as '" + "Tarih" + "' from gecmisSatislar where barkodNo like '%" + txtAra.Text + "%' and tarih like '%" + dateTimePicker1.Value.ToString("yyyy.MM.dd") + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                    dataSatisListesi.DataSource = searchTable;
                }
                else if (comboAra.Text == "Ürün Adına Göre")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id as '" + "ID" + "', fisNo as '" + "Fiş No" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', satisSekli as '" + "Ödeme Türü" + "', iskonto as '" + "İskonto" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', satilanMiktar as '" + "Satılan Miktar" + "', tarih as '" + "Tarih" + "' from gecmisSatislar where urunAdi like '%" + txtAra.Text + "%' and tarih like '%" + dateTimePicker1.Value.ToString("yyyy.MM.dd") + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                    dataSatisListesi.DataSource = searchTable;
                }
                else if (comboAra.Text == "Kategoriye Göre")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id as '" + "ID" + "', fisNo as '" + "Fiş No" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', satisSekli as '" + "Ödeme Türü" + "', iskonto as '" + "İskonto" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', satilanMiktar as '" + "Satılan Miktar" + "', tarih as '" + "Tarih" + "' from gecmisSatislar where kategori like '%" + txtAra.Text + "%' and tarih like '%" + dateTimePicker1.Value.ToString("yyyy.MM.dd") + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                    dataSatisListesi.DataSource = searchTable;
                }
                else if (comboAra.Text == "Markaya Göre")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id as '" + "ID" + "', fisNo as '" + "Fiş No" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', satisSekli as '" + "Ödeme Türü" + "', iskonto as '" + "İskonto" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', satilanMiktar as '" + "Satılan Miktar" + "', tarih as '" + "Tarih" + "' from gecmisSatislar where marka like '%" + txtAra.Text + "%' and tarih like '%" + dateTimePicker1.Value.ToString("yyyy.MM.dd") + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                    dataSatisListesi.DataSource = searchTable;
                }
                sqlConnection.Close();
            }
            else
            {
                DataTable searchTable = new DataTable();
                sqlConnection.Open();
                if (comboAra.Text == "Barkod Numarasına Göre")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id as '" + "ID" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', verilenMiktar as '" + "Verilen Miktar" + "', tarih as '" + "Tarih" + "' from gecmisIkramlar where barkodNo like '%" + txtAra.Text + "%' and tarih like '%" + dateTimePicker1.Value.ToString("yyyy.MM.dd") + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                    dataSatisListesi.DataSource = searchTable;
                }
                else if (comboAra.Text == "Ürün Adına Göre")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id as '" + "ID" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', verilenMiktar as '" + "Verilen Miktar" + "', tarih as '" + "Tarih" + "' from gecmisIkramlar where urunAdi like '%" + txtAra.Text + "%' and tarih like '%" + dateTimePicker1.Value.ToString("yyyy.MM.dd") + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                    dataSatisListesi.DataSource = searchTable;
                }
                else if (comboAra.Text == "Kategoriye Göre")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id as '" + "ID" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', verilenMiktar as '" + "Verilen Miktar" + "', tarih as '" + "Tarih" + "' from gecmisIkramlar where kategori like '%" + txtAra.Text + "%' and tarih like '%" + dateTimePicker1.Value.ToString("yyyy.MM.dd") + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                    dataSatisListesi.DataSource = searchTable;
                }
                else if (comboAra.Text == "Markaya Göre")
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id as '" + "ID" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', verilenMiktar as '" + "Verilen Miktar" + "', tarih as '" + "Tarih" + "' from gecmisIkramlar where marka like '%" + txtAra.Text + "%' and tarih like '%" + dateTimePicker1.Value.ToString("yyyy.MM.dd") + "%'", sqlConnection);
                    sqlDataAdapter.Fill(searchTable);
                    dataSatisListesi.DataSource = searchTable;
                }
                sqlConnection.Close();
            }
        }

        private void frmSatisListesi_Load(object sender, EventArgs e)
        {
            comboListeler.SelectedItem = "Geçmiş Satışlar";
            satilanMiktarGet();
            dataGecmisSatislarGet();
        }

        private void dataSatisListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (comboListeler.Text == "Geçmiş Satışlar")
                {
                    string satisIptalGroup2 = "";
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = this.dataSatisListesi.Rows[e.RowIndex];
                        satisIptalGroup2 = row.Cells["tarih"].Value.ToString();
                    }

                    dataClear();

                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("insert into gecmisSatisIptal select id, fisNo, barkodNo, urunAdi, kategori, marka, miktari, alisFiyati, satisFiyati, satisSekli, iskonto, kdv, netSatisFiyati, '" + 0 + "', tarih from gecmisSatislar where tarih='" + satisIptalGroup2 + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    frmSatisIptal frmIptal = new frmSatisIptal();
                    frmIptal.ShowDialog();
                }
                else
                {
                    string satisIptalGroup2 = "";
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = this.dataSatisListesi.Rows[e.RowIndex];
                        satisIptalGroup2 = row.Cells["tarih"].Value.ToString();
                    }

                    dataClear();

                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("insert into gecmisSatisIptal select id, '" + 0 + "', barkodNo, urunAdi, kategori, marka, miktari, alisFiyati, satisFiyati, '" + "-" + "', '" + 0 + "', kdv, netSatisFiyati, '" + 0 + "', tarih from gecmisIkramlar where tarih='" + satisIptalGroup2 + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    frmSatisIptal frmIptal = new frmSatisIptal();
                    frmIptal.ShowDialog();
                }
            }
        }

        private void dataSatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            dataGet();
            excelYazdir();
            DataTable searchTable = new DataTable();
            searchTable.Rows.Clear();
            dataSatisListesi.DataSource = searchTable;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            if (comboListeler.Text == "Geçmiş Satışlar")
            {
                satilanMiktarGet();
                dataGecmisSatislarGet();
            }
            else
            {
                verilenMiktarGet();
                dataGecmisIkramlarGet();
            }
        }

        private void comboListeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataSatisListesi.DataSource = null;
            if (comboListeler.Text == "Geçmiş Satışlar")
            {
                satilanMiktarGet();
                dataGecmisSatislarGet();
            }
            else
            {
                verilenMiktarGet();
                dataGecmisIkramlarGet();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataSatisListesi.DataSource = null;
            if (comboListeler.Text == "Geçmiş Satışlar")
            {
                satilanMiktarGet();
                dataGecmisSatislarGet();
            }
            else
            {
                verilenMiktarGet();
                dataGecmisIkramlarGet();
            }
        }

        private void btnTarihiYazdir_Click(object sender, EventArgs e)
        {
            excelYazdir();
        }
    }
}
