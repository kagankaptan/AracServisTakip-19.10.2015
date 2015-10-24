namespace AracServisTakip
{
    partial class frmUstaEkran
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
            this.btnIslemBitti = new System.Windows.Forms.Button();
            this.cbServisIslemleri = new System.Windows.Forms.ComboBox();
            this.txtServisIslemleri = new System.Windows.Forms.TextBox();
            this.txtUrunler = new System.Windows.Forms.TextBox();
            this.cbUrunler = new System.Windows.Forms.ComboBox();
            this.btnIslemUzadi = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.dgvUstaIslemleri = new System.Windows.Forms.DataGridView();
            this.dgvUrunHareket = new System.Windows.Forms.DataGridView();
            this.btnCariBul = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUstaIslemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunHareket)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIslemBitti
            // 
            this.btnIslemBitti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslemBitti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemBitti.Location = new System.Drawing.Point(428, 378);
            this.btnIslemBitti.Name = "btnIslemBitti";
            this.btnIslemBitti.Size = new System.Drawing.Size(187, 182);
            this.btnIslemBitti.TabIndex = 0;
            this.btnIslemBitti.Text = "İŞLEM BİTTİ";
            this.btnIslemBitti.UseVisualStyleBackColor = true;
            this.btnIslemBitti.Click += new System.EventHandler(this.btnIslemBitti_Click);
            // 
            // cbServisIslemleri
            // 
            this.cbServisIslemleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServisIslemleri.DropDownWidth = 100;
            this.cbServisIslemleri.Enabled = false;
            this.cbServisIslemleri.FormattingEnabled = true;
            this.cbServisIslemleri.Location = new System.Drawing.Point(1012, 393);
            this.cbServisIslemleri.Name = "cbServisIslemleri";
            this.cbServisIslemleri.Size = new System.Drawing.Size(21, 21);
            this.cbServisIslemleri.TabIndex = 1;
            this.cbServisIslemleri.SelectedIndexChanged += new System.EventHandler(this.cbServisIslemleri_SelectedIndexChanged);
            // 
            // txtServisIslemleri
            // 
            this.txtServisIslemleri.BackColor = System.Drawing.Color.White;
            this.txtServisIslemleri.Location = new System.Drawing.Point(886, 393);
            this.txtServisIslemleri.Multiline = true;
            this.txtServisIslemleri.Name = "txtServisIslemleri";
            this.txtServisIslemleri.ReadOnly = true;
            this.txtServisIslemleri.Size = new System.Drawing.Size(127, 21);
            this.txtServisIslemleri.TabIndex = 2;
            // 
            // txtUrunler
            // 
            this.txtUrunler.BackColor = System.Drawing.Color.White;
            this.txtUrunler.Location = new System.Drawing.Point(886, 420);
            this.txtUrunler.Multiline = true;
            this.txtUrunler.Name = "txtUrunler";
            this.txtUrunler.ReadOnly = true;
            this.txtUrunler.Size = new System.Drawing.Size(128, 21);
            this.txtUrunler.TabIndex = 5;
            // 
            // cbUrunler
            // 
            this.cbUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrunler.DropDownWidth = 100;
            this.cbUrunler.Enabled = false;
            this.cbUrunler.FormattingEnabled = true;
            this.cbUrunler.Location = new System.Drawing.Point(1012, 420);
            this.cbUrunler.Name = "cbUrunler";
            this.cbUrunler.Size = new System.Drawing.Size(21, 21);
            this.cbUrunler.TabIndex = 6;
            this.cbUrunler.SelectedIndexChanged += new System.EventHandler(this.cbUrunler_SelectedIndexChanged);
            // 
            // btnIslemUzadi
            // 
            this.btnIslemUzadi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslemUzadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemUzadi.Location = new System.Drawing.Point(718, 446);
            this.btnIslemUzadi.Name = "btnIslemUzadi";
            this.btnIslemUzadi.Size = new System.Drawing.Size(156, 114);
            this.btnIslemUzadi.TabIndex = 7;
            this.btnIslemUzadi.Text = "İŞLEM UZADI";
            this.btnIslemUzadi.UseVisualStyleBackColor = true;
            this.btnIslemUzadi.Click += new System.EventHandler(this.btnIslemUzadi_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Enabled = false;
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Location = new System.Drawing.Point(886, 446);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(159, 114);
            this.btnGonder.TabIndex = 8;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // dgvUstaIslemleri
            // 
            this.dgvUstaIslemleri.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUstaIslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUstaIslemleri.Location = new System.Drawing.Point(207, 85);
            this.dgvUstaIslemleri.Name = "dgvUstaIslemleri";
            this.dgvUstaIslemleri.Size = new System.Drawing.Size(443, 265);
            this.dgvUstaIslemleri.TabIndex = 9;
            // 
            // dgvUrunHareket
            // 
            this.dgvUrunHareket.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUrunHareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunHareket.Location = new System.Drawing.Point(649, 85);
            this.dgvUrunHareket.Name = "dgvUrunHareket";
            this.dgvUrunHareket.Size = new System.Drawing.Size(444, 265);
            this.dgvUrunHareket.TabIndex = 10;
            // 
            // btnCariBul
            // 
            this.btnCariBul.Enabled = false;
            this.btnCariBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariBul.Location = new System.Drawing.Point(1011, 366);
            this.btnCariBul.Name = "btnCariBul";
            this.btnCariBul.Size = new System.Drawing.Size(25, 22);
            this.btnCariBul.TabIndex = 28;
            this.btnCariBul.Text = "...";
            this.btnCariBul.UseVisualStyleBackColor = true;
            this.btnCariBul.Click += new System.EventHandler(this.btnCariBul_Click);
            // 
            // txtCari
            // 
            this.txtCari.BackColor = System.Drawing.Color.White;
            this.txtCari.Location = new System.Drawing.Point(886, 366);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.ReadOnly = true;
            this.txtCari.Size = new System.Drawing.Size(128, 22);
            this.txtCari.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(802, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Cari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(802, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Servis Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(802, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ürünler";
            // 
            // txtPlaka
            // 
            this.txtPlaka.BackColor = System.Drawing.Color.White;
            this.txtPlaka.Location = new System.Drawing.Point(744, 368);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.ReadOnly = true;
            this.txtPlaka.Size = new System.Drawing.Size(1, 20);
            this.txtPlaka.TabIndex = 33;
            this.txtPlaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnYenile
            // 
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(207, 378);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(187, 182);
            this.btnYenile.TabIndex = 34;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // frmUstaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 606);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCariBul);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvUrunHareket);
            this.Controls.Add(this.dgvUstaIslemleri);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnIslemUzadi);
            this.Controls.Add(this.cbUrunler);
            this.Controls.Add(this.txtUrunler);
            this.Controls.Add(this.txtServisIslemleri);
            this.Controls.Add(this.cbServisIslemleri);
            this.Controls.Add(this.btnIslemBitti);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUstaEkran";
            this.Text = "Usta İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUstaEkran_FormClosing);
            this.Load += new System.EventHandler(this.frmUstaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUstaIslemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunHareket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIslemBitti;
        private System.Windows.Forms.ComboBox cbServisIslemleri;
        private System.Windows.Forms.TextBox txtServisIslemleri;
        private System.Windows.Forms.TextBox txtUrunler;
        private System.Windows.Forms.ComboBox cbUrunler;
        private System.Windows.Forms.Button btnIslemUzadi;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.DataGridView dgvUstaIslemleri;
        private System.Windows.Forms.DataGridView dgvUrunHareket;
        private System.Windows.Forms.Button btnCariBul;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Button btnYenile;

    }
}