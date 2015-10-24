namespace AracServisTakip
{
    partial class frmUrunSorgulama
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
            this.dgvUrun = new System.Windows.Forms.DataGridView();
            this.txtUrunAdinaGore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunKodunaGore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrun
            // 
            this.dgvUrun.AllowUserToAddRows = false;
            this.dgvUrun.AllowUserToDeleteRows = false;
            this.dgvUrun.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrun.Location = new System.Drawing.Point(32, 84);
            this.dgvUrun.Name = "dgvUrun";
            this.dgvUrun.ReadOnly = true;
            this.dgvUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrun.Size = new System.Drawing.Size(539, 389);
            this.dgvUrun.TabIndex = 12;
            // 
            // txtUrunAdinaGore
            // 
            this.txtUrunAdinaGore.Location = new System.Drawing.Point(290, 58);
            this.txtUrunAdinaGore.Name = "txtUrunAdinaGore";
            this.txtUrunAdinaGore.Size = new System.Drawing.Size(142, 20);
            this.txtUrunAdinaGore.TabIndex = 8;
            this.txtUrunAdinaGore.TextChanged += new System.EventHandler(this.txtUrunAdinaGore_TextChanged);
            this.txtUrunAdinaGore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdinaGore_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ürün Adına Göre Arama";
            // 
            // txtUrunKodunaGore
            // 
            this.txtUrunKodunaGore.Location = new System.Drawing.Point(131, 58);
            this.txtUrunKodunaGore.Name = "txtUrunKodunaGore";
            this.txtUrunKodunaGore.Size = new System.Drawing.Size(133, 20);
            this.txtUrunKodunaGore.TabIndex = 7;
            this.txtUrunKodunaGore.TextChanged += new System.EventHandler(this.txtUrunKodunaGore_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ürün Koduna  Göre Arama";
            // 
            // frmUrunSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 497);
            this.Controls.Add(this.dgvUrun);
            this.Controls.Add(this.txtUrunAdinaGore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunKodunaGore);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUrunSorgulama";
            this.Text = "Ürün Sorgulama";
            this.Load += new System.EventHandler(this.frmUrunSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrun;
        private System.Windows.Forms.TextBox txtUrunAdinaGore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunKodunaGore;
        private System.Windows.Forms.Label label1;
    }
}