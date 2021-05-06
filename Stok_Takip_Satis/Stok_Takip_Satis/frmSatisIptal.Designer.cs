namespace Stok_Takip_Satis
{
    partial class frmSatisIptal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisIptal));
            this.dataSatisIptal = new System.Windows.Forms.DataGridView();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.txtSilinecekAdet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFisSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataSatisIptal)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSatisIptal
            // 
            this.dataSatisIptal.AllowUserToAddRows = false;
            this.dataSatisIptal.AllowUserToDeleteRows = false;
            this.dataSatisIptal.AllowUserToResizeColumns = false;
            this.dataSatisIptal.AllowUserToResizeRows = false;
            this.dataSatisIptal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSatisIptal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataSatisIptal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataSatisIptal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSatisIptal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSatisIptal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataSatisIptal.ColumnHeadersHeight = 100;
            this.dataSatisIptal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataSatisIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSatisIptal.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataSatisIptal.Location = new System.Drawing.Point(12, 12);
            this.dataSatisIptal.Name = "dataSatisIptal";
            this.dataSatisIptal.ReadOnly = true;
            this.dataSatisIptal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataSatisIptal.Size = new System.Drawing.Size(1097, 573);
            this.dataSatisIptal.TabIndex = 3;
            this.dataSatisIptal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSatisIptal_CellClick);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.ForeColor = System.Drawing.Color.White;
            this.btnUrunSil.Location = new System.Drawing.Point(1115, 485);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(242, 47);
            this.btnUrunSil.TabIndex = 1;
            this.btnUrunSil.Text = "Ürün İade";
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // txtSilinecekAdet
            // 
            this.txtSilinecekAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSilinecekAdet.Location = new System.Drawing.Point(1115, 432);
            this.txtSilinecekAdet.Name = "txtSilinecekAdet";
            this.txtSilinecekAdet.Size = new System.Drawing.Size(242, 47);
            this.txtSilinecekAdet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1115, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 83;
            this.label1.Text = "Silinecek Adet";
            // 
            // btnFisSil
            // 
            this.btnFisSil.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFisSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFisSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFisSil.ForeColor = System.Drawing.Color.White;
            this.btnFisSil.Location = new System.Drawing.Point(1115, 538);
            this.btnFisSil.Name = "btnFisSil";
            this.btnFisSil.Size = new System.Drawing.Size(242, 47);
            this.btnFisSil.TabIndex = 2;
            this.btnFisSil.Text = "Fiş İade";
            this.btnFisSil.UseVisualStyleBackColor = false;
            this.btnFisSil.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1285, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 71);
            this.button1.TabIndex = 84;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // frmSatisIptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSilinecekAdet);
            this.Controls.Add(this.btnFisSil);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.dataSatisIptal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSatisIptal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış İptal";
            this.Load += new System.EventHandler(this.frmSatisIptal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSatisIptal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataSatisIptal;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.TextBox txtSilinecekAdet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFisSil;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}