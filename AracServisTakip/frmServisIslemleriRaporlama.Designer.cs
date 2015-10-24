namespace AracServisTakip
{
    partial class frmServisIslemleriRaporlama
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
            this.btnCariAdaGore = new System.Windows.Forms.Button();
            this.btnUstaAdaGore = new System.Windows.Forms.Button();
            this.btnRaporlama = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTarih2 = new System.Windows.Forms.TextBox();
            this.dtpTarih2 = new System.Windows.Forms.DateTimePicker();
            this.txtTarih1 = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRaporlama = new System.Windows.Forms.DataGridView();
            this.cbUrunAdaGore = new System.Windows.Forms.ComboBox();
            this.txtUrunAdaGore = new System.Windows.Forms.TextBox();
            this.cbServisAdaGore = new System.Windows.Forms.ComboBox();
            this.txtUstaAdaGore = new System.Windows.Forms.TextBox();
            this.txtCariAdaGore = new System.Windows.Forms.TextBox();
            this.txtServisAdaGore = new System.Windows.Forms.TextBox();
            this.txtCariNo = new System.Windows.Forms.TextBox();
            this.txtUstaNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlama)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCariAdaGore
            // 
            this.btnCariAdaGore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariAdaGore.Location = new System.Drawing.Point(138, 97);
            this.btnCariAdaGore.Name = "btnCariAdaGore";
            this.btnCariAdaGore.Size = new System.Drawing.Size(25, 21);
            this.btnCariAdaGore.TabIndex = 1;
            this.btnCariAdaGore.Text = "...";
            this.btnCariAdaGore.UseVisualStyleBackColor = true;
            this.btnCariAdaGore.Click += new System.EventHandler(this.btnCariAdaGore_Click);
            // 
            // btnUstaAdaGore
            // 
            this.btnUstaAdaGore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUstaAdaGore.Location = new System.Drawing.Point(138, 50);
            this.btnUstaAdaGore.Name = "btnUstaAdaGore";
            this.btnUstaAdaGore.Size = new System.Drawing.Size(25, 21);
            this.btnUstaAdaGore.TabIndex = 0;
            this.btnUstaAdaGore.Text = "...";
            this.btnUstaAdaGore.UseVisualStyleBackColor = true;
            this.btnUstaAdaGore.Click += new System.EventHandler(this.btnUstaAdaGore_Click);
            // 
            // btnRaporlama
            // 
            this.btnRaporlama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporlama.Location = new System.Drawing.Point(327, 93);
            this.btnRaporlama.Name = "btnRaporlama";
            this.btnRaporlama.Size = new System.Drawing.Size(208, 26);
            this.btnRaporlama.TabIndex = 6;
            this.btnRaporlama.Text = "Raporu Getir";
            this.btnRaporlama.UseVisualStyleBackColor = true;
            this.btnRaporlama.Click += new System.EventHandler(this.btnRaporlama_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Bitiş Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Başlangıç Tarihi";
            // 
            // txtTarih2
            // 
            this.txtTarih2.BackColor = System.Drawing.Color.White;
            this.txtTarih2.Location = new System.Drawing.Point(421, 69);
            this.txtTarih2.Name = "txtTarih2";
            this.txtTarih2.ReadOnly = true;
            this.txtTarih2.Size = new System.Drawing.Size(100, 20);
            this.txtTarih2.TabIndex = 53;
            // 
            // dtpTarih2
            // 
            this.dtpTarih2.Location = new System.Drawing.Point(520, 69);
            this.dtpTarih2.Name = "dtpTarih2";
            this.dtpTarih2.Size = new System.Drawing.Size(16, 20);
            this.dtpTarih2.TabIndex = 5;
            this.dtpTarih2.ValueChanged += new System.EventHandler(this.dtpTarih2_ValueChanged);
            // 
            // txtTarih1
            // 
            this.txtTarih1.BackColor = System.Drawing.Color.White;
            this.txtTarih1.Location = new System.Drawing.Point(421, 43);
            this.txtTarih1.Name = "txtTarih1";
            this.txtTarih1.ReadOnly = true;
            this.txtTarih1.Size = new System.Drawing.Size(100, 20);
            this.txtTarih1.TabIndex = 51;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(520, 43);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(16, 20);
            this.dtpTarih.TabIndex = 4;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Cari Ada Göre Raporlama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ürün Ada Göre Raporlama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Usta Ada Göre Raporlama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Servis Ada Göre Raporlama";
            // 
            // dgvRaporlama
            // 
            this.dgvRaporlama.AllowUserToAddRows = false;
            this.dgvRaporlama.AllowUserToDeleteRows = false;
            this.dgvRaporlama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporlama.Location = new System.Drawing.Point(23, 135);
            this.dgvRaporlama.Name = "dgvRaporlama";
            this.dgvRaporlama.ReadOnly = true;
            this.dgvRaporlama.Size = new System.Drawing.Size(539, 229);
            this.dgvRaporlama.TabIndex = 45;
            // 
            // cbUrunAdaGore
            // 
            this.cbUrunAdaGore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrunAdaGore.DropDownWidth = 100;
            this.cbUrunAdaGore.FormattingEnabled = true;
            this.cbUrunAdaGore.Location = new System.Drawing.Point(283, 51);
            this.cbUrunAdaGore.Name = "cbUrunAdaGore";
            this.cbUrunAdaGore.Size = new System.Drawing.Size(20, 21);
            this.cbUrunAdaGore.TabIndex = 2;
            this.cbUrunAdaGore.SelectedIndexChanged += new System.EventHandler(this.cbUrunAdaGore_SelectedIndexChanged);
            // 
            // txtUrunAdaGore
            // 
            this.txtUrunAdaGore.BackColor = System.Drawing.Color.White;
            this.txtUrunAdaGore.Location = new System.Drawing.Point(187, 51);
            this.txtUrunAdaGore.Multiline = true;
            this.txtUrunAdaGore.Name = "txtUrunAdaGore";
            this.txtUrunAdaGore.ReadOnly = true;
            this.txtUrunAdaGore.Size = new System.Drawing.Size(100, 21);
            this.txtUrunAdaGore.TabIndex = 43;
            // 
            // cbServisAdaGore
            // 
            this.cbServisAdaGore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServisAdaGore.DropDownWidth = 100;
            this.cbServisAdaGore.FormattingEnabled = true;
            this.cbServisAdaGore.Location = new System.Drawing.Point(284, 97);
            this.cbServisAdaGore.Name = "cbServisAdaGore";
            this.cbServisAdaGore.Size = new System.Drawing.Size(20, 21);
            this.cbServisAdaGore.TabIndex = 3;
            this.cbServisAdaGore.SelectedIndexChanged += new System.EventHandler(this.cbServisAdaGore_SelectedIndexChanged);
            // 
            // txtUstaAdaGore
            // 
            this.txtUstaAdaGore.BackColor = System.Drawing.Color.White;
            this.txtUstaAdaGore.Location = new System.Drawing.Point(39, 50);
            this.txtUstaAdaGore.Multiline = true;
            this.txtUstaAdaGore.Name = "txtUstaAdaGore";
            this.txtUstaAdaGore.ReadOnly = true;
            this.txtUstaAdaGore.Size = new System.Drawing.Size(100, 21);
            this.txtUstaAdaGore.TabIndex = 2;
            // 
            // txtCariAdaGore
            // 
            this.txtCariAdaGore.BackColor = System.Drawing.Color.White;
            this.txtCariAdaGore.Location = new System.Drawing.Point(39, 97);
            this.txtCariAdaGore.Multiline = true;
            this.txtCariAdaGore.Name = "txtCariAdaGore";
            this.txtCariAdaGore.ReadOnly = true;
            this.txtCariAdaGore.Size = new System.Drawing.Size(100, 21);
            this.txtCariAdaGore.TabIndex = 7;
            // 
            // txtServisAdaGore
            // 
            this.txtServisAdaGore.BackColor = System.Drawing.Color.White;
            this.txtServisAdaGore.Location = new System.Drawing.Point(187, 97);
            this.txtServisAdaGore.Multiline = true;
            this.txtServisAdaGore.Name = "txtServisAdaGore";
            this.txtServisAdaGore.ReadOnly = true;
            this.txtServisAdaGore.Size = new System.Drawing.Size(100, 21);
            this.txtServisAdaGore.TabIndex = 39;
            // 
            // txtCariNo
            // 
            this.txtCariNo.Location = new System.Drawing.Point(31, 76);
            this.txtCariNo.Name = "txtCariNo";
            this.txtCariNo.Size = new System.Drawing.Size(1, 20);
            this.txtCariNo.TabIndex = 62;
            // 
            // txtUstaNo
            // 
            this.txtUstaNo.Location = new System.Drawing.Point(31, 30);
            this.txtUstaNo.Name = "txtUstaNo";
            this.txtUstaNo.Size = new System.Drawing.Size(1, 20);
            this.txtUstaNo.TabIndex = 61;
            // 
            // frmServisIslemleriRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 391);
            this.Controls.Add(this.txtCariNo);
            this.Controls.Add(this.txtUstaNo);
            this.Controls.Add(this.btnCariAdaGore);
            this.Controls.Add(this.btnUstaAdaGore);
            this.Controls.Add(this.btnRaporlama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTarih2);
            this.Controls.Add(this.dtpTarih2);
            this.Controls.Add(this.txtTarih1);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRaporlama);
            this.Controls.Add(this.cbUrunAdaGore);
            this.Controls.Add(this.txtUrunAdaGore);
            this.Controls.Add(this.cbServisAdaGore);
            this.Controls.Add(this.txtUstaAdaGore);
            this.Controls.Add(this.txtCariAdaGore);
            this.Controls.Add(this.txtServisAdaGore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServisIslemleriRaporlama";
            this.Text = "Servis İşlemleri Raporlama";
            this.Load += new System.EventHandler(this.frmServisIslemleriRaporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCariAdaGore;
        private System.Windows.Forms.Button btnUstaAdaGore;
        private System.Windows.Forms.Button btnRaporlama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTarih2;
        private System.Windows.Forms.DateTimePicker dtpTarih2;
        private System.Windows.Forms.TextBox txtTarih1;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRaporlama;
        private System.Windows.Forms.ComboBox cbUrunAdaGore;
        private System.Windows.Forms.TextBox txtUrunAdaGore;
        private System.Windows.Forms.ComboBox cbServisAdaGore;
        private System.Windows.Forms.TextBox txtUstaAdaGore;
        private System.Windows.Forms.TextBox txtCariAdaGore;
        private System.Windows.Forms.TextBox txtServisAdaGore;
        private System.Windows.Forms.TextBox txtCariNo;
        private System.Windows.Forms.TextBox txtUstaNo;
    }
}