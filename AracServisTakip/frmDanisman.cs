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
    public partial class frmDanisman : Form
    {
        public frmDanisman()
        {
            InitializeComponent();
        }

        private void frmDanisman_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                    e.Cancel = true;
            }
        }

        private void FormAcikmi(Form AcilacakForm)
        {
            bool Acikmi = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (AcilacakForm.Name == MdiChildren[i].Name)
                {
                    MdiChildren[i].Focus();
                    Acikmi = true;
                }
            }
            if (Acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose(); //Yeni açılan pencere nesnesi hafızadan atılır. Bu işlemi biz yapmasak da Garbage Collector takip edecektir.
            }
        }

        private void çıkılToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void cariKartlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCariler frm = new frmCariler();
            FormAcikmi(frm);
        }

        private void cariSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCariSorgulama frm = new frmCariSorgulama();
            FormAcikmi(frm);
        }

        private void ustaKartlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUstalar frm = new frmUstalar();
            FormAcikmi(frm);
        }

        private void ürünKartlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunler frm = new frmUrunler();
            FormAcikmi(frm);
        }

        private void stokSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunSorgulama frm = new frmUrunSorgulama();
            FormAcikmi(frm);
        }

        private void günlükKasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKasa frm = new frmKasa();
            FormAcikmi(frm);
        }

        private void danışmanKartlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanismanKartlari frm = new frmDanismanKartlari();
            FormAcikmi(frm);
        }

        private void servisİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServisIslemi frm = new frmServisIslemi();
            FormAcikmi(frm);
        }

        private void cariEkstreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCariEkstre frm = new frmCariEkstre();
            FormAcikmi(frm);
        }

        private void kritikSeviyeSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKritikSeviyeSorgulama frm = new frmKritikSeviyeSorgulama();
            FormAcikmi(frm);
        }

        private void gelirGiderAnaliziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServisIslemleriRaporlama frm = new frmServisIslemleriRaporlama();
            FormAcikmi(frm);
        }

        private void frmDanisman_Load(object sender, EventArgs e)
        {
            cSocket s = new cSocket();
            s.runDanismanBildirim();

            cDanisman d = new cDanisman();
            d.DanismanAdSoyadGetirByKullaniciGiriseGore(sslDanismanAdi);

        }

        private void servisİşlemiİptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServisIslemiIptal frm = new frmServisIslemiIptal();
            FormAcikmi(frm);
        }

        private void kasaSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKasaSorgulama frm = new frmKasaSorgulama();
            FormAcikmi(frm);
        }


        
    }
}
