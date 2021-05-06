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
    public partial class frmSatisSayfasi : Form
    {
        public frmSatisSayfasi()
        {
            InitializeComponent();
        }

        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\StokTakip.mdf'");
        SqlConnection sqlConnection = new SqlConnection("Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        private void dataGet()
        {
            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("select id as '" + "ID" + "', fisNo as '" + "Fiş No" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', iskonto as '" + "İskonto" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', tarih as '" + "Tarih" + "' from urunSatis", sqlConnection);
            sqlDataAdapter2.Fill(dataSet, "urunSatis");
            dataSatisSayfasi.DataSource = dataSet.Tables["urunSatis"];
            sqlConnection.Close();
        }

        private void dataClear()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from urunSatis", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void lblToplamFiyatGet()
        {
            ArrayList geciciBarkodNolar = new ArrayList();
            ArrayList geciciMiktarlar = new ArrayList();
            ArrayList geciciSatisFiyatlari = new ArrayList();
            ArrayList geciciNetSatisFiyatlari = new ArrayList();
            ArrayList geciciIskontolar = new ArrayList();
            ArrayList geciciKDVler = new ArrayList();
            int i = 0;
            lblToplamFiyat.Text = "0";

            sqlConnection.Open();
            SqlCommand sqlCommandFiyat = new SqlCommand("select * from urunSatis", sqlConnection);
            SqlDataReader sqlDataReaderFiyat = sqlCommandFiyat.ExecuteReader();
            while (sqlDataReaderFiyat.Read())
            {
                geciciBarkodNolar.Add(sqlDataReaderFiyat["barkodNo"].ToString());
                geciciMiktarlar.Add(sqlDataReaderFiyat["miktari"].ToString());
                geciciSatisFiyatlari.Add(sqlDataReaderFiyat["satisFiyati"].ToString());
                geciciNetSatisFiyatlari.Add(sqlDataReaderFiyat["netSatisFiyati"].ToString());
                geciciIskontolar.Add(sqlDataReaderFiyat["iskonto"].ToString());
                geciciKDVler.Add(sqlDataReaderFiyat["kdv"].ToString());
                i++;
            }
            sqlConnection.Close();

            for (int j = 0; j < i; j++)
            {
                lblToplamFiyat.Text = (double.Parse(lblToplamFiyat.Text) + ( double.Parse(geciciMiktarlar[j].ToString()) * (( (double.Parse(geciciNetSatisFiyatlari[j].ToString()) * (100 - int.Parse(geciciIskontolar[j].ToString()))) / 100 )) )).ToString();
            }
        }

        private void setGecmisSatislarData()
        {
            ArrayList geciciIDler = new ArrayList();
            ArrayList geciciSatisFiyatlari = new ArrayList();
            ArrayList geciciIskontolar = new ArrayList();
            ArrayList geciciNetSatisFiyatlari = new ArrayList();
            int i = 0;

            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("select * from urunSatis", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
            while (sqlDataReader.Read())
            {
                geciciIDler.Add(sqlDataReader["id"].ToString());
                geciciSatisFiyatlari.Add(sqlDataReader["satisFiyati"].ToString());
                geciciIskontolar.Add(sqlDataReader["iskonto"].ToString());
                geciciNetSatisFiyatlari.Add(sqlDataReader["netSatisFiyati"].ToString());
                i++;
            }
            sqlConnection.Close();

            for (int j = 0; j < i; j++)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update urunSatis set satisFiyati=@satisFiyati, netSatisFiyati=@netSatisFiyati where id='" + geciciIDler[j].ToString() + "'", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@satisFiyati", (double.Parse(geciciSatisFiyatlari[j].ToString()) * (100 - int.Parse(geciciIskontolar[j].ToString())) / 100));
                sqlCommand.Parameters.AddWithValue("@netSatisFiyati", (double.Parse(geciciNetSatisFiyatlari[j].ToString()) * (100 - int.Parse(geciciIskontolar[j].ToString())) / 100));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            dataGet();
        }

        private void satisYapNakit()
        {
            ArrayList geciciBarkodNolar = new ArrayList();
            ArrayList geciciSatilanMiktarlar = new ArrayList();
            ArrayList geciciMiktarlar = new ArrayList();
            ArrayList oncekiFisNo = new ArrayList();
            ArrayList oncekiTarih= new ArrayList();
            int i = 0;
            int sayac = 0;
            int enBuyukFisNo = 0;
            string enBuyukTarih = "00000000";

            sqlConnection.Open();
            SqlCommand sqlCommand4 = new SqlCommand("select * from gecmisSatislar", sqlConnection);
            SqlDataReader sqlDataReader3 = sqlCommand4.ExecuteReader();
            while (sqlDataReader3.Read())
            {
                oncekiTarih.Add(sqlDataReader3["tarih"].ToString().Substring(0,10).Replace(".", string.Empty));
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

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into gecmisSatislar select '" + (enBuyukFisNo + 1) + "', barkodNo, urunAdi, kategori, marka, miktari, alisFiyati, satisFiyati, '" + "NAKİT" + "', iskonto, kdv, netSatisFiyati, '" + "0" + "', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss") + "' from urunSatis", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

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
            dataClear();
            dataGet();
        }

        private void satisYapKredi()
        {
            ArrayList geciciBarkodNolar = new ArrayList();
            ArrayList geciciSatilanMiktarlar = new ArrayList();
            ArrayList geciciMiktarlar = new ArrayList();
            ArrayList oncekiFisNo = new ArrayList();
            ArrayList oncekiTarih = new ArrayList();
            int i = 0;
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

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into gecmisSatislar select '" + (enBuyukFisNo + 1) + "', barkodNo, urunAdi, kategori, marka, miktari, alisFiyati, satisFiyati, '" + "KREDİ" + "', iskonto, kdv, netSatisFiyati, '" + "0" + "', '" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss") + "' from urunSatis", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

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
            dataClear();
            dataGet();
        }

        private void frmSatisSayfasi_Load(object sender, EventArgs e)
        {
            cbFisAl.Checked = true;
            dataGet();
            lblToplamFiyatGet();
        }

        private void cbFisAlma_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFisAlma.Checked == true)
            {
                cbFisAl.Checked = false;
            }
            else
            {
                cbFisAl.Checked = true;
            }
        }

        private void cbFisAl_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFisAl.Checked == true)
            {
                cbFisAlma.Checked = false;
            }
            else
            {
                cbFisAlma.Checked = true;
            }
        }

        bool NakitIle = false;

        private void btnNakit_Click(object sender, EventArgs e)
        {
            if (cbFisAl.Checked)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("papername", 280, 2500);
                NakitIle = true;
                printPreviewDialog1.ShowDialog();
            }

            setGecmisSatislarData();
            satisYapNakit();
            lblToplamFiyat.Text = "0";
            MessageBox.Show("Satış İşlemi Başarılı (Nakit)");
            this.Close();
        }

        private void btnKredi_Click(object sender, EventArgs e)
        {
            if (cbFisAl.Checked)
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("papername", 280, 2500);
                NakitIle = false;
                printPreviewDialog1.ShowDialog();
            }

            setGecmisSatislarData();
            satisYapKredi();
            lblToplamFiyat.Text = "0";
            MessageBox.Show("Satış İşlemi Başarılı (Kredi Kartı)");
            this.Close();
        }

        private void cbTekSatir_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTekSatir.Checked == true)
            {
                cbTumSiparis.Checked = false;
            }
        }

        private void cbTumSiparis_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTumSiparis.Checked == true)
            {
                cbTekSatir.Checked = false;
            }
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtIskonto.Text) > 100)
            {
                MessageBox.Show("İskonto en fazla %100 olabilir!", "Uyarı");
            }
            else if (!cbTekSatir.Checked && !cbTumSiparis.Checked)
            {
                MessageBox.Show("İskontonun tek satıra mı, tüm siparişe mi uygulacağını seçiniz!", "Uyarı");
            }
            else if (cbTekSatir.Checked && geciciID == "")
            {
                MessageBox.Show("Lütfen iskontonun uygulanmasını istediğiniz ürünü seçiniz!", "Uyarı");
            }
            else if (cbTekSatir.Checked && geciciID != "")
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update urunSatis set iskonto=@iskonto where id=@id", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", geciciID);
                sqlCommand.Parameters.AddWithValue("@iskonto", txtIskonto.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                dataGet();
                lblToplamFiyatGet();
            }
            else if (cbTumSiparis.Checked)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update urunSatis set iskonto=@iskonto where id>0", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@iskonto", txtIskonto.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                dataGet();
                lblToplamFiyatGet();
            }
        }

        string geciciID = "";

        private void dataSatisSayfasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataSatisSayfasi.Rows[e.RowIndex];
                geciciID = row.Cells["ID"].Value.ToString();
            }
        }

        private void txtIskonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        Font baslik = new Font("Verdana", 10, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 8, FontStyle.Regular);
        Font icerik = new Font("Verdana", 8, FontStyle.Bold);
        SolidBrush solidBrush = new SolidBrush(Color.Black);
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
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
            //

            ArrayList geciciBarkodNolar = new ArrayList();
            ArrayList geciciSatilanMiktarlar = new ArrayList();
            ArrayList geciciSatisFiyatlari = new ArrayList();
            ArrayList geciciNetSatisFiyatlari= new ArrayList();
            ArrayList geciciKDVler= new ArrayList();
            double toplamNetFiyat = 0, toplamKDV = 0;
            double toplamKDV1 = 0, toplamKDV8 = 0, toplamKDV18 = 0;
            double toplamNetFiyatKDV1 = 0, toplamNetFiyatKDV8 = 0, toplamNetFiyatKDV18 = 0;
            string urunAdi;

            int j = 0;

            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("select * from urunSatis", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            while (sqlDataReader.Read())
            {
                geciciBarkodNolar.Add(sqlDataReader["barkodNo"].ToString());
                geciciSatilanMiktarlar.Add(sqlDataReader["miktari"].ToString());
                geciciSatisFiyatlari.Add(sqlDataReader["satisFiyati"].ToString());
                geciciKDVler.Add(sqlDataReader["kdv"].ToString());
                geciciNetSatisFiyatlari.Add(sqlDataReader["netSatisFiyati"].ToString());

                //toplamFiyat += double.Parse(geciciSatisFiyatlari[j].ToString());
                //toplamKDV += (double.Parse(geciciNetSatisFiyatlari[j].ToString()) - double.Parse(geciciSatisFiyatlari[j].ToString())) * double.Parse(geciciSatilanMiktarlar[j].ToString());
                //toplamNetFiyat += double.Parse(geciciNetSatisFiyatlari[j].ToString());

                j++;
            }
            sqlConnection.Close();


            StringFormat stringFormatCenter = new StringFormat();
            stringFormatCenter.Alignment = StringAlignment.Center;
            StringFormat stringFormatNear = new StringFormat();
            stringFormatNear.Alignment = StringAlignment.Near;
            StringFormat stringFormatFar = new StringFormat();
            stringFormatFar.Alignment = StringAlignment.Far;

            //DrawString("text", dont, solidBrush, x(genişlik), y(yükseklik), stringFormat);
            e.Graphics.DrawString("ASİL KIRTASİYE", baslik, solidBrush, 140, 40, stringFormatCenter);
            e.Graphics.DrawString("Batıkent Mahallesi Coştu Sokak\n" +
                                  "No:95 - 26180\n" +
                                  "TEPEBAŞI/ESKİŞEHİR", altBaslik, solidBrush, 140, 90, stringFormatCenter);

            e.Graphics.DrawString("TARİH", altBaslik, solidBrush, 20, 170, stringFormatNear);
            e.Graphics.DrawString(": " + DateTime.Now.ToString("dd.MM.yyyy"), altBaslik, solidBrush, 80, 170, stringFormatNear);
            e.Graphics.DrawString("SAAT", altBaslik, solidBrush, 20, 183, stringFormatNear);
            e.Graphics.DrawString(": " + DateTime.Now.ToString("HH:mm"), altBaslik, solidBrush, 80, 183, stringFormatNear);
            e.Graphics.DrawString("FİŞ NO", altBaslik, solidBrush, 20, 196, stringFormatNear);
            e.Graphics.DrawString(": " + (enBuyukFisNo + 1), altBaslik, solidBrush, 80, 196, stringFormatNear);

            j = 0;
            for (int i = 0; i < dataSatisSayfasi.Rows.Count; i++)
            {
                DataGridViewRow row = this.dataSatisSayfasi.Rows[i];
                if (row.Cells["Miktar"].Value.ToString() != "1")
                {
                    e.Graphics.DrawString(row.Cells["Miktar"].Value.ToString() + "ADET X *" + row.Cells["Net Satış Fiyatı"].Value.ToString(), altBaslik, solidBrush, 20, 235 + (j * 13), stringFormatNear);
                    j++;
                }

                urunAdi = row.Cells["Ürün Adı"].Value.ToString().ToUpper();
                if (urunAdi.Length > 20)
                {
                    urunAdi = row.Cells["Ürün Adı"].Value.ToString().ToUpper().Substring(0, 20);
                }

                e.Graphics.DrawString(urunAdi, altBaslik, solidBrush, 20, 235 + (j * 13), stringFormatNear);
                e.Graphics.DrawString("%" + row.Cells["KDV"].Value.ToString(), altBaslik, solidBrush, 175, 235 + (j * 13), stringFormatNear);
                e.Graphics.DrawString("*" + (double.Parse(row.Cells["Miktar"].Value.ToString()) * double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString())).ToString("0.00"), altBaslik, solidBrush, 260, 235 + (j * 13), stringFormatFar);
                j++;

                if (row.Cells["İskonto"].Value.ToString() != "0")
                {
                    e.Graphics.DrawString("%" + row.Cells["İskonto"].Value.ToString() + " İNDİRİM", altBaslik, solidBrush, 20, 235 + (j * 13), stringFormatNear);
                    e.Graphics.DrawString("*-" + ((double.Parse(row.Cells["İskonto"].Value.ToString()) / 100) * (double.Parse(row.Cells["Miktar"].Value.ToString()) * double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString()))).ToString("0.00"), altBaslik, solidBrush, 260, 235 + (j * 13), stringFormatFar);
                    j++;
                }

                toplamNetFiyat += ((100 - double.Parse(row.Cells["İskonto"].Value.ToString())) / 100) * (double.Parse(row.Cells["Miktar"].Value.ToString()) * double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString()));

                if (row.Cells["KDV"].Value.ToString() == "1")
                {
                    toplamKDV1 += (double.Parse(row.Cells["Miktar"].Value.ToString()) * (double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString()) - double.Parse(row.Cells["Satış Fiyatı"].Value.ToString()))) * ((100 - double.Parse(row.Cells["İskonto"].Value.ToString())) / 100);
                    toplamNetFiyatKDV1 += (double.Parse(row.Cells["Miktar"].Value.ToString()) * double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString())) * ((100 - double.Parse(row.Cells["İskonto"].Value.ToString())) / 100);
                }
                else if (row.Cells["KDV"].Value.ToString() == "8")
                {
                    toplamKDV8 += (double.Parse(row.Cells["Miktar"].Value.ToString()) * (double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString()) - double.Parse(row.Cells["Satış Fiyatı"].Value.ToString()))) * ((100 - double.Parse(row.Cells["İskonto"].Value.ToString())) / 100);
                    toplamNetFiyatKDV8 += (double.Parse(row.Cells["Miktar"].Value.ToString()) * double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString())) * ((100 - double.Parse(row.Cells["İskonto"].Value.ToString())) / 100);
                }
                else if (row.Cells["KDV"].Value.ToString() == "18")
                {
                    toplamKDV18 += (double.Parse(row.Cells["Miktar"].Value.ToString()) * (double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString()) - double.Parse(row.Cells["Satış Fiyatı"].Value.ToString()))) * ((100 - double.Parse(row.Cells["İskonto"].Value.ToString())) / 100);
                    toplamNetFiyatKDV18 += (double.Parse(row.Cells["Miktar"].Value.ToString()) * double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString())) * ((100 - double.Parse(row.Cells["İskonto"].Value.ToString())) / 100);
                }
            }

            toplamKDV = toplamKDV1 + toplamKDV8 + toplamKDV18;

            e.Graphics.DrawString("_______________________________", icerik, solidBrush, 140, 230 + 13 * (j + 2), stringFormatCenter);
            e.Graphics.DrawString("TOPKDV", icerik, solidBrush, 20, 235 + 13 * (j + 3), stringFormatNear);
            e.Graphics.DrawString("*" + toplamKDV.ToString("0.00"), icerik, solidBrush, 260, 235 + 13 * (j + 3), stringFormatFar);
            e.Graphics.DrawString("TOPLAM", icerik, solidBrush, 20, 235 + 13 * (j + 4), stringFormatNear);
            e.Graphics.DrawString("*" + toplamNetFiyat.ToString("0.00"), icerik, solidBrush, 260, 235 + 13 * (j + 4), stringFormatFar);
            e.Graphics.DrawString("_______________________________", icerik, solidBrush, 140, 230 + 13 * (j + 5), stringFormatCenter);

            if (NakitIle)
            {
                e.Graphics.DrawString("NAKİT", altBaslik, solidBrush, 20, 235 + 13 * (j + 7), stringFormatNear);
            }
            else
            {
                e.Graphics.DrawString("KREDİ KARTI", altBaslik, solidBrush, 20, 235 + 13 * (j + 7), stringFormatNear);
            }
            e.Graphics.DrawString("*" + toplamNetFiyat.ToString("0.00"), altBaslik, solidBrush, 260, 235 + 13 * (j + 7), stringFormatFar);

            e.Graphics.DrawString("KDV", altBaslik, solidBrush, 20, 235 + 13 * (j + 9), stringFormatNear);
            e.Graphics.DrawString("KDV TUTARI", altBaslik, solidBrush, 80, 235 + 13 * (j + 9), stringFormatNear);
            e.Graphics.DrawString("KDV'Lİ TOPLAM", altBaslik, solidBrush, 260, 235 + 13 * (j + 9), stringFormatFar);

            if (toplamKDV1 != 0)
            {
                e.Graphics.DrawString("%1", altBaslik, solidBrush, 20, 235 + 13 * (j + 10), stringFormatNear);
                e.Graphics.DrawString("*" + toplamKDV1.ToString("0.00"), altBaslik, solidBrush, 80, 235 + 13 * (j + 10), stringFormatNear);
                e.Graphics.DrawString("*" + toplamNetFiyatKDV1.ToString("0.00"), altBaslik, solidBrush, 260, 235 + 13 * (j + 10), stringFormatFar);
                j++;
            }
            if (toplamKDV8 != 0)
            {
                e.Graphics.DrawString("%8", altBaslik, solidBrush, 20, 235 + 13 * (j + 10), stringFormatNear);
                e.Graphics.DrawString("*" + toplamKDV8.ToString("0.00"), altBaslik, solidBrush, 80, 235 + 13 * (j + 10), stringFormatNear);
                e.Graphics.DrawString("*" + toplamNetFiyatKDV8.ToString("0.00"), altBaslik, solidBrush, 260, 235 + 13 * (j + 10), stringFormatFar);
                j++;
            }
            if (toplamKDV18 != 0)
            {
                e.Graphics.DrawString("%18", altBaslik, solidBrush, 20, 235 + 13 * (j + 10), stringFormatNear);
                e.Graphics.DrawString("*" + toplamKDV18.ToString("0.00"), altBaslik, solidBrush, 80, 235 + 13 * (j + 10), stringFormatNear);
                e.Graphics.DrawString("*" + toplamNetFiyatKDV18.ToString("0.00"), altBaslik, solidBrush, 260, 235 + 13 * (j + 10), stringFormatFar);
                j++;
            }
            e.Graphics.DrawString("İyi günler, yine bekleriz...", icerik, solidBrush, 140, 235 + 13 * (j + 12), stringFormatCenter);
        }
    }
}
