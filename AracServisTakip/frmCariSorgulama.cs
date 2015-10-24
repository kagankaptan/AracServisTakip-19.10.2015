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
    public partial class frmCariSorgulama : Form
    {
        public frmCariSorgulama()
        {
            InitializeComponent();
        }

        private void frmCariSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cCari c = new cCari();
            dgvCari.DataSource = c.CarileriGetir();

        }

        private void dgvCari_DoubleClick(object sender, EventArgs e)
        {
            cGenel.CariNo = Convert.ToInt32(dgvCari.SelectedRows[0].Cells[0].Value);
            cGenel.CariAdi = Convert.ToString(dgvCari.SelectedRows[0].Cells[1].Value) + " " + Convert.ToString(dgvCari.SelectedRows[0].Cells[2].Value);
            cGenel.Plaka = Convert.ToString(dgvCari.SelectedRows[0].Cells[3].Value);

            this.Close();
        }

        private void txtTelefonaGore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdaGore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
