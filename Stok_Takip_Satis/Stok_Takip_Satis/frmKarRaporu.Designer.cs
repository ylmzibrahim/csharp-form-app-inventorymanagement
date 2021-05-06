namespace Stok_Takip_Satis
{
    partial class frmKarRaporu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.dataKarRaporu = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKDVTutariSayisi = new System.Windows.Forms.Label();
            this.lblKDVTutari = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKarBedeliSayisi = new System.Windows.Forms.Label();
            this.lblKarBedeli = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStokBedeliSayisi = new System.Windows.Forms.Label();
            this.lblStokBedelii = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataKarRaporu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen Tarihi Aralığı Seçiniz";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(236, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(506, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(239, 26);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(481, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.CadetBlue;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(766, 9);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(147, 31);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(766, 43);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(147, 31);
            this.btnYazdir.TabIndex = 4;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // dataKarRaporu
            // 
            this.dataKarRaporu.AllowUserToAddRows = false;
            this.dataKarRaporu.AllowUserToDeleteRows = false;
            this.dataKarRaporu.AllowUserToResizeColumns = false;
            this.dataKarRaporu.AllowUserToResizeRows = false;
            this.dataKarRaporu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataKarRaporu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataKarRaporu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataKarRaporu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataKarRaporu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataKarRaporu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataKarRaporu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataKarRaporu.ColumnHeadersHeight = 75;
            this.dataKarRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataKarRaporu.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataKarRaporu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataKarRaporu.Location = new System.Drawing.Point(12, 85);
            this.dataKarRaporu.Name = "dataKarRaporu";
            this.dataKarRaporu.ReadOnly = true;
            this.dataKarRaporu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataKarRaporu.Size = new System.Drawing.Size(1326, 632);
            this.dataKarRaporu.TabIndex = 5;
            this.dataKarRaporu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKarRaporu_CellClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1152, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "₺";
            // 
            // lblKDVTutariSayisi
            // 
            this.lblKDVTutariSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKDVTutariSayisi.AutoSize = true;
            this.lblKDVTutariSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKDVTutariSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblKDVTutariSayisi.Location = new System.Drawing.Point(1183, 54);
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
            this.lblKDVTutari.Location = new System.Drawing.Point(1037, 54);
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
            this.label4.Location = new System.Drawing.Point(1152, 34);
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
            this.lblKarBedeliSayisi.Location = new System.Drawing.Point(1183, 34);
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
            this.lblKarBedeli.Location = new System.Drawing.Point(1037, 34);
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
            this.label5.Location = new System.Drawing.Point(1152, 14);
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
            this.lblStokBedeliSayisi.Location = new System.Drawing.Point(1183, 14);
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
            this.lblStokBedelii.Location = new System.Drawing.Point(1037, 14);
            this.lblStokBedelii.Name = "lblStokBedelii";
            this.lblStokBedelii.Size = new System.Drawing.Size(98, 20);
            this.lblStokBedelii.TabIndex = 96;
            this.lblStokBedelii.Text = "Stok Bedeli :";
            // 
            // frmKarRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKDVTutariSayisi);
            this.Controls.Add(this.lblKDVTutari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKarBedeliSayisi);
            this.Controls.Add(this.lblKarBedeli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStokBedeliSayisi);
            this.Controls.Add(this.lblStokBedelii);
            this.Controls.Add(this.dataKarRaporu);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKarRaporu";
            this.Text = "Kar Raporu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKarRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKarRaporu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.DataGridView dataKarRaporu;
        private System.Windows.Forms.Label label3;
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