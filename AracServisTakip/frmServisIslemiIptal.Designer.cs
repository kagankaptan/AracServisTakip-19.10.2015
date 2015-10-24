namespace AracServisTakip
{
    partial class frmServisIslemiIptal
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
            this.lvHareketler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlakayaGore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTarih1 = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtCariHareketNo = new System.Windows.Forms.TextBox();
            this.txtUrunHareketNo = new System.Windows.Forms.TextBox();
            this.txtServisHareketNo = new System.Windows.Forms.TextBox();
            this.txtBorc = new System.Windows.Forms.TextBox();
            this.txtAlacak = new System.Windows.Forms.TextBox();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtCariNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvHareketler
            // 
            this.lvHareketler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvHareketler.FullRowSelect = true;
            this.lvHareketler.Location = new System.Drawing.Point(237, 29);
            this.lvHareketler.Name = "lvHareketler";
            this.lvHareketler.Size = new System.Drawing.Size(479, 308);
            this.lvHareketler.TabIndex = 0;
            this.lvHareketler.UseCompatibleStateImageBehavior = false;
            this.lvHareketler.View = System.Windows.Forms.View.Details;
            this.lvHareketler.DoubleClick += new System.EventHandler(this.lvHareketler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "HareketNo";
            this.columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tarih";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müşteri";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Plaka";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Borç";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Alacak";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "UrunHareketNo";
            this.columnHeader7.Width = 1;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ServisHareketNo";
            this.columnHeader8.Width = 1;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "CariNo";
            this.columnHeader9.Width = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Plakaya Göre Arama";
            // 
            // txtPlakayaGore
            // 
            this.txtPlakayaGore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPlakayaGore.Location = new System.Drawing.Point(116, 47);
            this.txtPlakayaGore.Name = "txtPlakayaGore";
            this.txtPlakayaGore.Size = new System.Drawing.Size(99, 20);
            this.txtPlakayaGore.TabIndex = 41;
            this.txtPlakayaGore.TextChanged += new System.EventHandler(this.txtPlakayaGore_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Başlangıç Tarihi";
            // 
            // txtTarih1
            // 
            this.txtTarih1.Location = new System.Drawing.Point(115, 73);
            this.txtTarih1.Name = "txtTarih1";
            this.txtTarih1.ReadOnly = true;
            this.txtTarih1.Size = new System.Drawing.Size(100, 20);
            this.txtTarih1.TabIndex = 57;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(214, 73);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(16, 20);
            this.dtpTarih.TabIndex = 56;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // txtCariHareketNo
            // 
            this.txtCariHareketNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCariHareketNo.Enabled = false;
            this.txtCariHareketNo.Location = new System.Drawing.Point(126, 341);
            this.txtCariHareketNo.Name = "txtCariHareketNo";
            this.txtCariHareketNo.Size = new System.Drawing.Size(1, 20);
            this.txtCariHareketNo.TabIndex = 62;
            // 
            // txtUrunHareketNo
            // 
            this.txtUrunHareketNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUrunHareketNo.Enabled = false;
            this.txtUrunHareketNo.Location = new System.Drawing.Point(153, 341);
            this.txtUrunHareketNo.Name = "txtUrunHareketNo";
            this.txtUrunHareketNo.Size = new System.Drawing.Size(1, 20);
            this.txtUrunHareketNo.TabIndex = 63;
            // 
            // txtServisHareketNo
            // 
            this.txtServisHareketNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtServisHareketNo.Enabled = false;
            this.txtServisHareketNo.Location = new System.Drawing.Point(180, 341);
            this.txtServisHareketNo.Name = "txtServisHareketNo";
            this.txtServisHareketNo.Size = new System.Drawing.Size(1, 20);
            this.txtServisHareketNo.TabIndex = 64;
            // 
            // txtBorc
            // 
            this.txtBorc.BackColor = System.Drawing.SystemColors.Control;
            this.txtBorc.Location = new System.Drawing.Point(151, 206);
            this.txtBorc.Name = "txtBorc";
            this.txtBorc.ReadOnly = true;
            this.txtBorc.Size = new System.Drawing.Size(64, 20);
            this.txtBorc.TabIndex = 65;
            this.txtBorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAlacak
            // 
            this.txtAlacak.BackColor = System.Drawing.SystemColors.Control;
            this.txtAlacak.Location = new System.Drawing.Point(151, 232);
            this.txtAlacak.Name = "txtAlacak";
            this.txtAlacak.ReadOnly = true;
            this.txtAlacak.Size = new System.Drawing.Size(64, 20);
            this.txtAlacak.TabIndex = 66;
            this.txtAlacak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMusteri
            // 
            this.txtMusteri.BackColor = System.Drawing.SystemColors.Control;
            this.txtMusteri.Location = new System.Drawing.Point(115, 154);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.ReadOnly = true;
            this.txtMusteri.Size = new System.Drawing.Size(100, 20);
            this.txtMusteri.TabIndex = 67;
            // 
            // txtPlaka
            // 
            this.txtPlaka.BackColor = System.Drawing.SystemColors.Control;
            this.txtPlaka.Location = new System.Drawing.Point(115, 180);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.ReadOnly = true;
            this.txtPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtPlaka.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Müşteri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Plaka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Borç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Alacak";
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(30, 274);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(185, 50);
            this.btnSil.TabIndex = 73;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtCariNo
            // 
            this.txtCariNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCariNo.Enabled = false;
            this.txtCariNo.Location = new System.Drawing.Point(207, 341);
            this.txtCariNo.Name = "txtCariNo";
            this.txtCariNo.Size = new System.Drawing.Size(1, 20);
            this.txtCariNo.TabIndex = 74;
            // 
            // frmServisIslemiIptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 373);
            this.Controls.Add(this.txtCariNo);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.txtAlacak);
            this.Controls.Add(this.txtBorc);
            this.Controls.Add(this.txtServisHareketNo);
            this.Controls.Add(this.txtUrunHareketNo);
            this.Controls.Add(this.txtCariHareketNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTarih1);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPlakayaGore);
            this.Controls.Add(this.lvHareketler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServisIslemiIptal";
            this.Text = "Servis İptal İşlemi";
            this.Load += new System.EventHandler(this.frmServisIslemiIptal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvHareketler;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlakayaGore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTarih1;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox txtCariHareketNo;
        private System.Windows.Forms.TextBox txtUrunHareketNo;
        private System.Windows.Forms.TextBox txtServisHareketNo;
        private System.Windows.Forms.TextBox txtBorc;
        private System.Windows.Forms.TextBox txtAlacak;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtCariNo;
    }
}