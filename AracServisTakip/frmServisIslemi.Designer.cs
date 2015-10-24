namespace AracServisTakip
{
    partial class frmServisIslemi
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
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtIslemTarihi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCariNo = new System.Windows.Forms.TextBox();
            this.btnCariBul = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbServisTurleri = new System.Windows.Forms.ComboBox();
            this.txtServisTuru = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbUrunler = new System.Windows.Forms.ComboBox();
            this.txtUrunler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtUstaNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUsta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServisBedeli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunBedeli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunNo = new System.Windows.Forms.TextBox();
            this.txtServisNo = new System.Windows.Forms.TextBox();
            this.dgvIslemUzayan = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemUzayan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(195, 37);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(20, 20);
            this.dtpTarih.TabIndex = 18;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // txtIslemTarihi
            // 
            this.txtIslemTarihi.BackColor = System.Drawing.Color.White;
            this.txtIslemTarihi.Location = new System.Drawing.Point(114, 37);
            this.txtIslemTarihi.Name = "txtIslemTarihi";
            this.txtIslemTarihi.ReadOnly = true;
            this.txtIslemTarihi.Size = new System.Drawing.Size(82, 20);
            this.txtIslemTarihi.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "İşlem Tarihi";
            // 
            // txtCariNo
            // 
            this.txtCariNo.BackColor = System.Drawing.Color.White;
            this.txtCariNo.Location = new System.Drawing.Point(253, 64);
            this.txtCariNo.Name = "txtCariNo";
            this.txtCariNo.ReadOnly = true;
            this.txtCariNo.Size = new System.Drawing.Size(1, 20);
            this.txtCariNo.TabIndex = 26;
            this.txtCariNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCariBul
            // 
            this.btnCariBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariBul.Location = new System.Drawing.Point(220, 63);
            this.btnCariBul.Name = "btnCariBul";
            this.btnCariBul.Size = new System.Drawing.Size(23, 21);
            this.btnCariBul.TabIndex = 24;
            this.btnCariBul.Text = "...";
            this.btnCariBul.UseVisualStyleBackColor = true;
            this.btnCariBul.Click += new System.EventHandler(this.btnCariBul_Click);
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.Color.White;
            this.txtCari.Location = new System.Drawing.Point(114, 63);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.ReadOnly = true;
            this.txtCari.Size = new System.Drawing.Size(109, 21);
            this.txtCari.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cari";
            // 
            // cbServisTurleri
            // 
            this.cbServisTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServisTurleri.DropDownWidth = 100;
            this.cbServisTurleri.FormattingEnabled = true;
            this.cbServisTurleri.Location = new System.Drawing.Point(454, 40);
            this.cbServisTurleri.Name = "cbServisTurleri";
            this.cbServisTurleri.Size = new System.Drawing.Size(20, 21);
            this.cbServisTurleri.TabIndex = 28;
            this.cbServisTurleri.SelectedIndexChanged += new System.EventHandler(this.cbServisTurleri_SelectedIndexChanged);
            // 
            // txtServisTuru
            // 
            this.txtServisTuru.BackColor = System.Drawing.Color.White;
            this.txtServisTuru.Location = new System.Drawing.Point(347, 40);
            this.txtServisTuru.Multiline = true;
            this.txtServisTuru.Name = "txtServisTuru";
            this.txtServisTuru.ReadOnly = true;
            this.txtServisTuru.Size = new System.Drawing.Size(109, 21);
            this.txtServisTuru.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Servis Türü";
            // 
            // cbUrunler
            // 
            this.cbUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrunler.DropDownWidth = 100;
            this.cbUrunler.FormattingEnabled = true;
            this.cbUrunler.Location = new System.Drawing.Point(587, 40);
            this.cbUrunler.Name = "cbUrunler";
            this.cbUrunler.Size = new System.Drawing.Size(20, 21);
            this.cbUrunler.TabIndex = 31;
            this.cbUrunler.SelectedIndexChanged += new System.EventHandler(this.cbUrunler_SelectedIndexChanged);
            // 
            // txtUrunler
            // 
            this.txtUrunler.BackColor = System.Drawing.Color.White;
            this.txtUrunler.Location = new System.Drawing.Point(480, 40);
            this.txtUrunler.Multiline = true;
            this.txtUrunler.Name = "txtUrunler";
            this.txtUrunler.ReadOnly = true;
            this.txtUrunler.Size = new System.Drawing.Size(109, 21);
            this.txtUrunler.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ürünler";
            // 
            // btnYeni
            // 
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Location = new System.Drawing.Point(53, 145);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(223, 55);
            this.btnYeni.TabIndex = 34;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(347, 145);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(260, 55);
            this.btnKaydet.TabIndex = 35;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtUstaNo
            // 
            this.txtUstaNo.BackColor = System.Drawing.Color.White;
            this.txtUstaNo.Location = new System.Drawing.Point(253, 90);
            this.txtUstaNo.Name = "txtUstaNo";
            this.txtUstaNo.ReadOnly = true;
            this.txtUstaNo.Size = new System.Drawing.Size(1, 20);
            this.txtUstaNo.TabIndex = 39;
            this.txtUstaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(220, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 21);
            this.button1.TabIndex = 37;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUsta
            // 
            this.txtUsta.BackColor = System.Drawing.Color.White;
            this.txtUsta.Location = new System.Drawing.Point(114, 89);
            this.txtUsta.Multiline = true;
            this.txtUsta.Name = "txtUsta";
            this.txtUsta.ReadOnly = true;
            this.txtUsta.Size = new System.Drawing.Size(109, 21);
            this.txtUsta.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Usta";
            // 
            // txtServisBedeli
            // 
            this.txtServisBedeli.BackColor = System.Drawing.Color.White;
            this.txtServisBedeli.Location = new System.Drawing.Point(548, 93);
            this.txtServisBedeli.Multiline = true;
            this.txtServisBedeli.Name = "txtServisBedeli";
            this.txtServisBedeli.ReadOnly = true;
            this.txtServisBedeli.Size = new System.Drawing.Size(59, 21);
            this.txtServisBedeli.TabIndex = 41;
            this.txtServisBedeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtServisBedeli.TextChanged += new System.EventHandler(this.txtServisBedeli_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Servis Bedeli";
            // 
            // txtUrunBedeli
            // 
            this.txtUrunBedeli.BackColor = System.Drawing.Color.White;
            this.txtUrunBedeli.Location = new System.Drawing.Point(548, 68);
            this.txtUrunBedeli.Multiline = true;
            this.txtUrunBedeli.Name = "txtUrunBedeli";
            this.txtUrunBedeli.ReadOnly = true;
            this.txtUrunBedeli.Size = new System.Drawing.Size(59, 21);
            this.txtUrunBedeli.TabIndex = 43;
            this.txtUrunBedeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUrunBedeli.TextChanged += new System.EventHandler(this.txtUrunBedeli_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ürün Bedeli";
            // 
            // txtToplam
            // 
            this.txtToplam.BackColor = System.Drawing.Color.White;
            this.txtToplam.Location = new System.Drawing.Point(480, 118);
            this.txtToplam.Multiline = true;
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(127, 21);
            this.txtToplam.TabIndex = 45;
            this.txtToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Toplam";
            // 
            // txtUrunNo
            // 
            this.txtUrunNo.BackColor = System.Drawing.Color.White;
            this.txtUrunNo.Location = new System.Drawing.Point(524, 19);
            this.txtUrunNo.Name = "txtUrunNo";
            this.txtUrunNo.ReadOnly = true;
            this.txtUrunNo.Size = new System.Drawing.Size(1, 20);
            this.txtUrunNo.TabIndex = 47;
            this.txtUrunNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtServisNo
            // 
            this.txtServisNo.BackColor = System.Drawing.Color.White;
            this.txtServisNo.Location = new System.Drawing.Point(411, 19);
            this.txtServisNo.Name = "txtServisNo";
            this.txtServisNo.ReadOnly = true;
            this.txtServisNo.Size = new System.Drawing.Size(1, 20);
            this.txtServisNo.TabIndex = 48;
            this.txtServisNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvIslemUzayan
            // 
            this.dgvIslemUzayan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvIslemUzayan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIslemUzayan.Location = new System.Drawing.Point(13, 206);
            this.dgvIslemUzayan.Name = "dgvIslemUzayan";
            this.dgvIslemUzayan.Size = new System.Drawing.Size(654, 236);
            this.dgvIslemUzayan.TabIndex = 49;
            // 
            // btnYenile
            // 
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Location = new System.Drawing.Point(13, 448);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(654, 39);
            this.btnYenile.TabIndex = 50;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // frmServisIslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 509);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dgvIslemUzayan);
            this.Controls.Add(this.txtServisNo);
            this.Controls.Add(this.txtUrunNo);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUrunBedeli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServisBedeli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUstaNo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUsta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.cbUrunler);
            this.Controls.Add(this.txtUrunler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbServisTurleri);
            this.Controls.Add(this.txtServisTuru);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCariNo);
            this.Controls.Add(this.btnCariBul);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtIslemTarihi);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServisIslemi";
            this.Text = "Servis İşlemleri";
            this.Load += new System.EventHandler(this.frmServisIslemi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemUzayan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtIslemTarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCariNo;
        private System.Windows.Forms.Button btnCariBul;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbServisTurleri;
        private System.Windows.Forms.TextBox txtServisTuru;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbUrunler;
        private System.Windows.Forms.TextBox txtUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtUstaNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUsta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServisBedeli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunBedeli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrunNo;
        private System.Windows.Forms.TextBox txtServisNo;
        private System.Windows.Forms.DataGridView dgvIslemUzayan;
        private System.Windows.Forms.Button btnYenile;
    }
}