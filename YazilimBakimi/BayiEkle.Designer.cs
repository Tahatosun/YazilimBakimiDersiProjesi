namespace YazilimBakimi
{
    partial class BayiEkle
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
            this.txtBayiAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBayiAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkleBayi = new MetroFramework.Controls.MetroTile();
            this.txtBayiEposta = new System.Windows.Forms.TextBox();
            this.txtBayiTel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBayiEkleil = new System.Windows.Forms.ComboBox();
            this.cmbBxilce = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBayiAd
            // 
            this.txtBayiAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBayiAd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBayiAd.Location = new System.Drawing.Point(152, 131);
            this.txtBayiAd.MaxLength = 50;
            this.txtBayiAd.Name = "txtBayiAd";
            this.txtBayiAd.Size = new System.Drawing.Size(348, 26);
            this.txtBayiAd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bayi Adi:";
            // 
            // txtBayiAdres
            // 
            this.txtBayiAdres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBayiAdres.Location = new System.Drawing.Point(152, 185);
            this.txtBayiAdres.MaxLength = 250;
            this.txtBayiAdres.Multiline = true;
            this.txtBayiAdres.Name = "txtBayiAdres";
            this.txtBayiAdres.Size = new System.Drawing.Size(348, 99);
            this.txtBayiAdres.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bayi Adresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bayi E-posta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bayi Telefon:";
            // 
            // btnEkleBayi
            // 
            this.btnEkleBayi.ActiveControl = null;
            this.btnEkleBayi.Location = new System.Drawing.Point(30, 443);
            this.btnEkleBayi.Name = "btnEkleBayi";
            this.btnEkleBayi.Size = new System.Drawing.Size(468, 49);
            this.btnEkleBayi.TabIndex = 13;
            this.btnEkleBayi.Text = "EKLE";
            this.btnEkleBayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEkleBayi.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnEkleBayi.UseSelectable = true;
            this.btnEkleBayi.Click += new System.EventHandler(this.btnEkleBayi_Click);
            // 
            // txtBayiEposta
            // 
            this.txtBayiEposta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBayiEposta.Location = new System.Drawing.Point(150, 352);
            this.txtBayiEposta.MaxLength = 50;
            this.txtBayiEposta.Name = "txtBayiEposta";
            this.txtBayiEposta.Size = new System.Drawing.Size(348, 26);
            this.txtBayiEposta.TabIndex = 10;
            // 
            // txtBayiTel
            // 
            this.txtBayiTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBayiTel.Location = new System.Drawing.Point(150, 398);
            this.txtBayiTel.Mask = "00000000000";
            this.txtBayiTel.Name = "txtBayiTel";
            this.txtBayiTel.Size = new System.Drawing.Size(348, 24);
            this.txtBayiTel.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "İl:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(255, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "İlçe:";
            // 
            // cmbBayiEkleil
            // 
            this.cmbBayiEkleil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBayiEkleil.FormattingEnabled = true;
            this.cmbBayiEkleil.Location = new System.Drawing.Point(56, 295);
            this.cmbBayiEkleil.Name = "cmbBayiEkleil";
            this.cmbBayiEkleil.Size = new System.Drawing.Size(193, 28);
            this.cmbBayiEkleil.TabIndex = 17;
            this.cmbBayiEkleil.SelectedValueChanged += new System.EventHandler(this.cmbBayiEkleil_SelectedValueChanged);
            // 
            // cmbBxilce
            // 
            this.cmbBxilce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBxilce.FormattingEnabled = true;
            this.cmbBxilce.Location = new System.Drawing.Point(307, 295);
            this.cmbBxilce.Name = "cmbBxilce";
            this.cmbBxilce.Size = new System.Drawing.Size(193, 28);
            this.cmbBxilce.TabIndex = 18;
            // 
            // BayiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 519);
            this.Controls.Add(this.cmbBxilce);
            this.Controls.Add(this.cmbBayiEkleil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBayiTel);
            this.Controls.Add(this.btnEkleBayi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBayiEposta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBayiAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBayiAd);
            this.Controls.Add(this.label1);
            this.Name = "BayiEkle";
            this.Text = "BayiEkle";
            this.Load += new System.EventHandler(this.BayiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBayiAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBayiAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTile btnEkleBayi;
        private System.Windows.Forms.TextBox txtBayiEposta;
        private System.Windows.Forms.MaskedTextBox txtBayiTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBayiEkleil;
        private System.Windows.Forms.ComboBox cmbBxilce;
    }
}