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
    public partial class frmUstaSorgulamaByMesgulDurumuna : Form
    {
        public frmUstaSorgulamaByMesgulDurumuna()
        {
            InitializeComponent();
        }

        private void frmUstaSorgulamaByMesgulDurumuna_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cUsta u = new cUsta();
            dgvCari.DataSource = u.UstalariGetirByMesgulDurumunaGore();
        }

        private void dgvCari_DoubleClick(object sender, EventArgs e)
        {
            cGenel.UstaNo = Convert.ToInt32(dgvCari.SelectedRows[0].Cells[0].Value);
            cGenel.UstaAdi = Convert.ToString(dgvCari.SelectedRows[0].Cells[1].Value) + " " + Convert.ToString(dgvCari.SelectedRows[0].Cells[2].Value);
            this.Close();
        }
    }
}
