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
    public partial class frmUrunSorgulama : Form
    {
        public frmUrunSorgulama()
        {
            InitializeComponent();
        }

        private void frmUrunSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cUrunler u = new cUrunler();
            dgvUrun.DataSource = u.UrunleriGetir();
            dgvUrun.Columns[0].Visible = false;
        }

        private void txtUrunAdinaGore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

        private void txtUrunAdinaGore_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            cUrunler u = new cUrunler();
            dt = u.UrunAramaByUrunAdaGore(txtUrunAdinaGore.Text);
            dgvUrun.DataSource = dt;
        }

        private void txtUrunKodunaGore_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            cUrunler u = new cUrunler();
            dt = u.UrunAramaByUrunKodaGore(txtUrunKodunaGore.Text);
            dgvUrun.DataSource = dt;
        }
    }
}
