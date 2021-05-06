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
    public partial class frmSatisIptal : Form
    {
        public frmSatisIptal()
        {
            InitializeComponent();
        }

        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\StokTakip.mdf'");
        SqlConnection sqlConnection = new SqlConnection("Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True");

        private void dataGet()
        {
            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select id as '" + "ID" + "', fisNo as '" + "Fiş No" + "', barkodNo as '" + "Barkod No" + "', urunAdi as '" + "Ürün Adı" + "', kategori as '" + "Kategori" + "', marka as '" + "Marka" + "', miktari as '" + "Miktar" + "', alisFiyati as '" + "Alış Fiyatı" + "', satisFiyati as '" + "Satış Fiyatı" + "', satisSekli as '" + "Ödeme Türü" + "', iskonto as '" + "İskonto" + "', kdv as '" + "KDV" + "', netSatisFiyati as '" + "Net Satış Fiyatı" + "', satilanMiktar as '" + "Satılan Miktar" + "', tarih as '" + "Tarih" + "' from gecmisSatisIptal", sqlConnection);
            sqlDataAdapter.Fill(dataSet, "gecmisSatisIptal");
            dataSatisIptal.DataSource = dataSet.Tables["gecmisSatisIptal"];
            sqlConnection.Close();
        }

        private void dataClear()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from gecmisSatisIptal", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmSatisIptal_Load(object sender, EventArgs e)
        {
            dataGet();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Tüm fişi iade etmek istediğinize emin nisiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                ArrayList geciciBarkodNolar = new ArrayList();
                ArrayList geciciMiktarlarUrunBilgi = new ArrayList();
                ArrayList geciciMiktarlarGecmisSatis = new ArrayList();
                string geciciSatisIptalTarih = "";
                int i = 0;

                sqlConnection.Open();
                SqlCommand sqlCommand4 = new SqlCommand("select * from gecmisSatisIptal", sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand4.ExecuteReader();
                while (sqlDataReader1.Read())
                {
                    geciciBarkodNolar.Add(sqlDataReader1["barkodNo"].ToString());
                    geciciMiktarlarGecmisSatis.Add(sqlDataReader1["miktari"].ToString());
                    geciciSatisIptalTarih = (sqlDataReader1["tarih"].ToString());
                    i++;
                }
                sqlConnection.Close();
                //
                for (int j = 0; j < i; j++)
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand6 = new SqlCommand("select miktari from urunBilgi where barkodNo='" + geciciBarkodNolar[j].ToString() + "'", sqlConnection);
                    SqlDataReader sqlDataReader2 = sqlCommand6.ExecuteReader();
                    while (sqlDataReader2.Read())
                    {
                        geciciMiktarlarUrunBilgi.Add(sqlDataReader2["miktari"].ToString());
                    }
                    sqlConnection.Close();

                    sqlConnection.Open();
                    SqlCommand sqlCommand5 = new SqlCommand("update urunBilgi set miktari=@miktari where barkodNo='" + geciciBarkodNolar[j].ToString() + "'", sqlConnection);
                    sqlCommand5.Parameters.AddWithValue("@miktari", (int.Parse(geciciMiktarlarUrunBilgi[j].ToString()) + int.Parse(geciciMiktarlarGecmisSatis[j].ToString())));
                    sqlCommand5.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                //
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from gecmisSatislar where tarih='" + geciciSatisIptalTarih + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                sqlConnection.Open();
                SqlCommand sqlCommand3 = new SqlCommand("delete from gecmisIkramlar where tarih='" + geciciSatisIptalTarih + "'", sqlConnection);
                sqlCommand3.ExecuteNonQuery();
                sqlConnection.Close();

                dataClear();
                dataGet();
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Ürün iade işlemi gerçekleştirmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                int geciciUrunMiktari = 0;

                sqlConnection.Open();
                SqlCommand sqlCommand4 = new SqlCommand("select * from gecmisSatisIptal", sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCommand4.ExecuteReader();
                while (sqlDataReader1.Read())
                {
                    geciciSatisIptalTarih = (sqlDataReader1["tarih"].ToString());
                }
                sqlConnection.Close();

                if (geciciSatisIptalTekli == "")
                {
                    MessageBox.Show("Lütfen silmek istediğiniz ürüne tıklayınız.");
                }
                else if (txtSilinecekAdet.Text == "")
                {
                    MessageBox.Show("Lütfen silmek istediğiniz adeti giriniz");
                }
                else if (int.Parse(txtSilinecekAdet.Text) > int.Parse(geciciMiktari))
                {
                    MessageBox.Show("Silmek istediğiniz adet sayısı, sattığınız adet sayısından fazla olamaz!");
                }
                else if (int.Parse(txtSilinecekAdet.Text) == int.Parse(geciciMiktari))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("delete from gecmisSatisIptal where id='" + geciciSatisIptalTekli + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    //
                    sqlConnection.Open();
                    SqlCommand sqlCommand6 = new SqlCommand("select miktari from urunBilgi where barkodNo='" + geciciBarkodNo + "'", sqlConnection);
                    SqlDataReader sqlDataReader2 = sqlCommand6.ExecuteReader();
                    while (sqlDataReader2.Read())
                    {
                        geciciUrunMiktari = int.Parse(sqlDataReader2["miktari"].ToString());
                    }
                    sqlConnection.Close();

                    sqlConnection.Open();
                    SqlCommand sqlCommand5 = new SqlCommand("update urunBilgi set miktari=@miktari where barkodNo='" + geciciBarkodNo + "'", sqlConnection);
                    sqlCommand5.Parameters.AddWithValue("@miktari", (geciciUrunMiktari + int.Parse(txtSilinecekAdet.Text)));
                    sqlCommand5.ExecuteNonQuery();
                    sqlConnection.Close();
                    //
                    sqlConnection.Open();
                    SqlCommand sqlCommand2 = new SqlCommand("delete from gecmisSatislar where id='" + geciciSatisIptalTekli + "' and tarih='" + geciciSatisIptalTarih + "'", sqlConnection);
                    sqlCommand2.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    SqlCommand sqlCommand3 = new SqlCommand("delete from gecmisIkramlar where id='" + geciciSatisIptalTekli + "' and tarih='" + geciciSatisIptalTarih + "'", sqlConnection);
                    sqlCommand3.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                else if (int.Parse(txtSilinecekAdet.Text) < int.Parse(geciciMiktari))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand3 = new SqlCommand("update gecmisSatisIptal set miktari=@miktari where id='" + geciciSatisIptalTekli + "'", sqlConnection);
                    sqlCommand3.Parameters.AddWithValue("@miktari", (int.Parse(geciciMiktari) - int.Parse(txtSilinecekAdet.Text)));
                    sqlCommand3.ExecuteNonQuery();
                    sqlConnection.Close();
                    //
                    sqlConnection.Open();
                    SqlCommand sqlCommand1 = new SqlCommand("select miktari from urunBilgi where barkodNo='" + geciciBarkodNo + "'", sqlConnection);
                    SqlDataReader sqlDataReader2 = sqlCommand1.ExecuteReader();
                    while (sqlDataReader2.Read())
                    {
                        geciciUrunMiktari = int.Parse(sqlDataReader2["miktari"].ToString());
                    }
                    sqlConnection.Close();

                    sqlConnection.Open();
                    SqlCommand sqlCommand2 = new SqlCommand("update urunBilgi set miktari=@miktari where barkodNo='" + geciciBarkodNo + "'", sqlConnection);
                    sqlCommand2.Parameters.AddWithValue("@miktari", (geciciUrunMiktari + int.Parse(txtSilinecekAdet.Text)));
                    sqlCommand2.ExecuteNonQuery();
                    sqlConnection.Close();
                    //
                    sqlConnection.Open();
                    SqlCommand sqlCommand5 = new SqlCommand("update gecmisSatislar set miktari=@miktari where id='" + geciciSatisIptalTekli + "' and tarih='" + geciciSatisIptalTarih + "'", sqlConnection);
                    sqlCommand5.Parameters.AddWithValue("@miktari", (int.Parse(geciciMiktari) - int.Parse(txtSilinecekAdet.Text)));
                    sqlCommand5.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    SqlCommand sqlCommand6 = new SqlCommand("update gecmisIkramlar set miktari=@miktari where id='" + geciciSatisIptalTekli + "' and tarih='" + geciciSatisIptalTarih + "'", sqlConnection);
                    sqlCommand6.Parameters.AddWithValue("@miktari", (int.Parse(geciciMiktari) - int.Parse(txtSilinecekAdet.Text)));
                    sqlCommand6.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                dataGet();
            }
        }

        string geciciBarkodNo = "", geciciSatisIptalTekli = "", geciciMiktari = "0", geciciSatisIptalTarih = "";

        Font baslik = new Font("Verdana", 10, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 8, FontStyle.Regular);
        Font icerik = new Font("Verdana", 8, FontStyle.Bold);
        SolidBrush solidBrush = new SolidBrush(Color.Black);

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ArrayList geciciBarkodNolar = new ArrayList();
            ArrayList geciciSatilanMiktarlar = new ArrayList();
            ArrayList geciciSatisFiyatlari = new ArrayList();
            ArrayList geciciNetSatisFiyatlari = new ArrayList();
            ArrayList geciciKDVler = new ArrayList();
            double toplamNetFiyat = 0, toplamKDV = 0;
            double toplamKDV1 = 0, toplamKDV8 = 0, toplamKDV18 = 0;
            double toplamNetFiyatKDV1 = 0, toplamNetFiyatKDV8 = 0, toplamNetFiyatKDV18 = 0;
            string urunAdi = "", fisNo = "", tarih = "", saat = "";
            

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

            fisNo = dataSatisIptal.Rows[0].Cells["Fiş No"].Value.ToString();
            
            
            tarih = dataSatisIptal.Rows[0].Cells["Tarih"].Value.ToString().Substring(0,10);
            saat = dataSatisIptal.Rows[0].Cells["Tarih"].Value.ToString().Substring(11, 5);
            string newTarih = tarih.Substring(8, 2) + "." + tarih.Substring(5, 2) + "." + tarih.Substring(0, 4);



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
            e.Graphics.DrawString(": " + newTarih, altBaslik, solidBrush, 80, 170, stringFormatNear);
            e.Graphics.DrawString("SAAT", altBaslik, solidBrush, 20, 183, stringFormatNear);
            e.Graphics.DrawString(": " + saat, altBaslik, solidBrush, 80, 183, stringFormatNear);
            e.Graphics.DrawString("FİŞ NO", altBaslik, solidBrush, 20, 196, stringFormatNear);
            e.Graphics.DrawString(": " + fisNo, altBaslik, solidBrush, 80, 196, stringFormatNear);

            j = 0;
            for (int i = 0; i < dataSatisIptal.Rows.Count; i++)
            {
                DataGridViewRow row = this.dataSatisIptal.Rows[i];
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
                    j++;
                }

                toplamNetFiyat += (double.Parse(row.Cells["Miktar"].Value.ToString()) * double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString()));

                if (row.Cells["KDV"].Value.ToString() == "1")
                {
                    toplamKDV1 += (double.Parse(row.Cells["Miktar"].Value.ToString()) * (double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString()) - double.Parse(row.Cells["Satış Fiyatı"].Value.ToString())));
                    toplamNetFiyatKDV1 += (double.Parse(row.Cells["Miktar"].Value.ToString()) * double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString()));
                }
                else if (row.Cells["KDV"].Value.ToString() == "8")
                {
                    toplamKDV8 += (double.Parse(row.Cells["Miktar"].Value.ToString()) * (double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString()) - double.Parse(row.Cells["Satış Fiyatı"].Value.ToString())));
                    toplamNetFiyatKDV8 += (double.Parse(row.Cells["Miktar"].Value.ToString()) * double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString()));
                }
                else if (row.Cells["KDV"].Value.ToString() == "18")
                {
                    toplamKDV18 += (double.Parse(row.Cells["Miktar"].Value.ToString()) * (double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString()) - double.Parse(row.Cells["Satış Fiyatı"].Value.ToString())));
                    toplamNetFiyatKDV18 += (double.Parse(row.Cells["Miktar"].Value.ToString()) * double.Parse(row.Cells["Net Satış Fiyatı"].Value.ToString()));
                }
            }

            toplamKDV = toplamKDV1 + toplamKDV8 + toplamKDV18;

            e.Graphics.DrawString("_______________________________", icerik, solidBrush, 140, 230 + 13 * (j + 2), stringFormatCenter);
            e.Graphics.DrawString("TOPKDV", icerik, solidBrush, 20, 235 + 13 * (j + 3), stringFormatNear);
            e.Graphics.DrawString("*" + toplamKDV.ToString("0.00"), icerik, solidBrush, 260, 235 + 13 * (j + 3), stringFormatFar);
            e.Graphics.DrawString("TOPLAM", icerik, solidBrush, 20, 235 + 13 * (j + 4), stringFormatNear);
            e.Graphics.DrawString("*" + toplamNetFiyat.ToString("0.00"), icerik, solidBrush, 260, 235 + 13 * (j + 4), stringFormatFar);
            e.Graphics.DrawString("_______________________________", icerik, solidBrush, 140, 230 + 13 * (j + 5), stringFormatCenter);

            if (dataSatisIptal.Rows[0].Cells["Ödeme Türü"].Value.ToString() == "NAKİT")
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


        private void button1_Click_2(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("papername", 280, 2500);
            printPreviewDialog1.ShowDialog();
        }

        private void dataSatisIptal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            geciciBarkodNo = "";
            geciciSatisIptalTekli = "";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataSatisIptal.Rows[e.RowIndex];
                geciciSatisIptalTekli = row.Cells["ID"].Value.ToString();
                geciciBarkodNo = row.Cells["Barkod No"].Value.ToString();
                geciciMiktari = row.Cells["Miktar"].Value.ToString();
                txtSilinecekAdet.Text = row.Cells["Miktar"].Value.ToString();
                geciciSatisIptalTarih = row.Cells["Tarih"].Value.ToString();
                this.ActiveControl = txtSilinecekAdet;
            }
        }
    }
}
