namespace Stok_Takip_Satis
{
    partial class frmSatisIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisIslemleri));
            this.label15 = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnUrunCikar = new System.Windows.Forms.Button();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIkram = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.dataSatis = new System.Windows.Forms.DataGridView();
            this.lblTopMiktar = new System.Windows.Forms.Label();
            this.lblTopMiktarSayisi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNetFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnDigerUrunler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(450, 651);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 31);
            this.label15.TabIndex = 23;
            this.label15.Text = "Toplam Fiyat: ";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamFiyat.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblToplamFiyat.Location = new System.Drawing.Point(678, 651);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(30, 31);
            this.lblToplamFiyat.TabIndex = 21;
            this.lblToplamFiyat.Text = "0";
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSatisYap.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSatisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisYap.ForeColor = System.Drawing.Color.White;
            this.btnSatisYap.Location = new System.Drawing.Point(960, 622);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(378, 95);
            this.btnSatisYap.TabIndex = 10;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = false;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // btnUrunCikar
            // 
            this.btnUrunCikar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUrunCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunCikar.ForeColor = System.Drawing.Color.White;
            this.btnUrunCikar.Location = new System.Drawing.Point(29, 394);
            this.btnUrunCikar.Name = "btnUrunCikar";
            this.btnUrunCikar.Size = new System.Drawing.Size(378, 51);
            this.btnUrunCikar.TabIndex = 7;
            this.btnUrunCikar.Text = "Ürün Çıkar";
            this.btnUrunCikar.UseVisualStyleBackColor = false;
            this.btnUrunCikar.Click += new System.EventHandler(this.btnUrunCikar_Click);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.Location = new System.Drawing.Point(179, 12);
            this.txtBarkodNo.MaxLength = 30;
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(228, 31);
            this.txtBarkodNo.TabIndex = 0;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            this.txtBarkodNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkodNo_KeyDown);
            this.txtBarkodNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkodNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(66, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ürün Adı :";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Enabled = false;
            this.txtSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyati.Location = new System.Drawing.Point(179, 123);
            this.txtSatisFiyati.MaxLength = 9;
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(228, 31);
            this.txtSatisFiyati.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Barkod No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(85, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Miktarı :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(179, 49);
            this.txtUrunAdi.MaxLength = 100;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(228, 31);
            this.txtUrunAdi.TabIndex = 1;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            this.txtUrunAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrunAdi_KeyDown);
            // 
            // txtMiktari
            // 
            this.txtMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktari.Location = new System.Drawing.Point(179, 86);
            this.txtMiktari.MaxLength = 9;
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(228, 31);
            this.txtMiktari.TabIndex = 2;
            this.txtMiktari.TextChanged += new System.EventHandler(this.txtMiktari_TextChanged);
            this.txtMiktari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMiktari_KeyDown);
            this.txtMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktari_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(43, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Satış Fiyatı :";
            // 
            // btnIkram
            // 
            this.btnIkram.BackColor = System.Drawing.Color.CadetBlue;
            this.btnIkram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIkram.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIkram.ForeColor = System.Drawing.Color.White;
            this.btnIkram.Location = new System.Drawing.Point(29, 451);
            this.btnIkram.Name = "btnIkram";
            this.btnIkram.Size = new System.Drawing.Size(378, 51);
            this.btnIkram.TabIndex = 8;
            this.btnIkram.Text = "İkram";
            this.btnIkram.UseVisualStyleBackColor = false;
            this.btnIkram.Click += new System.EventHandler(this.btnIkram_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.ForeColor = System.Drawing.Color.White;
            this.btnUrunEkle.Location = new System.Drawing.Point(29, 337);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(378, 51);
            this.btnUrunEkle.TabIndex = 6;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // dataSatis
            // 
            this.dataSatis.AllowUserToAddRows = false;
            this.dataSatis.AllowUserToDeleteRows = false;
            this.dataSatis.AllowUserToResizeColumns = false;
            this.dataSatis.AllowUserToResizeRows = false;
            this.dataSatis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSatis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataSatis.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataSatis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSatis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSatis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataSatis.ColumnHeadersHeight = 50;
            this.dataSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataSatis.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSatis.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataSatis.Location = new System.Drawing.Point(413, 12);
            this.dataSatis.Name = "dataSatis";
            this.dataSatis.ReadOnly = true;
            this.dataSatis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataSatis.Size = new System.Drawing.Size(925, 604);
            this.dataSatis.TabIndex = 11;
            this.dataSatis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSatis_CellClick);
            // 
            // lblTopMiktar
            // 
            this.lblTopMiktar.AutoSize = true;
            this.lblTopMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopMiktar.Location = new System.Drawing.Point(43, 235);
            this.lblTopMiktar.Name = "lblTopMiktar";
            this.lblTopMiktar.Size = new System.Drawing.Size(132, 25);
            this.lblTopMiktar.TabIndex = 70;
            this.lblTopMiktar.Text = "Top. Miktar :";
            // 
            // lblTopMiktarSayisi
            // 
            this.lblTopMiktarSayisi.AutoSize = true;
            this.lblTopMiktarSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopMiktarSayisi.Location = new System.Drawing.Point(181, 235);
            this.lblTopMiktarSayisi.Name = "lblTopMiktarSayisi";
            this.lblTopMiktarSayisi.Size = new System.Drawing.Size(24, 25);
            this.lblTopMiktarSayisi.TabIndex = 71;
            this.lblTopMiktarSayisi.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(642, 651);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 31);
            this.label5.TabIndex = 72;
            this.label5.Text = "₺";
            // 
            // txtKDV
            // 
            this.txtKDV.Enabled = false;
            this.txtKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKDV.Location = new System.Drawing.Point(179, 160);
            this.txtKDV.MaxLength = 3;
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(228, 31);
            this.txtKDV.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(106, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 74;
            this.label6.Text = "KDV :";
            // 
            // txtNetFiyat
            // 
            this.txtNetFiyat.Enabled = false;
            this.txtNetFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNetFiyat.Location = new System.Drawing.Point(179, 197);
            this.txtNetFiyat.MaxLength = 9;
            this.txtNetFiyat.Name = "txtNetFiyat";
            this.txtNetFiyat.Size = new System.Drawing.Size(228, 31);
            this.txtNetFiyat.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(63, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 76;
            this.label7.Text = "Net Fiyat :";
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.CadetBlue;
            this.btnYenile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYenile.BackgroundImage")));
            this.btnYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(29, 508);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(378, 51);
            this.btnYenile.TabIndex = 9;
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnDigerUrunler
            // 
            this.btnDigerUrunler.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDigerUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDigerUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDigerUrunler.ForeColor = System.Drawing.Color.White;
            this.btnDigerUrunler.Location = new System.Drawing.Point(29, 565);
            this.btnDigerUrunler.Name = "btnDigerUrunler";
            this.btnDigerUrunler.Size = new System.Drawing.Size(378, 51);
            this.btnDigerUrunler.TabIndex = 77;
            this.btnDigerUrunler.Text = "Diğer Ürünler";
            this.btnDigerUrunler.UseVisualStyleBackColor = false;
            this.btnDigerUrunler.Click += new System.EventHandler(this.btnDigerUrunler_Click);
            // 
            // frmSatisIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnDigerUrunler);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.txtNetFiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKDV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTopMiktarSayisi);
            this.Controls.Add(this.lblTopMiktar);
            this.Controls.Add(this.dataSatis);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnIkram);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtMiktari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.btnUrunCikar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSatisIslemleri";
            this.Text = "Satış İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSatisIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button btnUrunCikar;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIkram;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.DataGridView dataSatis;
        private System.Windows.Forms.Label lblTopMiktar;
        private System.Windows.Forms.Label lblTopMiktarSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNetFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnDigerUrunler;
    }
}