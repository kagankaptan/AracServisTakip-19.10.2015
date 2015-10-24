namespace AracServisTakip
{
    partial class frmUstaSorgulama
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
            this.dgvCari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCari
            // 
            this.dgvCari.AllowUserToAddRows = false;
            this.dgvCari.AllowUserToDeleteRows = false;
            this.dgvCari.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCari.Location = new System.Drawing.Point(0, 0);
            this.dgvCari.Name = "dgvCari";
            this.dgvCari.ReadOnly = true;
            this.dgvCari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCari.Size = new System.Drawing.Size(694, 391);
            this.dgvCari.TabIndex = 6;
            this.dgvCari.DoubleClick += new System.EventHandler(this.dgvCari_DoubleClick);
            // 
            // frmUstaSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 392);
            this.Controls.Add(this.dgvCari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmUstaSorgulama";
            this.Text = "Usta Sorgulama";
            this.Load += new System.EventHandler(this.frmUstaSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCari;
    }
}