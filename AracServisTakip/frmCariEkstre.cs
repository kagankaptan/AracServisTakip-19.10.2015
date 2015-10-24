using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracServisTakip
{
    public partial class frmCariEkstre : Form
    {
        public frmCariEkstre()
        {
            InitializeComponent();
        }

        private void frmCariEkstre_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            btnEkstreGetir.Enabled = false;
            txtTarih1.Text = DateTime.Now.ToShortDateString();
            txtTarih2.Text = DateTime.Now.ToShortDateString();
        }

        private void btnEkstreGetir_Click(object sender, EventArgs e)
        {
            cCariHareket ch = new cCariHareket();
            DataTable dt = new DataTable();
            if (txtTarih1.Text.Trim() != "" && txtTarih2.Text.Trim() != "")
            {
                dt = ch.CariEkstre(Convert.ToInt32(txtCariNo.Text), Convert.ToDateTime(txtTarih1.Text), Convert.ToDateTime(txtTarih2.Text));
                dgvEkstreGetir.DataSource = dt;
            }
            else MessageBox.Show("Tarih Aralığı seçimini yapmadınız.","UYARI");
        }

        private void btnCariBul_Click(object sender, EventArgs e)
        {
            frmCariSorgulama frm = new frmCariSorgulama();
            frm.ShowDialog();
            txtCariAdSoyad.Text = cGenel.CariAdi;
            txtCariNo.Text = Convert.ToString(cGenel.CariNo);
            btnEkstreGetir.Enabled = true;
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            txtTarih1.Text = dtp1.Value.ToShortDateString();
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            txtTarih2.Text = dtp2.Value.ToShortDateString();
        }

        
    }
}
