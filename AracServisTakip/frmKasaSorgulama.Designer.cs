namespace AracServisTakip
{
    partial class frmKasaSorgulama
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
            this.dgvHareketler = new System.Windows.Forms.DataGridView();
            this.txtMusteriAdinaGore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.txtTarih2 = new System.Windows.Forms.TextBox();
            this.dtpTarih1 = new System.Windows.Forms.DateTimePicker();
            this.txtTarih1 = new System.Windows.Forms.TextBox();
            this.TelefonaGore = new System.Windows.Forms.Label();
            this.txtBelgeyeGore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIslemTuruneGore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHareketler
            // 
            this.dgvHareketler.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHareketler.Location = new System.Drawing.Point(156, 36);
            this.dgvHareketler.Name = "dgvHareketler";
            this.dgvHareketler.Size = new System.Drawing.Size(693, 178);
            this.dgvHareketler.TabIndex = 17;
            // 
            // txtMusteriAdinaGore
            // 
            this.txtMusteriAdinaGore.Location = new System.Drawing.Point(10, 120);
            this.txtMusteriAdinaGore.Name = "txtMusteriAdinaGore";
            this.txtMusteriAdinaGore.Size = new System.Drawing.Size(125, 20);
            this.txtMusteriAdinaGore.TabIndex = 14;
            this.txtMusteriAdinaGore.TextChanged += new System.EventHandler(this.txtMusteriAdinaGore_TextChanged);
            this.txtMusteriAdinaGore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriAdinaGore_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Müşteri Adına Göre";
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Location = new System.Drawing.Point(113, 194);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(20, 20);
            this.dtpTarih2.TabIndex = 16;
            this.dtpTarih2.ValueChanged += new System.EventHandler(this.dtpTarih2_ValueChanged);
            // 
            // txtTarih2
            // 
            this.txtTarih2.Location = new System.Drawing.Point(10, 194);
            this.txtTarih2.Name = "txtTarih2";
            this.txtTarih2.ReadOnly = true;
            this.txtTarih2.Size = new System.Drawing.Size(104, 20);
            this.txtTarih2.TabIndex = 23;
            this.txtTarih2.TextChanged += new System.EventHandler(this.txtTarih2_TextChanged);
            // 
            // dtpTarih1
            // 
            this.dtpTarih1.Location = new System.Drawing.Point(113, 168);
            this.dtpTarih1.Name = "dtpTarih1";
            this.dtpTarih1.Size = new System.Drawing.Size(20, 20);
            this.dtpTarih1.TabIndex = 15;
            this.dtpTarih1.ValueChanged += new System.EventHandler(this.dtpTarih1_ValueChanged);
            // 
            // txtTarih1
            // 
            this.txtTarih1.Location = new System.Drawing.Point(10, 168);
            this.txtTarih1.Name = "txtTarih1";
            this.txtTarih1.ReadOnly = true;
            this.txtTarih1.Size = new System.Drawing.Size(104, 20);
            this.txtTarih1.TabIndex = 22;
            this.txtTarih1.TextChanged += new System.EventHandler(this.txtTarih1_TextChanged);
            // 
            // TelefonaGore
            // 
            this.TelefonaGore.AutoSize = true;
            this.TelefonaGore.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.TelefonaGore.Location = new System.Drawing.Point(22, 152);
            this.TelefonaGore.Name = "TelefonaGore";
            this.TelefonaGore.Size = new System.Drawing.Size(101, 13);
            this.TelefonaGore.TabIndex = 21;
            this.TelefonaGore.Text = "Tarihler Arası Arama";
            // 
            // txtBelgeyeGore
            // 
            this.txtBelgeyeGore.Location = new System.Drawing.Point(10, 78);
            this.txtBelgeyeGore.Name = "txtBelgeyeGore";
            this.txtBelgeyeGore.Size = new System.Drawing.Size(125, 20);
            this.txtBelgeyeGore.TabIndex = 13;
            this.txtBelgeyeGore.TextChanged += new System.EventHandler(this.txtBelgeyeGore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Belge İçeriğine Göre";
            // 
            // txtIslemTuruneGore
            // 
            this.txtIslemTuruneGore.Location = new System.Drawing.Point(10, 36);
            this.txtIslemTuruneGore.Name = "txtIslemTuruneGore";
            this.txtIslemTuruneGore.Size = new System.Drawing.Size(125, 20);
            this.txtIslemTuruneGore.TabIndex = 12;
            this.txtIslemTuruneGore.TextChanged += new System.EventHandler(this.txtIslemTuruneGore_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "İşlem Türüne Göre";
            // 
            // frmKasaSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 238);
            this.Controls.Add(this.dgvHareketler);
            this.Controls.Add(this.txtMusteriAdinaGore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTarih2);
            this.Controls.Add(this.txtTarih2);
            this.Controls.Add(this.dtpTarih1);
            this.Controls.Add(this.txtTarih1);
            this.Controls.Add(this.TelefonaGore);
            this.Controls.Add(this.txtBelgeyeGore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIslemTuruneGore);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasaSorgulama";
            this.Text = "Kasa Sorgulama";
            this.Load += new System.EventHandler(this.frmKasaSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHareketler;
        private System.Windows.Forms.TextBox txtMusteriAdinaGore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.TextBox txtTarih2;
        private System.Windows.Forms.DateTimePicker dtpTarih1;
        private System.Windows.Forms.TextBox txtTarih1;
        private System.Windows.Forms.Label TelefonaGore;
        private System.Windows.Forms.TextBox txtBelgeyeGore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIslemTuruneGore;
        private System.Windows.Forms.Label label5;
    }
}