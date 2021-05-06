namespace Stok_Takip_Satis
{
    partial class frmStokEnvanter
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
            this.lblTopMiktarSayisi = new System.Windows.Forms.Label();
            this.lblTopMiktar = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.comboAra = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataStok = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.txtNetFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKDVTutariSayisi = new System.Windows.Forms.Label();
            this.lblKDVTutari = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKarBedeliSayisi = new System.Windows.Forms.Label();
            this.lblKarBedeli = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStokBedeliSayisi = new System.Windows.Forms.Label();
            this.lblStokBedelii = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataStok)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopMiktarSayisi
            // 
            this.lblTopMiktarSayisi.AutoSize = true;
            this.lblTopMiktarSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopMiktarSayisi.Location = new System.Drawing.Point(168, 377);
            this.lblTopMiktarSayisi.Name = "lblTopMiktarSayisi";
            this.lblTopMiktarSayisi.Size = new System.Drawing.Size(24, 25);
            this.lblTopMiktarSayisi.TabIndex = 74;
            this.lblTopMiktarSayisi.Text = "0";
            // 
            // lblTopMiktar
            // 
            this.lblTopMiktar.AutoSize = true;
            this.lblTopMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopMiktar.Location = new System.Drawing.Point(30, 377);
            this.lblTopMiktar.Name = "lblTopMiktar";
            this.lblTopMiktar.Size = new System.Drawing.Size(132, 25);
            this.lblTopMiktar.TabIndex = 73;
            this.lblTopMiktar.Text = "Top. Miktar :";
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(764, 43);
            this.txtAra.MaxLength = 100;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(248, 31);
            this.txtAra.TabIndex = 13;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // comboAra
            // 
            this.comboAra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboAra.FormattingEnabled = true;
            this.comboAra.Items.AddRange(new object[] {
            "",
            "Barkod Numarasına Göre",
            "Ürün Adına Göre",
            "Kategoriye Göre",
            "Markaya Göre"});
            this.comboAra.Location = new System.Drawing.Point(510, 43);
            this.comboAra.Name = "comboAra";
            this.comboAra.Size = new System.Drawing.Size(248, 33);
            this.comboAra.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(437, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 72;
            this.label8.Text = "ARA :";
            // 
            // dataStok
            // 
            this.dataStok.AllowUserToAddRows = false;
            this.dataStok.AllowUserToDeleteRows = false;
            this.dataStok.AllowUserToResizeColumns = false;
            this.dataStok.AllowUserToResizeRows = false;
            this.dataStok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataStok.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataStok.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataStok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataStok.ColumnHeadersHeight = 75;
            this.dataStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataStok.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataStok.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataStok.Location = new System.Drawing.Point(396, 82);
            this.dataStok.Name = "dataStok";
            this.dataStok.ReadOnly = true;
            this.dataStok.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataStok.Size = new System.Drawing.Size(942, 635);
            this.dataStok.TabIndex = 15;
            this.dataStok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStok_CellClick);
            this.dataStok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStok_CellContentClick);
            this.dataStok.MouseHover += new System.EventHandler(this.dataStok_MouseHover);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(205, 531);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(172, 49);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(21, 531);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(172, 49);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(32, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 62;
            this.label7.Text = "Satış Fiyatı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(45, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 25);
            this.label9.TabIndex = 64;
            this.label9.Text = "Alış Fiyatı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(74, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 65;
            this.label10.Text = "Miktarı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(55, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 67;
            this.label11.Text = "Ürün Adı :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(78, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 25);
            this.label12.TabIndex = 69;
            this.label12.Text = "Marka :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(58, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 25);
            this.label13.TabIndex = 70;
            this.label13.Text = "Kategori :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(37, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 25);
            this.label14.TabIndex = 71;
            this.label14.Text = "Barkod No :";
            // 
            // txtMiktari
            // 
            this.txtMiktari.Enabled = false;
            this.txtMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktari.Location = new System.Drawing.Point(168, 188);
            this.txtMiktari.MaxLength = 9;
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(209, 31);
            this.txtMiktari.TabIndex = 4;
            this.txtMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktari_KeyPress);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(168, 77);
            this.txtUrunAdi.MaxLength = 100;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(209, 31);
            this.txtUrunAdi.TabIndex = 1;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Enabled = false;
            this.txtSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyati.Location = new System.Drawing.Point(168, 262);
            this.txtSatisFiyati.MaxLength = 9;
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(209, 31);
            this.txtSatisFiyati.TabIndex = 6;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Enabled = false;
            this.txtAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisFiyati.Location = new System.Drawing.Point(168, 225);
            this.txtAlisFiyati.MaxLength = 9;
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(209, 31);
            this.txtAlisFiyati.TabIndex = 5;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.Location = new System.Drawing.Point(168, 40);
            this.txtBarkodNo.MaxLength = 30;
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(209, 31);
            this.txtBarkodNo.TabIndex = 0;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            this.txtBarkodNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkodNo_KeyPress);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(1166, 40);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(172, 36);
            this.btnYazdir.TabIndex = 14;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // txtKategori
            // 
            this.txtKategori.Enabled = false;
            this.txtKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategori.Location = new System.Drawing.Point(168, 114);
            this.txtKategori.MaxLength = 20;
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(209, 31);
            this.txtKategori.TabIndex = 2;
            // 
            // txtMarka
            // 
            this.txtMarka.Enabled = false;
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarka.Location = new System.Drawing.Point(168, 151);
            this.txtMarka.MaxLength = 20;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(209, 31);
            this.txtMarka.TabIndex = 3;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(21, 476);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(356, 49);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtKDV
            // 
            this.txtKDV.Enabled = false;
            this.txtKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKDV.Location = new System.Drawing.Point(168, 299);
            this.txtKDV.MaxLength = 3;
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(209, 31);
            this.txtKDV.TabIndex = 7;
            // 
            // txtNetFiyat
            // 
            this.txtNetFiyat.Enabled = false;
            this.txtNetFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNetFiyat.Location = new System.Drawing.Point(168, 336);
            this.txtNetFiyat.MaxLength = 9;
            this.txtNetFiyat.Name = "txtNetFiyat";
            this.txtNetFiyat.Size = new System.Drawing.Size(209, 31);
            this.txtNetFiyat.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "KDV :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 83;
            this.label3.Text = "Net Fiyat :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(135, 682);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "₺";
            // 
            // lblKDVTutariSayisi
            // 
            this.lblKDVTutariSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKDVTutariSayisi.AutoSize = true;
            this.lblKDVTutariSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKDVTutariSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblKDVTutariSayisi.Location = new System.Drawing.Point(160, 682);
            this.lblKDVTutariSayisi.Name = "lblKDVTutariSayisi";
            this.lblKDVTutariSayisi.Size = new System.Drawing.Size(44, 20);
            this.lblKDVTutariSayisi.TabIndex = 103;
            this.lblKDVTutariSayisi.Text = "0,00";
            // 
            // lblKDVTutari
            // 
            this.lblKDVTutari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKDVTutari.AutoSize = true;
            this.lblKDVTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKDVTutari.Location = new System.Drawing.Point(35, 682);
            this.lblKDVTutari.Name = "lblKDVTutari";
            this.lblKDVTutari.Size = new System.Drawing.Size(94, 20);
            this.lblKDVTutari.TabIndex = 102;
            this.lblKDVTutari.Text = "KDV Tutarı :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(135, 657);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 101;
            this.label4.Text = "₺";
            // 
            // lblKarBedeliSayisi
            // 
            this.lblKarBedeliSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKarBedeliSayisi.AutoSize = true;
            this.lblKarBedeliSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarBedeliSayisi.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblKarBedeliSayisi.Location = new System.Drawing.Point(160, 655);
            this.lblKarBedeliSayisi.Name = "lblKarBedeliSayisi";
            this.lblKarBedeliSayisi.Size = new System.Drawing.Size(44, 20);
            this.lblKarBedeliSayisi.TabIndex = 100;
            this.lblKarBedeliSayisi.Text = "0,00";
            // 
            // lblKarBedeli
            // 
            this.lblKarBedeli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKarBedeli.AutoSize = true;
            this.lblKarBedeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarBedeli.Location = new System.Drawing.Point(59, 657);
            this.lblKarBedeli.Name = "lblKarBedeli";
            this.lblKarBedeli.Size = new System.Drawing.Size(70, 20);
            this.lblKarBedeli.TabIndex = 99;
            this.lblKarBedeli.Text = "Net Kar :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(135, 630);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 98;
            this.label5.Text = "₺";
            // 
            // lblStokBedeliSayisi
            // 
            this.lblStokBedeliSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStokBedeliSayisi.AutoSize = true;
            this.lblStokBedeliSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokBedeliSayisi.ForeColor = System.Drawing.Color.DimGray;
            this.lblStokBedeliSayisi.Location = new System.Drawing.Point(160, 630);
            this.lblStokBedeliSayisi.Name = "lblStokBedeliSayisi";
            this.lblStokBedeliSayisi.Size = new System.Drawing.Size(44, 20);
            this.lblStokBedeliSayisi.TabIndex = 97;
            this.lblStokBedeliSayisi.Text = "0,00";
            // 
            // lblStokBedelii
            // 
            this.lblStokBedelii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStokBedelii.AutoSize = true;
            this.lblStokBedelii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokBedelii.Location = new System.Drawing.Point(31, 630);
            this.lblStokBedelii.Name = "lblStokBedelii";
            this.lblStokBedelii.Size = new System.Drawing.Size(98, 20);
            this.lblStokBedelii.TabIndex = 96;
            this.lblStokBedelii.Text = "Stok Bedeli :";
            // 
            // frmStokEnvanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKDVTutariSayisi);
            this.Controls.Add(this.lblKDVTutari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKarBedeliSayisi);
            this.Controls.Add(this.lblKarBedeli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStokBedeliSayisi);
            this.Controls.Add(this.lblStokBedelii);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNetFiyat);
            this.Controls.Add(this.txtKDV);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.lblTopMiktarSayisi);
            this.Controls.Add(this.lblTopMiktar);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.comboAra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataStok);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMiktari);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.txtBarkodNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStokEnvanter";
            this.Text = "Stok Envanter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStokEnvanter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopMiktarSayisi;
        private System.Windows.Forms.Label lblTopMiktar;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ComboBox comboAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataStok;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.TextBox txtNetFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKDVTutariSayisi;
        private System.Windows.Forms.Label lblKDVTutari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKarBedeliSayisi;
        private System.Windows.Forms.Label lblKarBedeli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStokBedeliSayisi;
        private System.Windows.Forms.Label lblStokBedelii;
    }
}