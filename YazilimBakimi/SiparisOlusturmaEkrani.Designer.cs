namespace YazilimBakimi
{
    partial class SiparisOlusturmaEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUrun = new System.Windows.Forms.Label();
            this.cmbBxUrunler = new System.Windows.Forms.ComboBox();
            this.lblAdeti = new System.Windows.Forms.Label();
            this.numUrunAdeti = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.grpBxSiparisUrunleri = new System.Windows.Forms.GroupBox();
            this.dataGridSipariseAitUrunler = new MetroFramework.Controls.MetroGrid();
            this.btnUrunuSipariseEkle = new MetroFramework.Controls.MetroTile();
            this.cmbBxSiparisiVerenBayi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSiparisiTamamla = new MetroFramework.Controls.MetroTile();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMevcutStok = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUrunAdeti)).BeginInit();
            this.grpBxSiparisUrunleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSipariseAitUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(35, 106);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(33, 13);
            this.lblUrun.TabIndex = 0;
            this.lblUrun.Text = "Ürün:";
            // 
            // cmbBxUrunler
            // 
            this.cmbBxUrunler.FormattingEnabled = true;
            this.cmbBxUrunler.Location = new System.Drawing.Point(74, 103);
            this.cmbBxUrunler.Name = "cmbBxUrunler";
            this.cmbBxUrunler.Size = new System.Drawing.Size(230, 21);
            this.cmbBxUrunler.TabIndex = 1;
            this.cmbBxUrunler.SelectedIndexChanged += new System.EventHandler(this.cmbBxUrunler_SelectedIndexChanged);
            // 
            // lblAdeti
            // 
            this.lblAdeti.AutoSize = true;
            this.lblAdeti.Location = new System.Drawing.Point(321, 106);
            this.lblAdeti.Name = "lblAdeti";
            this.lblAdeti.Size = new System.Drawing.Size(32, 13);
            this.lblAdeti.TabIndex = 2;
            this.lblAdeti.Text = "Adet:";
            // 
            // numUrunAdeti
            // 
            this.numUrunAdeti.Location = new System.Drawing.Point(359, 104);
            this.numUrunAdeti.Name = "numUrunAdeti";
            this.numUrunAdeti.Size = new System.Drawing.Size(110, 20);
            this.numUrunAdeti.TabIndex = 4;
            this.numUrunAdeti.ValueChanged += new System.EventHandler(this.numUrunAdeti_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fiyat:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Enabled = false;
            this.txtFiyat.Location = new System.Drawing.Point(526, 103);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(135, 20);
            this.txtFiyat.TabIndex = 6;
            // 
            // grpBxSiparisUrunleri
            // 
            this.grpBxSiparisUrunleri.BackColor = System.Drawing.Color.Transparent;
            this.grpBxSiparisUrunleri.Controls.Add(this.dataGridSipariseAitUrunler);
            this.grpBxSiparisUrunleri.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBxSiparisUrunleri.Location = new System.Drawing.Point(23, 139);
            this.grpBxSiparisUrunleri.Name = "grpBxSiparisUrunleri";
            this.grpBxSiparisUrunleri.Size = new System.Drawing.Size(841, 455);
            this.grpBxSiparisUrunleri.TabIndex = 7;
            this.grpBxSiparisUrunleri.TabStop = false;
            this.grpBxSiparisUrunleri.Text = "SİPARİŞE AİT ÜRÜNLER";
            // 
            // dataGridSipariseAitUrunler
            // 
            this.dataGridSipariseAitUrunler.AllowUserToAddRows = false;
            this.dataGridSipariseAitUrunler.AllowUserToDeleteRows = false;
            this.dataGridSipariseAitUrunler.AllowUserToResizeRows = false;
            this.dataGridSipariseAitUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSipariseAitUrunler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridSipariseAitUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSipariseAitUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridSipariseAitUrunler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSipariseAitUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSipariseAitUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSipariseAitUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSipariseAitUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSipariseAitUrunler.EnableHeadersVisualStyles = false;
            this.dataGridSipariseAitUrunler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridSipariseAitUrunler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridSipariseAitUrunler.Location = new System.Drawing.Point(3, 19);
            this.dataGridSipariseAitUrunler.Name = "dataGridSipariseAitUrunler";
            this.dataGridSipariseAitUrunler.ReadOnly = true;
            this.dataGridSipariseAitUrunler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSipariseAitUrunler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSipariseAitUrunler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridSipariseAitUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSipariseAitUrunler.Size = new System.Drawing.Size(835, 433);
            this.dataGridSipariseAitUrunler.TabIndex = 0;
            // 
            // btnUrunuSipariseEkle
            // 
            this.btnUrunuSipariseEkle.ActiveControl = null;
            this.btnUrunuSipariseEkle.Location = new System.Drawing.Point(696, 94);
            this.btnUrunuSipariseEkle.Name = "btnUrunuSipariseEkle";
            this.btnUrunuSipariseEkle.Size = new System.Drawing.Size(161, 39);
            this.btnUrunuSipariseEkle.TabIndex = 14;
            this.btnUrunuSipariseEkle.Text = "ÜRÜNÜ EKLE";
            this.btnUrunuSipariseEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUrunuSipariseEkle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnUrunuSipariseEkle.UseSelectable = true;
            this.btnUrunuSipariseEkle.Click += new System.EventHandler(this.btnUrunuSipariseEkle_Click);
            // 
            // cmbBxSiparisiVerenBayi
            // 
            this.cmbBxSiparisiVerenBayi.FormattingEnabled = true;
            this.cmbBxSiparisiVerenBayi.Location = new System.Drawing.Point(151, 609);
            this.cmbBxSiparisiVerenBayi.Name = "cmbBxSiparisiVerenBayi";
            this.cmbBxSiparisiVerenBayi.Size = new System.Drawing.Size(230, 21);
            this.cmbBxSiparisiVerenBayi.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "SİPARİŞİ VEREN BAYİ:";
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.ActiveControl = null;
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(649, 600);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(212, 39);
            this.btnSiparisiTamamla.TabIndex = 17;
            this.btnSiparisiTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisiTamamla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSiparisiTamamla.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSiparisiTamamla.UseSelectable = true;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Enabled = false;
            this.txtToplamFiyat.Location = new System.Drawing.Point(484, 609);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(135, 20);
            this.txtToplamFiyat.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Toplam Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Stok Miktarı:";
            // 
            // lblMevcutStok
            // 
            this.lblMevcutStok.AutoSize = true;
            this.lblMevcutStok.Location = new System.Drawing.Point(388, 128);
            this.lblMevcutStok.Name = "lblMevcutStok";
            this.lblMevcutStok.Size = new System.Drawing.Size(13, 13);
            this.lblMevcutStok.TabIndex = 21;
            this.lblMevcutStok.Text = "0";
            // 
            // SiparisOlusturmaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 661);
            this.Controls.Add(this.lblMevcutStok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtToplamFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.cmbBxSiparisiVerenBayi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUrunuSipariseEkle);
            this.Controls.Add(this.grpBxSiparisUrunleri);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUrunAdeti);
            this.Controls.Add(this.lblAdeti);
            this.Controls.Add(this.cmbBxUrunler);
            this.Controls.Add(this.lblUrun);
            this.Name = "SiparisOlusturmaEkrani";
            this.Text = "SiparisOlusturmaEkrani";
            this.Load += new System.EventHandler(this.SiparisOlusturmaEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUrunAdeti)).EndInit();
            this.grpBxSiparisUrunleri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSipariseAitUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.ComboBox cmbBxUrunler;
        private System.Windows.Forms.Label lblAdeti;
        private System.Windows.Forms.NumericUpDown numUrunAdeti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.GroupBox grpBxSiparisUrunleri;
        private MetroFramework.Controls.MetroTile btnUrunuSipariseEkle;
        private System.Windows.Forms.ComboBox cmbBxSiparisiVerenBayi;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTile btnSiparisiTamamla;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMevcutStok;
        private MetroFramework.Controls.MetroGrid dataGridSipariseAitUrunler;
    }
}