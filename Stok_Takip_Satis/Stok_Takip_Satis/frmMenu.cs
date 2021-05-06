using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_Satis
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnSatisIslemleri_Click(object sender, EventArgs e)
        {
            frmSatisIslemleri frmSatis = new frmSatisIslemleri();
            frmSatis.ShowDialog();
        }

        private void btnGecmisSatislar_Click(object sender, EventArgs e)
        {
            frmSatisListesi frmSatisList = new frmSatisListesi();
            frmSatisList.ShowDialog();
        }

        private void btnStokEnvanteri_Click(object sender, EventArgs e)
        {
            frmStokEnvanter frmStok = new frmStokEnvanter();
            frmStok.ShowDialog();
        }

        private void btnKayitliUrunler_Click(object sender, EventArgs e)
        {
            frmUrunListesi frmUrunList = new frmUrunListesi();
            frmUrunList.ShowDialog();
        }

        private void btnKarRaporu_Click(object sender, EventArgs e)
        {
            frmKarRaporu frmKar = new frmKarRaporu();
            frmKar.ShowDialog();
        }

        private void btnUrunEkleme_Click(object sender, EventArgs e)
        {
            frmUrunEkleme frmUrunEkle = new frmUrunEkleme();
            frmUrunEkle.ShowDialog();
        }

        private void btnEnCokSatanlar_Click(object sender, EventArgs e)
        {
            frmEnCokSatanlar frmEnCok = new frmEnCokSatanlar();
            frmEnCok.ShowDialog();
        }

        private void btnEnAzSatanlar_Click(object sender, EventArgs e)
        {
            frmEnAzSatanlar frmEnAz = new frmEnAzSatanlar();
            frmEnAz.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Günün raporlarına bakmak istyior musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                frmGunuBitir frmGunBitir = new frmGunuBitir();
                frmGunBitir.ShowDialog();
            }
            else
            {
                this.Close();
                Application.Exit();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
