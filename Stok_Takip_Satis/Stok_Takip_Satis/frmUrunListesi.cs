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
    public partial class frmUrunListesi : Form
    {
        public frmUrunListesi()
        {
            InitializeComponent();
        }
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\StokTakip.mdf'");
        SqlConnection sqlConnection = new SqlConnection("Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        private void excelYazdir()
        {
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            application.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = application.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            for (int i = 0; i < dataUrunListesi.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1];
                range.Value2 = dataUrunListesi.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataUrunListesi.Columns.Count; i++)
            {
                for (int j = 0; j < dataUrunListesi.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[j + 2, i + 1];
                    range.Value2 = dataUrunListesi[i, j].Value;
                }
            }

            worksheet.Columns.AutoFit();
            try
            {
                workbook.SaveAs("Ürün Listesi (" + DateTime.Today.ToString("yyyy.MM.dd") + ").xlsx");
            }
            catch (Exception)
            {
            }
        }

        private void dataGet()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', tarih as '" + "Tarih" + "' From urunBilgi", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataSet, "urunBilgi");
            dataUrunListesi.DataSource = dataSet.Tables["urunBilgi"];
            sqlConnection.Close();
        }

        private void frmUrunListesi_Load(object sender, EventArgs e)
        {
            //dataGet();
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
            dataUrunListesi.DataSource = searchTable;
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            dataGet();
            excelYazdir();
            DataTable searchTable = new DataTable();
            searchTable.Rows.Clear();
            dataUrunListesi.DataSource = searchTable;
        }
    }
}
