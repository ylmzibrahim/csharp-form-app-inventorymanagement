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
    public partial class frmEnCokSatanlar : Form
    {
        public frmEnCokSatanlar()
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
            for (int i = 0; i < dataEnCokSatanlar.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1];
                range.Value2 = dataEnCokSatanlar.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataEnCokSatanlar.Columns.Count; i++)
            {
                for (int j = 0; j < dataEnCokSatanlar.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[j + 2, i + 1];
                    range.Value2 = dataEnCokSatanlar[i, j].Value;
                }
            }

            worksheet.Columns.AutoFit();
            try
            {
                workbook.SaveAs("En Çok Satanlar (" + DateTime.Today.ToString("yyyy.MM.dd") + ").xlsx");
            }
            catch (Exception)
            {
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
            SqlCommand sqlCommand2 = new SqlCommand("update gecmisSatislar set satilanMiktar='" + 0 + "'", sqlConnection);
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
                SqlCommand sqlCommand4 = new SqlCommand("select * from gecmisSatislar where barkodNo='" + geciciBarkodNo[j].ToString() + "'", sqlConnection);
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

        private void dataGet()
        {
            satilanMiktarGet();

            ArrayList geciciBarkodNo = new ArrayList();
            string geciciSatilanMiktar = "";
            int i = 0;

            sqlConnection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("delete from enSatanlar", sqlConnection);
            sqlCommand3.ExecuteNonQuery();
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into enSatanlar select barkodNo, urunAdi, kategori, marka, miktari, alisFiyati, satisFiyati, kdv, netSatisFiyati, '"+ 0 +"' from urunBilgi", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("select barkodNo from enSatanlar", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            while (sqlDataReader.Read())
            {
                geciciBarkodNo.Add(sqlDataReader["barkodNo"].ToString());
                i++;
            }
            sqlConnection.Close();

            for (int j = 0; j < i; j++)
            {
                geciciSatilanMiktar = "0";

                sqlConnection.Open();
                SqlCommand sqlCommand2 = new SqlCommand("select * from gecmisSatislar where barkodNo='" + geciciBarkodNo[j].ToString() + "'", sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand2.ExecuteReader();
                while (sqlDataReader1.Read())
                {
                    geciciSatilanMiktar = (sqlDataReader1["satilanMiktar"].ToString());
                }
                sqlConnection.Close();

                sqlConnection.Open();
                SqlCommand sqlCommand4 = new SqlCommand("update enSatanlar set satilanMiktar='" + geciciSatilanMiktar + "' where barkodNo='" + geciciBarkodNo[j].ToString() + "'", sqlConnection);
                sqlCommand4.ExecuteNonQuery();
                sqlConnection.Close();
            }

            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("select top 20 barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', satilanMiktar as '" + "Satılan Miktar" + "' from enSatanlar order by satilanMiktar desc", sqlConnection);
            sqlDataAdapter2.Fill(dataSet, "enSatanlar");
            dataEnCokSatanlar.DataSource = dataSet.Tables["enSatanlar"];
            sqlConnection.Close();
        }

        private void frmEnCokSatanlar_Load(object sender, EventArgs e)
        {
            dataGet();
        }

        private void dataEnCokSatanlar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataEnCokSatanlar_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            excelYazdir();
        }
    }
}
