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
    public partial class frmGunuBitir : Form
    {
        public frmGunuBitir()
        {
            InitializeComponent();
        }

        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\StokTakip.mdf'");
        SqlConnection sqlConnection = new SqlConnection("Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        private void excelYazdir()
        {
            int i = 0, j = 0, k = 0;

            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            application.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = application.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            for (i = 0; i < dataGunuBitir.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1];
                range.Value2 = dataGunuBitir.Columns[i].HeaderText;
            }
            for (j = 0; j < dataGunuBitir.Columns.Count; j++)
            {
                for (k = 0; k < dataGunuBitir.Rows.Count; k++)
                {
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 2, j + 1];
                    range.Value2 = dataGunuBitir[j, k].Value;
                }
            }
            Microsoft.Office.Interop.Excel.Range range1 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 2, 1];
            range1.Value2 = "Toplam Stok Gideri=";
            Microsoft.Office.Interop.Excel.Range range2 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 2, 2];
            range2.Value2 = double.Parse(lblStokBedeliSayisiToplam.Text);
            Microsoft.Office.Interop.Excel.Range range3 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 3, 1];
            range3.Value2 = "Toplam Net Kar=";
            Microsoft.Office.Interop.Excel.Range range4 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 3, 2];
            range4.Value2 = double.Parse(lblKarBedeliSayisiToplam.Text);
            Microsoft.Office.Interop.Excel.Range range5 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 4, 1];
            range5.Value2 = "Toplam KDV=";
            Microsoft.Office.Interop.Excel.Range range6 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 4, 2];
            range6.Value2 = double.Parse(lblKDVTutariSayisiToplam.Text);
            Microsoft.Office.Interop.Excel.Range range7 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 5, 2];
            range7.Value2 = double.Parse(lblToplamToplam.Text);

            Microsoft.Office.Interop.Excel.Range range8 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 2, 4];
            range8.Value2 = "Nakit Stok Gideri=";
            Microsoft.Office.Interop.Excel.Range range9 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 2, 5];
            range9.Value2 = double.Parse(lblStokBedeliSayisiNakit.Text);
            Microsoft.Office.Interop.Excel.Range range10 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 3, 4];
            range10.Value2 = "Nakit Net Kar=";
            Microsoft.Office.Interop.Excel.Range range11 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 3, 5];
            range11.Value2 = double.Parse(lblKarBedeliSayisiNakit.Text);
            Microsoft.Office.Interop.Excel.Range range12 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 4, 4];
            range12.Value2 = "Nakit KDV=";
            Microsoft.Office.Interop.Excel.Range range13 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 4, 5];
            range13.Value2 = double.Parse(lblKDVTutariSayisiNakit.Text);
            Microsoft.Office.Interop.Excel.Range range14 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 5, 5];
            range14.Value2 = double.Parse(lblToplamNakit.Text);

            Microsoft.Office.Interop.Excel.Range range15 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 2, 7];
            range15.Value2 = "Kredi Stok Gideri=";
            Microsoft.Office.Interop.Excel.Range range16 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 2, 8];
            range16.Value2 = double.Parse(lblStokBedeliSayisiKredi.Text);
            Microsoft.Office.Interop.Excel.Range range17 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 3, 7];
            range17.Value2 = "Kredi Net Kar=";
            Microsoft.Office.Interop.Excel.Range range18 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 3, 8];
            range18.Value2 = double.Parse(lblKarBedeliSayisiKredi.Text);
            Microsoft.Office.Interop.Excel.Range range19 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 4, 7];
            range19.Value2 = "Kredi KDV=";
            Microsoft.Office.Interop.Excel.Range range20 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 4, 8];
            range20.Value2 = double.Parse(lblKDVTutariSayisiKredi.Text);
            Microsoft.Office.Interop.Excel.Range range21 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[k + 5, 8];
            range21.Value2 = double.Parse(lblToplamKredi.Text);

            worksheet.Columns.AutoFit();
            try
            {
                workbook.SaveAs("Günlük Rapor (" + DateTime.Today.ToString("yyyy.MM.dd") + ").xlsx");
            }
            catch (Exception)
            { 
            }
        }

        private void dataGet()
        {
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select id as '" + "ID" + "', fisNo as '" + "Fiş No" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', satisSekli as '" + "Ödeme Türü" + "', iskonto as '" + "İskonto" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', satilanMiktar as '" + "Satılan Miktar" + "', tarih as '" + "Tarih" + "' From gecmisSatislar where tarih between '" + today.ToString("yyyy.MM.dd HH:mm:ss") + "' and'" + tomorrow.ToString("yyyy.MM.dd HH:mm:ss") + "'", sqlConnection);
            sqlConnection.Open();
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "gecmisSatislar");
            dataGunuBitir.DataSource = dataSet.Tables["gecmisSatislar"];
            sqlConnection.Close();
        }

        private void frmGunuBitir_Load(object sender, EventArgs e)
        {
            dataGet();

            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            double alisToplam = 0, alisNakit = 0, alisKredi = 0;
            double satisToplam = 0, satisNakit= 0, satisKredi= 0;
            double KDVToplam = 0, KDVNakit = 0, KDVKredi = 0;


            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("Select * From gecmisSatislar where tarih between '" + today.ToString("yyyy.MM.dd HH:mm:ss") + "' and'" + tomorrow.ToString("yyyy.MM.dd HH:mm:ss") + "' and satisSekli ='" + "NAKİT" + "'", sqlConnection);
            SqlDataReader dataReader1 = sqlCommand1.ExecuteReader();
            while (dataReader1.Read())
            {
                alisNakit += (double.Parse(dataReader1["alisFiyati"].ToString())) * (double.Parse(dataReader1["miktari"].ToString()));
                satisNakit += (double.Parse(dataReader1["satisFiyati"].ToString())) * (double.Parse(dataReader1["miktari"].ToString()));
                KDVNakit += ((double.Parse(dataReader1["netSatisFiyati"].ToString())) - (double.Parse(dataReader1["satisFiyati"].ToString()))) * (double.Parse(dataReader1["miktari"].ToString()));
            }
            sqlConnection.Close();

            lblStokBedeliSayisiNakit.Text = alisNakit.ToString("0.00");
            lblKarBedeliSayisiNakit.Text = (satisNakit - alisNakit).ToString("0.00");
            lblKDVTutariSayisiNakit.Text = KDVNakit.ToString("0.00");
            lblToplamNakit.Text = (alisNakit + (satisNakit - alisNakit) + KDVNakit).ToString("0.00");

            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("Select * From gecmisSatislar where tarih between '" + today.ToString("yyyy.MM.dd HH:mm:ss") + "' and'" + tomorrow.ToString("yyyy.MM.dd HH:mm:ss") + "' and satisSekli ='" + "KREDİ" + "'", sqlConnection);
            SqlDataReader dataReader2 = sqlCommand2.ExecuteReader();
            while (dataReader2.Read())
            {
                alisKredi+= (double.Parse(dataReader2["alisFiyati"].ToString())) * (double.Parse(dataReader2["miktari"].ToString()));
                satisKredi += (double.Parse(dataReader2["satisFiyati"].ToString())) * (double.Parse(dataReader2["miktari"].ToString()));
                KDVKredi += ((double.Parse(dataReader2["netSatisFiyati"].ToString())) - (double.Parse(dataReader2["satisFiyati"].ToString()))) * (double.Parse(dataReader2["miktari"].ToString()));
            }
            sqlConnection.Close();

            lblStokBedeliSayisiKredi.Text = alisKredi.ToString("0.00");
            lblKarBedeliSayisiKredi.Text = (satisKredi - alisKredi).ToString("0.00");
            lblKDVTutariSayisiKredi.Text = KDVKredi.ToString("0.00");
            lblToplamKredi.Text = (alisKredi + (satisKredi - alisKredi) + KDVKredi).ToString("0.00");

            alisToplam = alisNakit + alisKredi;
            satisToplam = satisNakit + satisKredi;
            KDVToplam = KDVNakit + KDVKredi;

            lblStokBedeliSayisiToplam.Text = alisToplam.ToString("0.00");
            lblKarBedeliSayisiToplam.Text = (satisToplam - alisToplam).ToString("0.00");
            lblKDVTutariSayisiToplam.Text = KDVToplam.ToString("0.00");
            lblToplamToplam.Text = (alisToplam + (satisToplam - alisToplam) + KDVToplam).ToString("0.00");

            //
            ArrayList oncekiFisNo = new ArrayList();
            ArrayList oncekiTarih = new ArrayList();
            int sayac = 0;
            int enBuyukFisNo = 0;
            string enBuyukTarih = "00000000";

            sqlConnection.Open();
            SqlCommand sqlCommand4 = new SqlCommand("select * from gecmisSatislar", sqlConnection);
            SqlDataReader sqlDataReader3 = sqlCommand4.ExecuteReader();
            while (sqlDataReader3.Read())
            {
                oncekiTarih.Add(sqlDataReader3["tarih"].ToString().Substring(0, 10).Replace(".", string.Empty));
                sayac++;
            }
            sqlConnection.Close();

            for (int m = 0; m < sayac; m++)
            {
                if (int.Parse(oncekiTarih[m].ToString()) > int.Parse(enBuyukTarih))
                {
                    enBuyukTarih = oncekiTarih[m].ToString();
                }
            }

            if (enBuyukTarih == DateTime.Today.ToString("yyyyMMdd"))
            {
                sayac = 0;

                sqlConnection.Open();
                SqlCommand sqlCommand5 = new SqlCommand("select * from gecmisSatislar where tarih like '%" + DateTime.Today.ToString("yyyy.MM.dd") + "%'", sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand5.ExecuteReader();
                while (sqlDataReader1.Read())
                {
                    oncekiFisNo.Add(sqlDataReader1["fisNo"].ToString());
                    sayac++;
                }
                sqlConnection.Close();

                if (sayac == 0)
                {
                    enBuyukFisNo = 0;
                }
                else if (sayac == 1)
                {
                    enBuyukFisNo = 1;
                }
                else
                {
                    for (int k = 0; k < sayac; k++)
                    {
                        if (int.Parse(oncekiFisNo[k].ToString()) > enBuyukFisNo)
                        {
                            enBuyukFisNo = int.Parse(oncekiFisNo[k].ToString());
                        }
                    }
                }
            }
            else if (enBuyukTarih != DateTime.Today.ToString("yyyyMMdd"))
            {
                enBuyukFisNo = 0;
            }
            lblToplamFis.Text = enBuyukFisNo.ToString();
            //
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            excelYazdir();
        }
    }
}
