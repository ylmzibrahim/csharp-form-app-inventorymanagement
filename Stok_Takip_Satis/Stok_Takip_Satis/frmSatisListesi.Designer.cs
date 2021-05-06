namespace Stok_Takip_Satis
{
    partial class frmSatisListesi
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.comboAra = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTumunuYazdir = new System.Windows.Forms.Button();
            this.dataSatisListesi = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.comboListeler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnTarihiYazdir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSatisListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(743, 33);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAra.MaxLength = 40;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(159, 26);
            this.txtAra.TabIndex = 2;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // comboAra
            // 
            this.comboAra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboAra.FormattingEnabled = true;
            this.comboAra.Items.AddRange(new object[] {
            "",
            "Fiş Numarasına Göre",
            "Barkod Numarasına Göre",
            "Ürün Adına Göre",
            "Kategoriye Göre",
            "Markaya Göre"});
            this.comboAra.Location = new System.Drawing.Point(543, 31);
            this.comboAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboAra.Name = "comboAra";
            this.comboAra.Size = new System.Drawing.Size(192, 28);
            this.comboAra.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(481, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 78;
            this.label8.Text = "ARA :";
            // 
            // btnTumunuYazdir
            // 
            this.btnTumunuYazdir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTumunuYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumunuYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumunuYazdir.ForeColor = System.Drawing.Color.White;
            this.btnTumunuYazdir.Location = new System.Drawing.Point(1071, 34);
            this.btnTumunuYazdir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTumunuYazdir.Name = "btnTumunuYazdir";
            this.btnTumunuYazdir.Size = new System.Drawing.Size(129, 26);
            this.btnTumunuYazdir.TabIndex = 4;
            this.btnTumunuYazdir.Text = "Tümünü Yazdır";
            this.btnTumunuYazdir.UseVisualStyleBackColor = false;
            this.btnTumunuYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // dataSatisListesi
            // 
            this.dataSatisListesi.AllowUserToAddRows = false;
            this.dataSatisListesi.AllowUserToDeleteRows = false;
            this.dataSatisListesi.AllowUserToResizeColumns = false;
            this.dataSatisListesi.AllowUserToResizeRows = false;
            this.dataSatisListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSatisListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataSatisListesi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataSatisListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSatisListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataSatisListesi.ColumnHeadersHeight = 75;
            this.dataSatisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataSatisListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataSatisListesi.Location = new System.Drawing.Point(13, 70);
            this.dataSatisListesi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataSatisListesi.Name = "dataSatisListesi";
            this.dataSatisListesi.ReadOnly = true;
            this.dataSatisListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataSatisListesi.Size = new System.Drawing.Size(1324, 645);
            this.dataSatisListesi.TabIndex = 6;
            this.dataSatisListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSatisListesi_CellContentClick);
            this.dataSatisListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSatisListesi_CellDoubleClick);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.CadetBlue;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(934, 34);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(129, 26);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // comboListeler
            // 
            this.comboListeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboListeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboListeler.FormattingEnabled = true;
            this.comboListeler.Items.AddRange(new object[] {
            "Geçmiş Satışlar",
            "Geçmiş İkramlar"});
            this.comboListeler.Location = new System.Drawing.Point(13, 31);
            this.comboListeler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboListeler.Name = "comboListeler";
            this.comboListeler.Size = new System.Drawing.Size(192, 28);
            this.comboListeler.TabIndex = 0;
            this.comboListeler.SelectedIndexChanged += new System.EventHandler(this.comboListeler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(462, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "-";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 26);
            this.dateTimePicker1.TabIndex = 83;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnTarihiYazdir
            // 
            this.btnTarihiYazdir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTarihiYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarihiYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarihiYazdir.ForeColor = System.Drawing.Color.White;
            this.btnTarihiYazdir.Location = new System.Drawing.Point(1208, 34);
            this.btnTarihiYazdir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTarihiYazdir.Name = "btnTarihiYazdir";
            this.btnTarihiYazdir.Size = new System.Drawing.Size(129, 26);
            this.btnTarihiYazdir.TabIndex = 84;
            this.btnTarihiYazdir.Text = "Tarihi Yazdır";
            this.btnTarihiYazdir.UseVisualStyleBackColor = false;
            this.btnTarihiYazdir.Click += new System.EventHandler(this.btnTarihiYazdir_Click);
            // 
            // frmSatisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnTarihiYazdir);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboListeler);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dataSatisListesi);
            this.Controls.Add(this.btnTumunuYazdir);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.comboAra);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSatisListesi";
            this.Text = "Satış Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSatisListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSatisListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ComboBox comboAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTumunuYazdir;
        private System.Windows.Forms.DataGridView dataSatisListesi;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.ComboBox comboListeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnTarihiYazdir;
    }
}