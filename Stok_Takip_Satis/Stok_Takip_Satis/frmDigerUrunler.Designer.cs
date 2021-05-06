namespace Stok_Takip_Satis
{
    partial class frmDigerUrunler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataDigerUrunler = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.lblTopMiktarSayisi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDigerUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDigerUrunler
            // 
            this.dataDigerUrunler.AllowUserToAddRows = false;
            this.dataDigerUrunler.AllowUserToDeleteRows = false;
            this.dataDigerUrunler.AllowUserToResizeColumns = false;
            this.dataDigerUrunler.AllowUserToResizeRows = false;
            this.dataDigerUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDigerUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataDigerUrunler.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataDigerUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDigerUrunler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDigerUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataDigerUrunler.ColumnHeadersHeight = 100;
            this.dataDigerUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataDigerUrunler.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDigerUrunler.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataDigerUrunler.GridColor = System.Drawing.SystemColors.Control;
            this.dataDigerUrunler.Location = new System.Drawing.Point(12, 64);
            this.dataDigerUrunler.Name = "dataDigerUrunler";
            this.dataDigerUrunler.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDigerUrunler.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataDigerUrunler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataDigerUrunler.Size = new System.Drawing.Size(1160, 535);
            this.dataDigerUrunler.TabIndex = 88;
            this.dataDigerUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDigerUrunler_CellClick);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(1017, 32);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(155, 26);
            this.btnEkle.TabIndex = 87;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(12, 32);
            this.txtUrunAdi.MaxLength = 100;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(141, 26);
            this.txtUrunAdi.TabIndex = 90;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdiUrun_TextChanged);
            this.txtUrunAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrunAdi_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(43, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 91;
            this.label11.Text = "Ürün Adı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(198, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 93;
            this.label10.Text = "Miktarı :";
            // 
            // txtMiktari
            // 
            this.txtMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktari.Location = new System.Drawing.Point(159, 32);
            this.txtMiktari.MaxLength = 9;
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(141, 26);
            this.txtMiktari.TabIndex = 92;
            this.txtMiktari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMiktari_KeyDown);
            // 
            // lblTopMiktarSayisi
            // 
            this.lblTopMiktarSayisi.AutoSize = true;
            this.lblTopMiktarSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopMiktarSayisi.Location = new System.Drawing.Point(424, 35);
            this.lblTopMiktarSayisi.Name = "lblTopMiktarSayisi";
            this.lblTopMiktarSayisi.Size = new System.Drawing.Size(18, 20);
            this.lblTopMiktarSayisi.TabIndex = 94;
            this.lblTopMiktarSayisi.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(323, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "Top. Miktar :";
            // 
            // frmDigerUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTopMiktarSayisi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMiktari);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataDigerUrunler);
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDigerUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDigerUrunler";
            this.Load += new System.EventHandler(this.frmDigerUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDigerUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDigerUrunler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.Label lblTopMiktarSayisi;
        private System.Windows.Forms.Label label2;
    }
}