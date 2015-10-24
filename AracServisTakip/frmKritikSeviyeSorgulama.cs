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
    public partial class frmKritikSeviyeSorgulama : Form
    {
        public frmKritikSeviyeSorgulama()
        {
            InitializeComponent();
        }

        private void frmKritikSeviyeSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();
            u.KritikSeviyeSorgulama(lvUrunler);
        }
    }
}
