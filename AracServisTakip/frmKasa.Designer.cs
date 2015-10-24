namespace AracServisTakip
{
    partial class frmKasa
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.txtCikanToplam = new System.Windows.Forms.TextBox();
            this.txtGirenToplam = new System.Windows.Forms.TextBox();
            this.txtCariNo = new System.Windows.Forms.TextBox();
            this.cbIslemTurleri = new System.Windows.Forms.ComboBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtCikan = new System.Windows.Forms.TextBox();
            this.txtGiren = new System.Windows.Forms.TextBox();
            this.txtBelge = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.txtIslemTuru = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvHareketler = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtDevirBakiye = new System.Windows.Forms.TextBox();
            this.txtDevirCikan = new System.Windows.Forms.TextBox();
            this.txtDevirGiren = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParaBirimi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKasaTuru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHareketNo = new System.Windows.Forms.TextBox();
            this.txtCariHareketNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Toplam";
            // 
            // txtBakiye
            // 
            this.txtBakiye.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBakiye.Location = new System.Drawing.Point(531, 460);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(60, 20);
            this.txtBakiye.TabIndex = 56;
            this.txtBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCikanToplam
            // 
            this.txtCikanToplam.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCikanToplam.Location = new System.Drawing.Point(465, 460);
            this.txtCikanToplam.Name = "txtCikanToplam";
            this.txtCikanToplam.ReadOnly = true;
            this.txtCikanToplam.Size = new System.Drawing.Size(60, 20);
            this.txtCikanToplam.TabIndex = 55;
            this.txtCikanToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGirenToplam
            // 
            this.txtGirenToplam.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGirenToplam.Location = new System.Drawing.Point(399, 460);
            this.txtGirenToplam.Name = "txtGirenToplam";
            this.txtGirenToplam.ReadOnly = true;
            this.txtGirenToplam.Size = new System.Drawing.Size(60, 20);
            this.txtGirenToplam.TabIndex = 54;
            this.txtGirenToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCariNo
            // 
            this.txtCariNo.BackColor = System.Drawing.Color.White;
            this.txtCariNo.Location = new System.Drawing.Point(170, 178);
            this.txtCariNo.Name = "txtCariNo";
            this.txtCariNo.ReadOnly = true;
            this.txtCariNo.Size = new System.Drawing.Size(3, 20);
            this.txtCariNo.TabIndex = 53;
            this.txtCariNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbIslemTurleri
            // 
            this.cbIslemTurleri.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbIslemTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemTurleri.FormattingEnabled = true;
            this.cbIslemTurleri.Items.AddRange(new object[] {
            "Tahsilat",
            "Ödeme"});
            this.cbIslemTurleri.Location = new System.Drawing.Point(73, 177);
            this.cbIslemTurleri.Name = "cbIslemTurleri";
            this.cbIslemTurleri.Size = new System.Drawing.Size(80, 21);
            this.cbIslemTurleri.TabIndex = 52;
            this.cbIslemTurleri.SelectedIndexChanged += new System.EventHandler(this.cbIslemTurleri_SelectedIndexChanged);
            // 
            // txtPara
            // 
            this.txtPara.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPara.Location = new System.Drawing.Point(565, 204);
            this.txtPara.Name = "txtPara";
            this.txtPara.ReadOnly = true;
            this.txtPara.Size = new System.Drawing.Size(28, 20);
            this.txtPara.TabIndex = 51;
            this.txtPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCikan
            // 
            this.txtCikan.Location = new System.Drawing.Point(486, 204);
            this.txtCikan.Name = "txtCikan";
            this.txtCikan.Size = new System.Drawing.Size(73, 20);
            this.txtCikan.TabIndex = 50;
            this.txtCikan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGiren
            // 
            this.txtGiren.Location = new System.Drawing.Point(407, 204);
            this.txtGiren.Name = "txtGiren";
            this.txtGiren.Size = new System.Drawing.Size(73, 20);
            this.txtGiren.TabIndex = 49;
            this.txtGiren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBelge
            // 
            this.txtBelge.Location = new System.Drawing.Point(267, 204);
            this.txtBelge.Name = "txtBelge";
            this.txtBelge.Size = new System.Drawing.Size(134, 20);
            this.txtBelge.TabIndex = 48;
            this.txtBelge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCari.Location = new System.Drawing.Point(158, 204);
            this.txtCari.Name = "txtCari";
            this.txtCari.ReadOnly = true;
            this.txtCari.Size = new System.Drawing.Size(104, 20);
            this.txtCari.TabIndex = 47;
            this.txtCari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIslemTuru
            // 
            this.txtIslemTuru.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIslemTuru.Location = new System.Drawing.Point(73, 204);
            this.txtIslemTuru.Name = "txtIslemTuru";
            this.txtIslemTuru.ReadOnly = true;
            this.txtIslemTuru.Size = new System.Drawing.Size(80, 20);
            this.txtIslemTuru.TabIndex = 46;
            this.txtIslemTuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtID.Location = new System.Drawing.Point(44, 204);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(23, 20);
            this.txtID.TabIndex = 45;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvHareketler
            // 
            this.dgvHareketler.AllowUserToAddRows = false;
            this.dgvHareketler.AllowUserToDeleteRows = false;
            this.dgvHareketler.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHareketler.Location = new System.Drawing.Point(42, 230);
            this.dgvHareketler.Name = "dgvHareketler";
            this.dgvHareketler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHareketler.Size = new System.Drawing.Size(549, 224);
            this.dgvHareketler.TabIndex = 44;
            this.dgvHareketler.DoubleClick += new System.EventHandler(this.dgvHareketler_DoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(525, 92);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(63, 23);
            this.btnSil.TabIndex = 43;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.Color.White;
            this.btnDegistir.Enabled = false;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegistir.Location = new System.Drawing.Point(456, 92);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(63, 23);
            this.btnDegistir.TabIndex = 42;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(387, 92);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(63, 23);
            this.btnKaydet.TabIndex = 41;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.White;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Location = new System.Drawing.Point(318, 92);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(63, 23);
            this.btnYeni.TabIndex = 40;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtDevirBakiye
            // 
            this.txtDevirBakiye.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDevirBakiye.Location = new System.Drawing.Point(502, 45);
            this.txtDevirBakiye.Name = "txtDevirBakiye";
            this.txtDevirBakiye.ReadOnly = true;
            this.txtDevirBakiye.Size = new System.Drawing.Size(91, 20);
            this.txtDevirBakiye.TabIndex = 39;
            this.txtDevirBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDevirCikan
            // 
            this.txtDevirCikan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDevirCikan.Location = new System.Drawing.Point(405, 45);
            this.txtDevirCikan.Name = "txtDevirCikan";
            this.txtDevirCikan.ReadOnly = true;
            this.txtDevirCikan.Size = new System.Drawing.Size(91, 20);
            this.txtDevirCikan.TabIndex = 38;
            this.txtDevirCikan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDevirGiren
            // 
            this.txtDevirGiren.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDevirGiren.Location = new System.Drawing.Point(308, 45);
            this.txtDevirGiren.Name = "txtDevirGiren";
            this.txtDevirGiren.ReadOnly = true;
            this.txtDevirGiren.Size = new System.Drawing.Size(91, 20);
            this.txtDevirGiren.TabIndex = 37;
            this.txtDevirGiren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Kasa Devirleri";
            // 
            // txtParaBirimi
            // 
            this.txtParaBirimi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtParaBirimi.Location = new System.Drawing.Point(131, 95);
            this.txtParaBirimi.Name = "txtParaBirimi";
            this.txtParaBirimi.ReadOnly = true;
            this.txtParaBirimi.Size = new System.Drawing.Size(91, 20);
            this.txtParaBirimi.TabIndex = 35;
            this.txtParaBirimi.Text = "TL";
            this.txtParaBirimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Para Birimi";
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpTarih.Location = new System.Drawing.Point(221, 69);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(18, 20);
            this.dtpTarih.TabIndex = 33;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // txtTarih
            // 
            this.txtTarih.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTarih.Location = new System.Drawing.Point(131, 69);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(91, 20);
            this.txtTarih.TabIndex = 32;
            this.txtTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTarih.TextChanged += new System.EventHandler(this.txtTarih_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "İşlem Tarihi";
            // 
            // txtKasaTuru
            // 
            this.txtKasaTuru.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtKasaTuru.Location = new System.Drawing.Point(131, 42);
            this.txtKasaTuru.Name = "txtKasaTuru";
            this.txtKasaTuru.ReadOnly = true;
            this.txtKasaTuru.Size = new System.Drawing.Size(91, 20);
            this.txtKasaTuru.TabIndex = 30;
            this.txtKasaTuru.Text = "Merkez Kasa";
            this.txtKasaTuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Kasa Türü";
            // 
            // txtHareketNo
            // 
            this.txtHareketNo.BackColor = System.Drawing.Color.White;
            this.txtHareketNo.Location = new System.Drawing.Point(194, 178);
            this.txtHareketNo.Name = "txtHareketNo";
            this.txtHareketNo.ReadOnly = true;
            this.txtHareketNo.Size = new System.Drawing.Size(3, 20);
            this.txtHareketNo.TabIndex = 58;
            this.txtHareketNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCariHareketNo
            // 
            this.txtCariHareketNo.BackColor = System.Drawing.Color.White;
            this.txtCariHareketNo.Location = new System.Drawing.Point(219, 177);
            this.txtCariHareketNo.Name = "txtCariHareketNo";
            this.txtCariHareketNo.ReadOnly = true;
            this.txtCariHareketNo.Size = new System.Drawing.Size(3, 20);
            this.txtCariHareketNo.TabIndex = 59;
            this.txtCariHareketNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 506);
            this.Controls.Add(this.txtCariHareketNo);
            this.Controls.Add(this.txtHareketNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtCikanToplam);
            this.Controls.Add(this.txtGirenToplam);
            this.Controls.Add(this.txtCariNo);
            this.Controls.Add(this.cbIslemTurleri);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtCikan);
            this.Controls.Add(this.txtGiren);
            this.Controls.Add(this.txtBelge);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.txtIslemTuru);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvHareketler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtDevirBakiye);
            this.Controls.Add(this.txtDevirCikan);
            this.Controls.Add(this.txtDevirGiren);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtParaBirimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKasaTuru);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasa";
            this.Text = "Kasa İşlemleri";
            this.Load += new System.EventHandler(this.frmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtCikanToplam;
        private System.Windows.Forms.TextBox txtGirenToplam;
        private System.Windows.Forms.TextBox txtCariNo;
        private System.Windows.Forms.ComboBox cbIslemTurleri;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtCikan;
        private System.Windows.Forms.TextBox txtGiren;
        private System.Windows.Forms.TextBox txtBelge;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.TextBox txtIslemTuru;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvHareketler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtDevirBakiye;
        private System.Windows.Forms.TextBox txtDevirCikan;
        private System.Windows.Forms.TextBox txtDevirGiren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParaBirimi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKasaTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHareketNo;
        private System.Windows.Forms.TextBox txtCariHareketNo;
    }
}