namespace YazilimBakimi
{
    partial class GirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogin = new MetroFramework.Controls.MetroPanel();
            this.btnSifremiUnuttum = new MetroFramework.Controls.MetroTile();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnKayitol = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGirisYap = new MetroFramework.Controls.MetroTile();
            this.txtBoxSifre = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxKullaniciEposta = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxSifreKayit = new MetroFramework.Controls.MetroTextBox();
            this.lblSifreKayit = new System.Windows.Forms.Label();
            this.txtBoxAdKayit = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxSoyadKayit = new MetroFramework.Controls.MetroTextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtBoxSifreKayitTekrar = new MetroFramework.Controls.MetroTextBox();
            this.lblSifreKayitTekrar = new System.Windows.Forms.Label();
            this.txtBoxEpostaKayit = new MetroFramework.Controls.MetroTextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.btnKayit = new MetroFramework.Controls.MetroTile();
            this.pnlKayitol = new MetroFramework.Controls.MetroPanel();
            this.btnGeriDon = new MetroFramework.Controls.MetroTile();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.pnlKayitol.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnSifremiUnuttum);
            this.pnlLogin.Controls.Add(this.lblSifre);
            this.pnlLogin.Controls.Add(this.lblKullaniciAdi);
            this.pnlLogin.Controls.Add(this.btnKayitol);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.btnGirisYap);
            this.pnlLogin.Controls.Add(this.txtBoxSifre);
            this.pnlLogin.Controls.Add(this.txtBoxKullaniciEposta);
            this.pnlLogin.HorizontalScrollbarBarColor = true;
            this.pnlLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlLogin.HorizontalScrollbarSize = 10;
            this.pnlLogin.Location = new System.Drawing.Point(23, 63);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(997, 559);
            this.pnlLogin.TabIndex = 0;
            this.pnlLogin.VerticalScrollbarBarColor = true;
            this.pnlLogin.VerticalScrollbarHighlightOnWheel = false;
            this.pnlLogin.VerticalScrollbarSize = 10;
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.ActiveControl = null;
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(477, 278);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(134, 40);
            this.btnSifremiUnuttum.TabIndex = 12;
            this.btnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSifremiUnuttum.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSifremiUnuttum.UseSelectable = true;
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(363, 237);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(45, 21);
            this.lblSifre.TabIndex = 11;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(301, 201);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(107, 21);
            this.lblKullaniciAdi.TabIndex = 10;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // btnKayitol
            // 
            this.btnKayitol.ActiveControl = null;
            this.btnKayitol.Location = new System.Drawing.Point(358, 324);
            this.btnKayitol.Name = "btnKayitol";
            this.btnKayitol.Size = new System.Drawing.Size(253, 40);
            this.btnKayitol.TabIndex = 9;
            this.btnKayitol.Text = "Kayıt Ol";
            this.btnKayitol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKayitol.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnKayitol.UseSelectable = true;
            this.btnKayitol.Click += new System.EventHandler(this.btnKayitol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(215, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "YAZILIM BAKIMI CRM PROJESİ";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.ActiveControl = null;
            this.btnGirisYap.Location = new System.Drawing.Point(358, 278);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(113, 40);
            this.btnGirisYap.TabIndex = 7;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGirisYap.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnGirisYap.UseSelectable = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtBoxSifre
            // 
            // 
            // 
            // 
            this.txtBoxSifre.CustomButton.Image = null;
            this.txtBoxSifre.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtBoxSifre.CustomButton.Name = "";
            this.txtBoxSifre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSifre.CustomButton.TabIndex = 1;
            this.txtBoxSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSifre.CustomButton.UseSelectable = true;
            this.txtBoxSifre.CustomButton.Visible = false;
            this.txtBoxSifre.Lines = new string[0];
            this.txtBoxSifre.Location = new System.Drawing.Point(414, 237);
            this.txtBoxSifre.MaxLength = 32767;
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.PasswordChar = '*';
            this.txtBoxSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSifre.SelectedText = "";
            this.txtBoxSifre.SelectionLength = 0;
            this.txtBoxSifre.SelectionStart = 0;
            this.txtBoxSifre.ShortcutsEnabled = true;
            this.txtBoxSifre.Size = new System.Drawing.Size(197, 23);
            this.txtBoxSifre.TabIndex = 5;
            this.txtBoxSifre.UseSelectable = true;
            this.txtBoxSifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxKullaniciEposta
            // 
            // 
            // 
            // 
            this.txtBoxKullaniciEposta.CustomButton.Image = null;
            this.txtBoxKullaniciEposta.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtBoxKullaniciEposta.CustomButton.Name = "";
            this.txtBoxKullaniciEposta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxKullaniciEposta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxKullaniciEposta.CustomButton.TabIndex = 1;
            this.txtBoxKullaniciEposta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxKullaniciEposta.CustomButton.UseSelectable = true;
            this.txtBoxKullaniciEposta.CustomButton.Visible = false;
            this.txtBoxKullaniciEposta.Lines = new string[0];
            this.txtBoxKullaniciEposta.Location = new System.Drawing.Point(414, 201);
            this.txtBoxKullaniciEposta.MaxLength = 32767;
            this.txtBoxKullaniciEposta.Name = "txtBoxKullaniciEposta";
            this.txtBoxKullaniciEposta.PasswordChar = '\0';
            this.txtBoxKullaniciEposta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxKullaniciEposta.SelectedText = "";
            this.txtBoxKullaniciEposta.SelectionLength = 0;
            this.txtBoxKullaniciEposta.SelectionStart = 0;
            this.txtBoxKullaniciEposta.ShortcutsEnabled = true;
            this.txtBoxKullaniciEposta.Size = new System.Drawing.Size(197, 23);
            this.txtBoxKullaniciEposta.TabIndex = 4;
            this.txtBoxKullaniciEposta.UseSelectable = true;
            this.txtBoxKullaniciEposta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxKullaniciEposta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxSifreKayit
            // 
            // 
            // 
            // 
            this.txtBoxSifreKayit.CustomButton.Image = null;
            this.txtBoxSifreKayit.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtBoxSifreKayit.CustomButton.Name = "";
            this.txtBoxSifreKayit.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtBoxSifreKayit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSifreKayit.CustomButton.TabIndex = 1;
            this.txtBoxSifreKayit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSifreKayit.CustomButton.UseSelectable = true;
            this.txtBoxSifreKayit.CustomButton.Visible = false;
            this.txtBoxSifreKayit.Lines = new string[0];
            this.txtBoxSifreKayit.Location = new System.Drawing.Point(411, 258);
            this.txtBoxSifreKayit.MaxLength = 32767;
            this.txtBoxSifreKayit.Name = "txtBoxSifreKayit";
            this.txtBoxSifreKayit.PasswordChar = '*';
            this.txtBoxSifreKayit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSifreKayit.SelectedText = "";
            this.txtBoxSifreKayit.SelectionLength = 0;
            this.txtBoxSifreKayit.SelectionStart = 0;
            this.txtBoxSifreKayit.ShortcutsEnabled = true;
            this.txtBoxSifreKayit.Size = new System.Drawing.Size(210, 21);
            this.txtBoxSifreKayit.TabIndex = 13;
            this.txtBoxSifreKayit.UseSelectable = true;
            this.txtBoxSifreKayit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSifreKayit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSifreKayit
            // 
            this.lblSifreKayit.AutoSize = true;
            this.lblSifreKayit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreKayit.Location = new System.Drawing.Point(360, 258);
            this.lblSifreKayit.Name = "lblSifreKayit";
            this.lblSifreKayit.Size = new System.Drawing.Size(45, 21);
            this.lblSifreKayit.TabIndex = 15;
            this.lblSifreKayit.Text = "Şifre:";
            // 
            // txtBoxAdKayit
            // 
            // 
            // 
            // 
            this.txtBoxAdKayit.CustomButton.Image = null;
            this.txtBoxAdKayit.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtBoxAdKayit.CustomButton.Name = "";
            this.txtBoxAdKayit.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtBoxAdKayit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxAdKayit.CustomButton.TabIndex = 1;
            this.txtBoxAdKayit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxAdKayit.CustomButton.UseSelectable = true;
            this.txtBoxAdKayit.CustomButton.Visible = false;
            this.txtBoxAdKayit.Lines = new string[0];
            this.txtBoxAdKayit.Location = new System.Drawing.Point(411, 144);
            this.txtBoxAdKayit.MaxLength = 32767;
            this.txtBoxAdKayit.Name = "txtBoxAdKayit";
            this.txtBoxAdKayit.PasswordChar = '\0';
            this.txtBoxAdKayit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxAdKayit.SelectedText = "";
            this.txtBoxAdKayit.SelectionLength = 0;
            this.txtBoxAdKayit.SelectionStart = 0;
            this.txtBoxAdKayit.ShortcutsEnabled = true;
            this.txtBoxAdKayit.Size = new System.Drawing.Size(210, 21);
            this.txtBoxAdKayit.TabIndex = 16;
            this.txtBoxAdKayit.UseSelectable = true;
            this.txtBoxAdKayit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxAdKayit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxSoyadKayit
            // 
            // 
            // 
            // 
            this.txtBoxSoyadKayit.CustomButton.Image = null;
            this.txtBoxSoyadKayit.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtBoxSoyadKayit.CustomButton.Name = "";
            this.txtBoxSoyadKayit.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtBoxSoyadKayit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSoyadKayit.CustomButton.TabIndex = 1;
            this.txtBoxSoyadKayit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSoyadKayit.CustomButton.UseSelectable = true;
            this.txtBoxSoyadKayit.CustomButton.Visible = false;
            this.txtBoxSoyadKayit.Lines = new string[0];
            this.txtBoxSoyadKayit.Location = new System.Drawing.Point(411, 180);
            this.txtBoxSoyadKayit.MaxLength = 32767;
            this.txtBoxSoyadKayit.Name = "txtBoxSoyadKayit";
            this.txtBoxSoyadKayit.PasswordChar = '\0';
            this.txtBoxSoyadKayit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSoyadKayit.SelectedText = "";
            this.txtBoxSoyadKayit.SelectionLength = 0;
            this.txtBoxSoyadKayit.SelectionStart = 0;
            this.txtBoxSoyadKayit.ShortcutsEnabled = true;
            this.txtBoxSoyadKayit.Size = new System.Drawing.Size(210, 21);
            this.txtBoxSoyadKayit.TabIndex = 17;
            this.txtBoxSoyadKayit.UseSelectable = true;
            this.txtBoxSoyadKayit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSoyadKayit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(367, 144);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(38, 21);
            this.lblAd.TabIndex = 18;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(343, 183);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(62, 21);
            this.lblSoyad.TabIndex = 19;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtBoxSifreKayitTekrar
            // 
            // 
            // 
            // 
            this.txtBoxSifreKayitTekrar.CustomButton.Image = null;
            this.txtBoxSifreKayitTekrar.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtBoxSifreKayitTekrar.CustomButton.Name = "";
            this.txtBoxSifreKayitTekrar.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtBoxSifreKayitTekrar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSifreKayitTekrar.CustomButton.TabIndex = 1;
            this.txtBoxSifreKayitTekrar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSifreKayitTekrar.CustomButton.UseSelectable = true;
            this.txtBoxSifreKayitTekrar.CustomButton.Visible = false;
            this.txtBoxSifreKayitTekrar.Lines = new string[0];
            this.txtBoxSifreKayitTekrar.Location = new System.Drawing.Point(411, 294);
            this.txtBoxSifreKayitTekrar.MaxLength = 32767;
            this.txtBoxSifreKayitTekrar.Name = "txtBoxSifreKayitTekrar";
            this.txtBoxSifreKayitTekrar.PasswordChar = '*';
            this.txtBoxSifreKayitTekrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSifreKayitTekrar.SelectedText = "";
            this.txtBoxSifreKayitTekrar.SelectionLength = 0;
            this.txtBoxSifreKayitTekrar.SelectionStart = 0;
            this.txtBoxSifreKayitTekrar.ShortcutsEnabled = true;
            this.txtBoxSifreKayitTekrar.Size = new System.Drawing.Size(210, 21);
            this.txtBoxSifreKayitTekrar.TabIndex = 20;
            this.txtBoxSifreKayitTekrar.UseSelectable = true;
            this.txtBoxSifreKayitTekrar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSifreKayitTekrar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSifreKayitTekrar
            // 
            this.lblSifreKayitTekrar.AutoSize = true;
            this.lblSifreKayitTekrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreKayitTekrar.Location = new System.Drawing.Point(360, 294);
            this.lblSifreKayitTekrar.Name = "lblSifreKayitTekrar";
            this.lblSifreKayitTekrar.Size = new System.Drawing.Size(45, 21);
            this.lblSifreKayitTekrar.TabIndex = 21;
            this.lblSifreKayitTekrar.Text = "Şifre:";
            // 
            // txtBoxEpostaKayit
            // 
            // 
            // 
            // 
            this.txtBoxEpostaKayit.CustomButton.Image = null;
            this.txtBoxEpostaKayit.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtBoxEpostaKayit.CustomButton.Name = "";
            this.txtBoxEpostaKayit.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtBoxEpostaKayit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxEpostaKayit.CustomButton.TabIndex = 1;
            this.txtBoxEpostaKayit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxEpostaKayit.CustomButton.UseSelectable = true;
            this.txtBoxEpostaKayit.CustomButton.Visible = false;
            this.txtBoxEpostaKayit.Lines = new string[0];
            this.txtBoxEpostaKayit.Location = new System.Drawing.Point(411, 222);
            this.txtBoxEpostaKayit.MaxLength = 32767;
            this.txtBoxEpostaKayit.Name = "txtBoxEpostaKayit";
            this.txtBoxEpostaKayit.PasswordChar = '\0';
            this.txtBoxEpostaKayit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxEpostaKayit.SelectedText = "";
            this.txtBoxEpostaKayit.SelectionLength = 0;
            this.txtBoxEpostaKayit.SelectionStart = 0;
            this.txtBoxEpostaKayit.ShortcutsEnabled = true;
            this.txtBoxEpostaKayit.Size = new System.Drawing.Size(210, 21);
            this.txtBoxEpostaKayit.TabIndex = 24;
            this.txtBoxEpostaKayit.UseSelectable = true;
            this.txtBoxEpostaKayit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxEpostaKayit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEposta.Location = new System.Drawing.Point(332, 222);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(73, 21);
            this.lblEposta.TabIndex = 25;
            this.lblEposta.Text = "E-posta:";
            // 
            // btnKayit
            // 
            this.btnKayit.ActiveControl = null;
            this.btnKayit.Location = new System.Drawing.Point(491, 341);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(130, 40);
            this.btnKayit.TabIndex = 26;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKayit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnKayit.UseSelectable = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // pnlKayitol
            // 
            this.pnlKayitol.Controls.Add(this.btnGeriDon);
            this.pnlKayitol.Controls.Add(this.label2);
            this.pnlKayitol.Controls.Add(this.btnKayit);
            this.pnlKayitol.Controls.Add(this.lblEposta);
            this.pnlKayitol.Controls.Add(this.txtBoxEpostaKayit);
            this.pnlKayitol.Controls.Add(this.lblSifreKayitTekrar);
            this.pnlKayitol.Controls.Add(this.txtBoxSifreKayitTekrar);
            this.pnlKayitol.Controls.Add(this.lblSoyad);
            this.pnlKayitol.Controls.Add(this.lblAd);
            this.pnlKayitol.Controls.Add(this.txtBoxSoyadKayit);
            this.pnlKayitol.Controls.Add(this.txtBoxAdKayit);
            this.pnlKayitol.Controls.Add(this.lblSifreKayit);
            this.pnlKayitol.Controls.Add(this.txtBoxSifreKayit);
            this.pnlKayitol.HorizontalScrollbarBarColor = true;
            this.pnlKayitol.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlKayitol.HorizontalScrollbarSize = 10;
            this.pnlKayitol.Location = new System.Drawing.Point(23, 63);
            this.pnlKayitol.Name = "pnlKayitol";
            this.pnlKayitol.Size = new System.Drawing.Size(994, 553);
            this.pnlKayitol.TabIndex = 1;
            this.pnlKayitol.VerticalScrollbarBarColor = true;
            this.pnlKayitol.VerticalScrollbarHighlightOnWheel = false;
            this.pnlKayitol.VerticalScrollbarSize = 10;
            this.pnlKayitol.Visible = false;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.ActiveControl = null;
            this.btnGeriDon.Location = new System.Drawing.Point(364, 341);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(121, 40);
            this.btnGeriDon.TabIndex = 28;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeriDon.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnGeriDon.UseSelectable = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(226, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 42);
            this.label2.TabIndex = 27;
            this.label2.Text = "YAZILIM BAKIMI CRM PROJESİ";
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 659);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlKayitol);
            this.Name = "GirisEkrani";
            this.Text = "CRM";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlKayitol.ResumeLayout(false);
            this.pnlKayitol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlLogin;
        private MetroFramework.Controls.MetroTextBox txtBoxKullaniciEposta;
        private MetroFramework.Controls.MetroTextBox txtBoxSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private MetroFramework.Controls.MetroTile btnKayitol;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile btnGirisYap;
        private MetroFramework.Controls.MetroPanel pnlKayitol;
        private MetroFramework.Controls.MetroTile btnGeriDon;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTile btnKayit;
        private System.Windows.Forms.Label lblEposta;
        private MetroFramework.Controls.MetroTextBox txtBoxEpostaKayit;
        private System.Windows.Forms.Label lblSifreKayitTekrar;
        private MetroFramework.Controls.MetroTextBox txtBoxSifreKayitTekrar;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private MetroFramework.Controls.MetroTextBox txtBoxSoyadKayit;
        private MetroFramework.Controls.MetroTextBox txtBoxAdKayit;
        private System.Windows.Forms.Label lblSifreKayit;
        private MetroFramework.Controls.MetroTextBox txtBoxSifreKayit;
        private MetroFramework.Controls.MetroTile btnSifremiUnuttum;
    }
}

