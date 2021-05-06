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
    public partial class frmKarRaporu : Form
    {
        public frmKarRaporu()
        {
            InitializeComponent();
        }

        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\StokTakip.mdf'");
        SqlConnection sqlConnection = new SqlConnection("Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        private void dataSatisGet()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id as '" + "ID" + "', fisNo as '" + "Fiş No" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', satisSekli as '" + "Ödeme Türü" + "', iskonto as '" + "İskonto" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', satilanMiktar as '" + "Satılan Miktar" + "', tarih as '" + "Tarih" + "' From gecmisSatislar where tarih between '" + dateTimePicker1.Value.Date.ToString("yyyy.MM.dd HH:mm:ss") + "' and'" + dateTimePicker2.Value.Date.AddDays(1).ToString("yyyy.MM.dd HH:mm:ss") + "'", sqlConnection);
            sqlConnection.Open();
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "gecmisSatislar");
            dataKarRaporu.DataSource = dataSet.Tables["gecmisSatislar"];
            sqlConnection.Close();
        }

        private void excelYazdir()
        {
            int i, j, k = 0;

            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            application.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = application.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            for (i = 0; i < dataKarRaporu.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1];
                range.Value2 = dataKarRaporu.Columns[i].HeaderText;
            }
            for (j = 0; j < dataKarRaporu.Columns.Count; j++)
            {
                for (k = 0; k < dataKarRaporu.Rows.Count; k++)
                {
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 2, j + 1];
                    range.Value2 = dataKarRaporu[j, k].Value;
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
                workbook.SaveAs("Kar Raporu (" + DateTime.Today.ToString("yyyy.MM.dd") + ").xlsx");
            }
            catch (Exception)
            {
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmKarRaporu_Load(object sender, EventArgs e)
        {
            dataSatisGet();
        }

        private void dataKarRaporu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string geciciAlisFiyati = "";
                string geciciSatisFiyati = "";
                string geciciNetSatisFiyati = "";
                string geciciMiktari = "";
                string stokBedeli = "";
                string kar = "";
                string kdv = "";

                DataGridViewRow row = this.dataKarRaporu.Rows[e.RowIndex];

                geciciAlisFiyati = row.Cells["Alış Fiyatı"].Value.ToString();
                geciciSatisFiyati = row.Cells["Satış Fiyatı"].Value.ToString();
                geciciNetSatisFiyati = row.Cells["Net Satış Fiyatı"].Value.ToString();
                geciciMiktari = row.Cells["Miktar"].Value.ToString();

                stokBedeli = (double.Parse(geciciAlisFiyati) * double.Parse(geciciMiktari)).ToString("0.00");
                kar = ((double.Parse(geciciSatisFiyati) - double.Parse(geciciAlisFiyati)) * double.Parse(geciciMiktari)).ToString("0.00");
                kdv = ((double.Parse(geciciNetSatisFiyati) - double.Parse(geciciSatisFiyati)) * double.Parse(geciciMiktari)).ToString("0.00");

                lblStokBedeliSayisi.Text = stokBedeli;
                lblKarBedeliSayisi.Text = kar;
                lblKDVTutariSayisi.Text = kdv;
            }
        }

        private void karHesapla()
        {
            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double alisToplam = 0;
            double satisToplam = 0;
            double netSatisToplam = 0;

            dataKarRaporu.DataSource = null;

            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("select distinct * from gecmisSatislar where tarih between '" + dateTimePicker1.Value.Date.ToString("yyyy.MM.dd HH:mm:ss") + "' and'" + dateTimePicker2.Value.Date.AddDays(1).ToString("yyyy.MM.dd HH:mm:ss") + "'", sqlConnection);
            SqlDataReader dataReader1 = sqlCommand1.ExecuteReader();
            while (dataReader1.Read())
            {
                alisToplam += (double.Parse(dataReader1["alisFiyati"].ToString())) * (double.Parse(dataReader1["miktari"].ToString()));
                satisToplam += (double.Parse(dataReader1["satisFiyati"].ToString())) * (double.Parse(dataReader1["miktari"].ToString()));
                netSatisToplam += (double.Parse(dataReader1["netSatisFiyati"].ToString())) * (double.Parse(dataReader1["miktari"].ToString()));
            }
            sqlConnection.Close();

            dataSatisGet();

            lblStokBedeliSayisi.Text = alisToplam.ToString("0.00");
            lblKarBedeliSayisi.Text = (satisToplam - alisToplam).ToString("0.00");
            lblKDVTutariSayisi.Text = (netSatisToplam - satisToplam).ToString("0.00");
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            excelYazdir();
        }
    }
}
