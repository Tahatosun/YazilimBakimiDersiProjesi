﻿namespace YazilimBakimi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tpUrunYonetimi = new System.Windows.Forms.TabPage();
            this.grpBxUrunSil = new System.Windows.Forms.GroupBox();
            this.txtBxUrunSilID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUrunSil = new MetroFramework.Controls.MetroTile();
            this.grpBxUrunGuncelle = new System.Windows.Forms.GroupBox();
            this.txtBxUrunGuncelleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUrunGuncelle = new MetroFramework.Controls.MetroTile();
            this.btnUrunEkle = new MetroFramework.Controls.MetroTile();
            this.grpBxUrunler = new System.Windows.Forms.GroupBox();
            this.dataGridUrunler = new MetroFramework.Controls.MetroGrid();
            this.tpBayiYonetimi = new MetroFramework.Controls.MetroTabPage();
            this.tpUrunSatisYonetimi = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tpUrunYonetimi.SuspendLayout();
            this.grpBxUrunSil.SuspendLayout();
            this.grpBxUrunGuncelle.SuspendLayout();
            this.grpBxUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).BeginInit();
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
            this.tpUrunYonetimi.BackColor = System.Drawing.Color.White;
            this.tpUrunYonetimi.Controls.Add(this.grpBxUrunSil);
            this.tpUrunYonetimi.Controls.Add(this.grpBxUrunGuncelle);
            this.tpUrunYonetimi.Controls.Add(this.btnUrunEkle);
            this.tpUrunYonetimi.Controls.Add(this.grpBxUrunler);
            this.tpUrunYonetimi.Location = new System.Drawing.Point(4, 38);
            this.tpUrunYonetimi.Name = "tpUrunYonetimi";
            this.tpUrunYonetimi.Size = new System.Drawing.Size(1085, 667);
            this.tpUrunYonetimi.TabIndex = 0;
            this.tpUrunYonetimi.Text = "Ürün Yönetimi";
            // 
            // grpBxUrunSil
            // 
            this.grpBxUrunSil.Controls.Add(this.txtBxUrunSilID);
            this.grpBxUrunSil.Controls.Add(this.label2);
            this.grpBxUrunSil.Controls.Add(this.btnUrunSil);
            this.grpBxUrunSil.Location = new System.Drawing.Point(863, 225);
            this.grpBxUrunSil.Name = "grpBxUrunSil";
            this.grpBxUrunSil.Size = new System.Drawing.Size(214, 112);
            this.grpBxUrunSil.TabIndex = 11;
            this.grpBxUrunSil.TabStop = false;
            this.grpBxUrunSil.Text = "ÜRÜN SİL";
            // 
            // txtBxUrunSilID
            // 
            this.txtBxUrunSilID.Location = new System.Drawing.Point(58, 31);
            this.txtBxUrunSilID.Name = "txtBxUrunSilID";
            this.txtBxUrunSilID.Size = new System.Drawing.Size(147, 20);
            this.txtBxUrunSilID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ürün ID:";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.ActiveControl = null;
            this.btnUrunSil.Location = new System.Drawing.Point(6, 65);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(202, 40);
            this.btnUrunSil.TabIndex = 9;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUrunSil.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnUrunSil.UseSelectable = true;
            // 
            // grpBxUrunGuncelle
            // 
            this.grpBxUrunGuncelle.Controls.Add(this.txtBxUrunGuncelleID);
            this.grpBxUrunGuncelle.Controls.Add(this.label1);
            this.grpBxUrunGuncelle.Controls.Add(this.btnUrunGuncelle);
            this.grpBxUrunGuncelle.Location = new System.Drawing.Point(863, 97);
            this.grpBxUrunGuncelle.Name = "grpBxUrunGuncelle";
            this.grpBxUrunGuncelle.Size = new System.Drawing.Size(214, 112);
            this.grpBxUrunGuncelle.TabIndex = 10;
            this.grpBxUrunGuncelle.TabStop = false;
            this.grpBxUrunGuncelle.Text = "ÜRÜN GÜNCELLE";
            // 
            // txtBxUrunGuncelleID
            // 
            this.txtBxUrunGuncelleID.Location = new System.Drawing.Point(59, 31);
            this.txtBxUrunGuncelleID.Name = "txtBxUrunGuncelleID";
            this.txtBxUrunGuncelleID.Size = new System.Drawing.Size(147, 20);
            this.txtBxUrunGuncelleID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürün ID:";
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.ActiveControl = null;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(6, 66);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(202, 39);
            this.btnUrunGuncelle.TabIndex = 9;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUrunGuncelle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnUrunGuncelle.UseSelectable = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.ActiveControl = null;
            this.btnUrunEkle.Location = new System.Drawing.Point(863, 28);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(214, 49);
            this.btnUrunEkle.TabIndex = 8;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUrunEkle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnUrunEkle.UseSelectable = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // grpBxUrunler
            // 
            this.grpBxUrunler.Controls.Add(this.dataGridUrunler);
            this.grpBxUrunler.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBxUrunler.Location = new System.Drawing.Point(9, 19);
            this.grpBxUrunler.Name = "grpBxUrunler";
            this.grpBxUrunler.Size = new System.Drawing.Size(848, 632);
            this.grpBxUrunler.TabIndex = 1;
            this.grpBxUrunler.TabStop = false;
            this.grpBxUrunler.Text = "ÜRÜNLER";
            // 
            // dataGridUrunler
            // 
            this.dataGridUrunler.AllowUserToResizeRows = false;
            this.dataGridUrunler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridUrunler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUrunler.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUrunler.EnableHeadersVisualStyles = false;
            this.dataGridUrunler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridUrunler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridUrunler.Location = new System.Drawing.Point(3, 19);
            this.dataGridUrunler.Name = "dataGridUrunler";
            this.dataGridUrunler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUrunler.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridUrunler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUrunler.Size = new System.Drawing.Size(842, 610);
            this.dataGridUrunler.TabIndex = 0;
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
            this.tpUrunYonetimi.ResumeLayout(false);
            this.grpBxUrunSil.ResumeLayout(false);
            this.grpBxUrunSil.PerformLayout();
            this.grpBxUrunGuncelle.ResumeLayout(false);
            this.grpBxUrunGuncelle.PerformLayout();
            this.grpBxUrunler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private System.Windows.Forms.TabPage tpUrunYonetimi;
        private MetroFramework.Controls.MetroTabPage tpBayiYonetimi;
        private System.Windows.Forms.TabPage tpUrunSatisYonetimi;
        private System.Windows.Forms.GroupBox grpBxUrunler;
        private MetroFramework.Controls.MetroGrid dataGridUrunler;
        private System.Windows.Forms.GroupBox grpBxUrunSil;
        private System.Windows.Forms.TextBox txtBxUrunSilID;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTile btnUrunSil;
        private System.Windows.Forms.GroupBox grpBxUrunGuncelle;
        private System.Windows.Forms.TextBox txtBxUrunGuncelleID;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile btnUrunGuncelle;
        private MetroFramework.Controls.MetroTile btnUrunEkle;
    }
}