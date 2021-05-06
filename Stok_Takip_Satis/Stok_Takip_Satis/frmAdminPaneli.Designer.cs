namespace Stok_Takip_Satis
{
    partial class frmAdminPaneli
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnIkram = new System.Windows.Forms.Button();
            this.btnSeriNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Silme İşlemleri";
            // 
            // btnUrun
            // 
            this.btnUrun.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUrun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrun.ForeColor = System.Drawing.Color.White;
            this.btnUrun.Location = new System.Drawing.Point(12, 51);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(289, 42);
            this.btnUrun.TabIndex = 1;
            this.btnUrun.Text = "Ürün Bilgilerini Sıfırla";
            this.btnUrun.UseVisualStyleBackColor = false;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.CadetBlue;
            this.btnKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategori.ForeColor = System.Drawing.Color.White;
            this.btnKategori.Location = new System.Drawing.Point(12, 99);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(289, 42);
            this.btnKategori.TabIndex = 2;
            this.btnKategori.Text = "Kategori Bilgilerini Sıfırla";
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarka.ForeColor = System.Drawing.Color.White;
            this.btnMarka.Location = new System.Drawing.Point(12, 147);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(289, 42);
            this.btnMarka.TabIndex = 3;
            this.btnMarka.Text = "Marka Bilgilerini Sıfırla";
            this.btnMarka.UseVisualStyleBackColor = false;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnStok
            // 
            this.btnStok.BackColor = System.Drawing.Color.CadetBlue;
            this.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.ForeColor = System.Drawing.Color.White;
            this.btnStok.Location = new System.Drawing.Point(12, 195);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(289, 42);
            this.btnStok.TabIndex = 4;
            this.btnStok.Text = "Ürün Stok Sıfırla";
            this.btnStok.UseVisualStyleBackColor = false;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.ForeColor = System.Drawing.Color.White;
            this.btnSatis.Location = new System.Drawing.Point(12, 243);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(289, 42);
            this.btnSatis.TabIndex = 5;
            this.btnSatis.Text = "Satışları Sıfırla";
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnIkram
            // 
            this.btnIkram.BackColor = System.Drawing.Color.CadetBlue;
            this.btnIkram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIkram.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIkram.ForeColor = System.Drawing.Color.White;
            this.btnIkram.Location = new System.Drawing.Point(12, 291);
            this.btnIkram.Name = "btnIkram";
            this.btnIkram.Size = new System.Drawing.Size(289, 42);
            this.btnIkram.TabIndex = 6;
            this.btnIkram.Text = "İkramları Sıfırla";
            this.btnIkram.UseVisualStyleBackColor = false;
            this.btnIkram.Click += new System.EventHandler(this.btnIkram_Click);
            // 
            // btnSeriNo
            // 
            this.btnSeriNo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSeriNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeriNo.ForeColor = System.Drawing.Color.White;
            this.btnSeriNo.Location = new System.Drawing.Point(12, 339);
            this.btnSeriNo.Name = "btnSeriNo";
            this.btnSeriNo.Size = new System.Drawing.Size(289, 42);
            this.btnSeriNo.TabIndex = 7;
            this.btnSeriNo.Text = "Seri No Değiştir";
            this.btnSeriNo.UseVisualStyleBackColor = false;
            this.btnSeriNo.Click += new System.EventHandler(this.btnSeriNo_Click);
            // 
            // frmAdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 397);
            this.Controls.Add(this.btnSeriNo);
            this.Controls.Add(this.btnIkram);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnMarka);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.btnUrun);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.frmAdminPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnIkram;
        private System.Windows.Forms.Button btnSeriNo;
    }
}