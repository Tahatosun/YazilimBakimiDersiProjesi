namespace YazilimBakimi
{
    partial class AnaEkran
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
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tpUrunYonetimi = new System.Windows.Forms.TabPage();
            this.tpBayiYonetimi = new MetroFramework.Controls.MetroTabPage();
            this.tpUrunSatisYonetimi = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpUrunYonetimi);
            this.tabControl.Controls.Add(this.tpBayiYonetimi);
            this.tabControl.Controls.Add(this.tpUrunSatisYonetimi);
            this.tabControl.Location = new System.Drawing.Point(23, 81);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1093, 709);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            // 
            // tpUrunYonetimi
            // 
            this.tpUrunYonetimi.Location = new System.Drawing.Point(4, 38);
            this.tpUrunYonetimi.Name = "tpUrunYonetimi";
            this.tpUrunYonetimi.Size = new System.Drawing.Size(1085, 667);
            this.tpUrunYonetimi.TabIndex = 0;
            this.tpUrunYonetimi.Text = "Ürün Yönetimi";
            // 
            // tpBayiYonetimi
            // 
            this.tpBayiYonetimi.HorizontalScrollbarBarColor = true;
            this.tpBayiYonetimi.HorizontalScrollbarHighlightOnWheel = false;
            this.tpBayiYonetimi.HorizontalScrollbarSize = 10;
            this.tpBayiYonetimi.Location = new System.Drawing.Point(4, 38);
            this.tpBayiYonetimi.Name = "tpBayiYonetimi";
            this.tpBayiYonetimi.Size = new System.Drawing.Size(1085, 667);
            this.tpBayiYonetimi.TabIndex = 1;
            this.tpBayiYonetimi.Text = "Bayii Yönetimi";
            this.tpBayiYonetimi.VerticalScrollbarBarColor = true;
            this.tpBayiYonetimi.VerticalScrollbarHighlightOnWheel = false;
            this.tpBayiYonetimi.VerticalScrollbarSize = 10;
            // 
            // tpUrunSatisYonetimi
            // 
            this.tpUrunSatisYonetimi.Location = new System.Drawing.Point(4, 38);
            this.tpUrunSatisYonetimi.Name = "tpUrunSatisYonetimi";
            this.tpUrunSatisYonetimi.Size = new System.Drawing.Size(1085, 667);
            this.tpUrunSatisYonetimi.TabIndex = 2;
            this.tpUrunSatisYonetimi.Text = "Ürün Satış Yönetimi";
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 802);
            this.Controls.Add(this.tabControl);
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private System.Windows.Forms.TabPage tpUrunYonetimi;
        private MetroFramework.Controls.MetroTabPage tpBayiYonetimi;
        private System.Windows.Forms.TabPage tpUrunSatisYonetimi;
    }
}