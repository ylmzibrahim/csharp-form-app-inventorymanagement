namespace Stok_Takip_Satis
{
    partial class frmSatisSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisSayfasi));
            this.dataSatisSayfasi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKredi = new System.Windows.Forms.Button();
            this.btnNakit = new System.Windows.Forms.Button();
            this.cbFisAl = new System.Windows.Forms.CheckBox();
            this.cbFisAlma = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIskonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUygula = new System.Windows.Forms.Button();
            this.cbTumSiparis = new System.Windows.Forms.CheckBox();
            this.cbTekSatir = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataSatisSayfasi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSatisSayfasi
            // 
            this.dataSatisSayfasi.AllowUserToAddRows = false;
            this.dataSatisSayfasi.AllowUserToDeleteRows = false;
            this.dataSatisSayfasi.AllowUserToResizeColumns = false;
            this.dataSatisSayfasi.AllowUserToResizeRows = false;
            this.dataSatisSayfasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSatisSayfasi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataSatisSayfasi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataSatisSayfasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSatisSayfasi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSatisSayfasi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataSatisSayfasi.ColumnHeadersHeight = 100;
            this.dataSatisSayfasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataSatisSayfasi.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSatisSayfasi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataSatisSayfasi.Location = new System.Drawing.Point(12, 12);
            this.dataSatisSayfasi.Name = "dataSatisSayfasi";
            this.dataSatisSayfasi.ReadOnly = true;
            this.dataSatisSayfasi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataSatisSayfasi.Size = new System.Drawing.Size(1031, 563);
            this.dataSatisSayfasi.TabIndex = 4;
            this.dataSatisSayfasi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSatisSayfasi_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1049, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 87;
            this.label1.Text = "Ödeme Türü";
            // 
            // btnKredi
            // 
            this.btnKredi.BackColor = System.Drawing.Color.CadetBlue;
            this.btnKredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKredi.ForeColor = System.Drawing.Color.White;
            this.btnKredi.Location = new System.Drawing.Point(1049, 499);
            this.btnKredi.Name = "btnKredi";
            this.btnKredi.Size = new System.Drawing.Size(195, 76);
            this.btnKredi.TabIndex = 3;
            this.btnKredi.Text = "KREDİ";
            this.btnKredi.UseVisualStyleBackColor = false;
            this.btnKredi.Click += new System.EventHandler(this.btnKredi_Click);
            // 
            // btnNakit
            // 
            this.btnNakit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnNakit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNakit.ForeColor = System.Drawing.Color.White;
            this.btnNakit.Location = new System.Drawing.Point(1049, 417);
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.Size = new System.Drawing.Size(195, 76);
            this.btnNakit.TabIndex = 2;
            this.btnNakit.Text = "NAKİT";
            this.btnNakit.UseVisualStyleBackColor = false;
            this.btnNakit.Click += new System.EventHandler(this.btnNakit_Click);
            // 
            // cbFisAl
            // 
            this.cbFisAl.AutoSize = true;
            this.cbFisAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFisAl.Location = new System.Drawing.Point(6, 19);
            this.cbFisAl.Name = "cbFisAl";
            this.cbFisAl.Size = new System.Drawing.Size(67, 24);
            this.cbFisAl.TabIndex = 0;
            this.cbFisAl.Text = "Fiş Al";
            this.cbFisAl.UseVisualStyleBackColor = true;
            this.cbFisAl.CheckedChanged += new System.EventHandler(this.cbFisAl_CheckedChanged);
            // 
            // cbFisAlma
            // 
            this.cbFisAlma.AutoSize = true;
            this.cbFisAlma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFisAlma.Location = new System.Drawing.Point(6, 49);
            this.cbFisAlma.Name = "cbFisAlma";
            this.cbFisAlma.Size = new System.Drawing.Size(89, 24);
            this.cbFisAlma.TabIndex = 1;
            this.cbFisAlma.Text = "Fiş Alma";
            this.cbFisAlma.UseVisualStyleBackColor = true;
            this.cbFisAlma.CheckedChanged += new System.EventHandler(this.cbFisAlma_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "İskonto (%)";
            // 
            // txtIskonto
            // 
            this.txtIskonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIskonto.Location = new System.Drawing.Point(4, 39);
            this.txtIskonto.Name = "txtIskonto";
            this.txtIskonto.Size = new System.Drawing.Size(92, 26);
            this.txtIskonto.TabIndex = 0;
            this.txtIskonto.Text = "0";
            this.txtIskonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIskonto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(204, 589);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 31);
            this.label5.TabIndex = 96;
            this.label5.Text = "₺";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(12, 589);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 31);
            this.label15.TabIndex = 95;
            this.label15.Text = "Toplam Fiyat: ";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamFiyat.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblToplamFiyat.Location = new System.Drawing.Point(240, 589);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(30, 31);
            this.lblToplamFiyat.TabIndex = 94;
            this.lblToplamFiyat.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUygula);
            this.groupBox1.Controls.Add(this.cbTumSiparis);
            this.groupBox1.Controls.Add(this.cbTekSatir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIskonto);
            this.groupBox1.Location = new System.Drawing.Point(1050, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnUygula
            // 
            this.btnUygula.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUygula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUygula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUygula.ForeColor = System.Drawing.Color.White;
            this.btnUygula.Location = new System.Drawing.Point(6, 131);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(188, 41);
            this.btnUygula.TabIndex = 3;
            this.btnUygula.Text = "UYGULA";
            this.btnUygula.UseVisualStyleBackColor = false;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // cbTumSiparis
            // 
            this.cbTumSiparis.AutoSize = true;
            this.cbTumSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTumSiparis.Location = new System.Drawing.Point(6, 101);
            this.cbTumSiparis.Name = "cbTumSiparis";
            this.cbTumSiparis.Size = new System.Drawing.Size(135, 24);
            this.cbTumSiparis.TabIndex = 2;
            this.cbTumSiparis.Text = "Tüm sipariş için";
            this.cbTumSiparis.UseVisualStyleBackColor = true;
            this.cbTumSiparis.CheckedChanged += new System.EventHandler(this.cbTumSiparis_CheckedChanged);
            // 
            // cbTekSatir
            // 
            this.cbTekSatir.AutoSize = true;
            this.cbTekSatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTekSatir.Location = new System.Drawing.Point(6, 71);
            this.cbTekSatir.Name = "cbTekSatir";
            this.cbTekSatir.Size = new System.Drawing.Size(115, 24);
            this.cbTekSatir.TabIndex = 1;
            this.cbTekSatir.Text = "Tek satır için";
            this.cbTekSatir.UseVisualStyleBackColor = true;
            this.cbTekSatir.CheckedChanged += new System.EventHandler(this.cbTekSatir_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFisAl);
            this.groupBox2.Controls.Add(this.cbFisAlma);
            this.groupBox2.Location = new System.Drawing.Point(1050, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmSatisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 629);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKredi);
            this.Controls.Add(this.btnNakit);
            this.Controls.Add(this.dataSatisSayfasi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSatisSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.frmSatisSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSatisSayfasi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSatisSayfasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKredi;
        private System.Windows.Forms.Button btnNakit;
        private System.Windows.Forms.CheckBox cbFisAl;
        private System.Windows.Forms.CheckBox cbFisAlma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIskonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTumSiparis;
        private System.Windows.Forms.CheckBox cbTekSatir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUygula;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}