namespace YazilimBakimi
{
    partial class UrunEkle
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBxStokAdedi = new System.Windows.Forms.TextBox();
            this.txtBxBirimFiyat = new System.Windows.Forms.TextBox();
            this.btnEkle = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Adedi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birim Fiyatı:";
            // 
            // txtBxUrunAdi
            // 
            this.txtBxUrunAdi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxUrunAdi.Location = new System.Drawing.Point(158, 117);
            this.txtBxUrunAdi.Name = "txtBxUrunAdi";
            this.txtBxUrunAdi.Size = new System.Drawing.Size(171, 26);
            this.txtBxUrunAdi.TabIndex = 4;
            // 
            // txtBxStokAdedi
            // 
            this.txtBxStokAdedi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxStokAdedi.Location = new System.Drawing.Point(158, 150);
            this.txtBxStokAdedi.Name = "txtBxStokAdedi";
            this.txtBxStokAdedi.Size = new System.Drawing.Size(171, 26);
            this.txtBxStokAdedi.TabIndex = 6;
            // 
            // txtBxBirimFiyat
            // 
            this.txtBxBirimFiyat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBxBirimFiyat.Location = new System.Drawing.Point(158, 181);
            this.txtBxBirimFiyat.Name = "txtBxBirimFiyat";
            this.txtBxBirimFiyat.Size = new System.Drawing.Size(171, 26);
            this.txtBxBirimFiyat.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.ActiveControl = null;
            this.btnEkle.Location = new System.Drawing.Point(36, 280);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(293, 49);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ürünü Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEkle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnEkle.UseSelectable = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 407);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBxBirimFiyat);
            this.Controls.Add(this.txtBxStokAdedi);
            this.Controls.Add(this.txtBxUrunAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxUrunAdi;
        private System.Windows.Forms.TextBox txtBxStokAdedi;
        private System.Windows.Forms.TextBox txtBxBirimFiyat;
        private MetroFramework.Controls.MetroTile btnEkle;
    }
}