namespace AracServisTakip
{
    partial class frmCariSorgulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlakayaGore = new System.Windows.Forms.TextBox();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCari = new System.Windows.Forms.DataGridView();
            this.txtTelefonaGore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plakaya Göre Arama";
            // 
            // txtPlakayaGore
            // 
            this.txtPlakayaGore.Location = new System.Drawing.Point(93, 60);
            this.txtPlakayaGore.Name = "txtPlakayaGore";
            this.txtPlakayaGore.Size = new System.Drawing.Size(101, 20);
            this.txtPlakayaGore.TabIndex = 0;
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(232, 60);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(101, 20);
            this.txtAdaGore.TabIndex = 1;
            this.txtAdaGore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdaGore_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ada Göre Arama";
            // 
            // dgvCari
            // 
            this.dgvCari.AllowUserToAddRows = false;
            this.dgvCari.AllowUserToDeleteRows = false;
            this.dgvCari.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCari.Location = new System.Drawing.Point(23, 86);
            this.dgvCari.Name = "dgvCari";
            this.dgvCari.ReadOnly = true;
            this.dgvCari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCari.Size = new System.Drawing.Size(539, 389);
            this.dgvCari.TabIndex = 5;
            this.dgvCari.DoubleClick += new System.EventHandler(this.dgvCari_DoubleClick);
            // 
            // txtTelefonaGore
            // 
            this.txtTelefonaGore.Location = new System.Drawing.Point(370, 60);
            this.txtTelefonaGore.Name = "txtTelefonaGore";
            this.txtTelefonaGore.Size = new System.Drawing.Size(105, 20);
            this.txtTelefonaGore.TabIndex = 2;
            this.txtTelefonaGore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonaGore_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefona Göre Arama";
            // 
            // frmCariSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 509);
            this.Controls.Add(this.txtTelefonaGore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCari);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlakayaGore);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCariSorgulama";
            this.Text = "Cari Sorgulama";
            this.Load += new System.EventHandler(this.frmCariSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlakayaGore;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCari;
        private System.Windows.Forms.TextBox txtTelefonaGore;
        private System.Windows.Forms.Label label3;
    }
}