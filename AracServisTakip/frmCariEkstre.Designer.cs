namespace AracServisTakip
{
    partial class frmCariEkstre
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
            this.btnEkstreGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCariNo = new System.Windows.Forms.TextBox();
            this.txtCariAdSoyad = new System.Windows.Forms.TextBox();
            this.btnCariBul = new System.Windows.Forms.Button();
            this.dgvEkstreGetir = new System.Windows.Forms.DataGridView();
            this.txtTarih2 = new System.Windows.Forms.TextBox();
            this.txtTarih1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEkstreGetir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkstreGetir
            // 
            this.btnEkstreGetir.BackColor = System.Drawing.Color.White;
            this.btnEkstreGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkstreGetir.Location = new System.Drawing.Point(130, 117);
            this.btnEkstreGetir.Name = "btnEkstreGetir";
            this.btnEkstreGetir.Size = new System.Drawing.Size(145, 23);
            this.btnEkstreGetir.TabIndex = 19;
            this.btnEkstreGetir.Text = "Cari Ekstre Getir";
            this.btnEkstreGetir.UseVisualStyleBackColor = false;
            this.btnEkstreGetir.Click += new System.EventHandler(this.btnEkstreGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cari Adı Soyadı";
            // 
            // txtCariNo
            // 
            this.txtCariNo.BackColor = System.Drawing.Color.White;
            this.txtCariNo.Location = new System.Drawing.Point(3, 12);
            this.txtCariNo.Name = "txtCariNo";
            this.txtCariNo.ReadOnly = true;
            this.txtCariNo.Size = new System.Drawing.Size(1, 20);
            this.txtCariNo.TabIndex = 13;
            // 
            // txtCariAdSoyad
            // 
            this.txtCariAdSoyad.BackColor = System.Drawing.Color.White;
            this.txtCariAdSoyad.Location = new System.Drawing.Point(144, 23);
            this.txtCariAdSoyad.Name = "txtCariAdSoyad";
            this.txtCariAdSoyad.ReadOnly = true;
            this.txtCariAdSoyad.Size = new System.Drawing.Size(98, 20);
            this.txtCariAdSoyad.TabIndex = 12;
            // 
            // btnCariBul
            // 
            this.btnCariBul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCariBul.Location = new System.Drawing.Point(241, 23);
            this.btnCariBul.Name = "btnCariBul";
            this.btnCariBul.Size = new System.Drawing.Size(22, 20);
            this.btnCariBul.TabIndex = 11;
            this.btnCariBul.Text = "...";
            this.btnCariBul.UseVisualStyleBackColor = true;
            this.btnCariBul.Click += new System.EventHandler(this.btnCariBul_Click);
            // 
            // dgvEkstreGetir
            // 
            this.dgvEkstreGetir.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEkstreGetir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEkstreGetir.Location = new System.Drawing.Point(12, 146);
            this.dgvEkstreGetir.Name = "dgvEkstreGetir";
            this.dgvEkstreGetir.Size = new System.Drawing.Size(418, 254);
            this.dgvEkstreGetir.TabIndex = 10;
            // 
            // txtTarih2
            // 
            this.txtTarih2.Location = new System.Drawing.Point(145, 88);
            this.txtTarih2.Name = "txtTarih2";
            this.txtTarih2.Size = new System.Drawing.Size(100, 20);
            this.txtTarih2.TabIndex = 26;
            // 
            // txtTarih1
            // 
            this.txtTarih1.Location = new System.Drawing.Point(145, 62);
            this.txtTarih1.Name = "txtTarih1";
            this.txtTarih1.Size = new System.Drawing.Size(100, 20);
            this.txtTarih1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "İşlem Tarihleri Aralığını Seçiniz";
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(242, 88);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(19, 20);
            this.dtp2.TabIndex = 23;
            this.dtp2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(242, 62);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(19, 20);
            this.dtp1.TabIndex = 22;
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // frmCariEkstre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 419);
            this.Controls.Add(this.txtTarih2);
            this.Controls.Add(this.txtTarih1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.btnEkstreGetir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCariNo);
            this.Controls.Add(this.txtCariAdSoyad);
            this.Controls.Add(this.btnCariBul);
            this.Controls.Add(this.dgvEkstreGetir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCariEkstre";
            this.Text = "Cari Ekstre";
            this.Load += new System.EventHandler(this.frmCariEkstre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEkstreGetir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkstreGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCariNo;
        private System.Windows.Forms.TextBox txtCariAdSoyad;
        private System.Windows.Forms.Button btnCariBul;
        private System.Windows.Forms.DataGridView dgvEkstreGetir;
        private System.Windows.Forms.TextBox txtTarih2;
        private System.Windows.Forms.TextBox txtTarih1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
    }
}