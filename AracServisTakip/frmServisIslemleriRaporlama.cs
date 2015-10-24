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
    public partial class frmServisIslemleriRaporlama : Form
    {
        public frmServisIslemleriRaporlama()
        {
            InitializeComponent();
        }

        private void frmServisIslemleriRaporlama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cUsta u = new cUsta();
            //u.UstalarıGetirRaporlama(cbUstaAdaGore);
            cCari c = new cCari();
            //c.CarileriGetirRaporlama(cbCariAdaGore);
            cUrunler urun = new cUrunler();
            urun.UrunleriGetirRaporlama(cbUrunAdaGore);
            cServisIslemleri sı = new cServisIslemleri();
            sı.ServisGetirRaporlama(cbServisAdaGore);
            txtTarih1.Text = DateTime.Now.ToShortDateString();
            txtTarih2.Text = DateTime.Now.ToShortDateString();
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih1.Text = dtpTarih.Value.ToShortDateString();
        }

        private void dtpTarih2_ValueChanged(object sender, EventArgs e)
        {
            txtTarih2.Text = dtpTarih2.Value.ToShortDateString();
        }

        private void cbUrunAdaGore_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUrunAdaGore.Text = cbUrunAdaGore.SelectedItem.ToString();
        }

        private void cbServisAdaGore_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtServisAdaGore.Text = cbServisAdaGore.SelectedItem.ToString();
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            cServisHareket sh = new cServisHareket();
            DataTable dt = new DataTable();
            //if (txtCariNo.Text != "" && txtUstaNo.Text != "" && txtUrunAdaGore.Text != "" && txtServisAdaGore.Text != "")
            //{
                if (txtServisAdaGore.Text.Trim() == "" && txtUrunAdaGore.Text.Trim() == "" && txtUstaAdaGore.Text.Trim() == "")
                    dt = sh.CariAdaGoreRaporlama(Convert.ToInt32(txtCariNo.Text), Convert.ToDateTime(txtTarih1.Text), Convert.ToDateTime(txtTarih2.Text));
                else if (txtUrunAdaGore.Text.Trim() == "" && txtUstaAdaGore.Text.Trim() == "" && txtCariAdaGore.Text.Trim() == "")
                    dt = sh.ServisAdaGoreRaporlama(txtServisAdaGore.Text, Convert.ToDateTime(txtTarih1.Text), Convert.ToDateTime(txtTarih2.Text));
                else if (txtServisAdaGore.Text.Trim() == "" && txtCariAdaGore.Text.Trim() == "" && txtUstaAdaGore.Text.Trim() == "")
                    dt = sh.UrunAdaGoreRaporlama(txtUrunAdaGore.Text, Convert.ToDateTime(txtTarih1.Text), Convert.ToDateTime(txtTarih2.Text));
                else if (txtServisAdaGore.Text.Trim() == "" && txtCariAdaGore.Text.Trim() == "" && txtUrunAdaGore.Text.Trim() == "")
                    dt = sh.UstaAdaGoreRaporlama(Convert.ToInt32(txtUstaNo.Text), Convert.ToDateTime(txtTarih1.Text), Convert.ToDateTime(txtTarih2.Text));
                else if (txtCariAdaGore.Text.Trim() == "" && txtUrunAdaGore.Text.Trim() == "")
                    dt = sh.ServisUstaAdaGoreRaporlama(Convert.ToInt32(txtUstaNo.Text), txtServisAdaGore.Text, Convert.ToDateTime(txtTarih1.Text), Convert.ToDateTime(txtTarih2.Text));
                else if (txtUrunAdaGore.Text.Trim() == "" && txtUstaAdaGore.Text.Trim() == "")
                    dt = sh.CariServisAdaGoreRaporlama(txtServisAdaGore.Text, Convert.ToInt32(txtCariNo.Text), Convert.ToDateTime(txtTarih1.Text), Convert.ToDateTime(txtTarih2.Text));
                else if (txtUrunAdaGore.Text.Trim() == "" && txtServisAdaGore.Text.Trim() == "")
                    dt = sh.CariUstaAdaGoreRaporlama(Convert.ToInt32(txtUstaNo.Text), Convert.ToInt32(txtCariNo.Text), Convert.ToDateTime(txtTarih1.Text), Convert.ToDateTime(txtTarih2.Text));
                else if (txtUrunAdaGore.Text.Trim() == "")
                    dt = sh.ServisCariUstaAdaGoreRaporlama(txtServisAdaGore.Text, Convert.ToInt32(txtCariNo.Text), Convert.ToInt32(txtUstaNo.Text), Convert.ToDateTime(txtTarih1.Text), Convert.ToDateTime(txtTarih2.Text));
            //}



                //Kursta yaotıklarım test edilmesi gerekiyor
            else if (txtCariAdaGore.Text.Trim() == "" && txtUstaAdaGore.Text.Trim() == "")
                dt = sh.ServisUrunAdaGoreRaporlama(txtServisAdaGore.Text, txtUrunAdaGore.Text, Convert.ToDateTime(txtTarih1.Text), Convert.ToDateTime(txtTarih2.Text));
            else if (txtCariAdaGore.Text.Trim() == "" && txtServisAdaGore.Text.Trim() == "")
                dt = sh.UstaUrunAdaGoreRaporlama(Convert.ToInt32(txtUstaNo.Text), txtUrunAdaGore.Text, Convert.ToDateTime(txtTarih1.Text), Convert.ToDateTime(txtTarih2.Text));
            dgvRaporlama.DataSource = dt;
            txtCariAdaGore.Clear();
            txtCariNo.Clear();
            txtServisAdaGore.Clear();
            txtUrunAdaGore.Clear();
            txtUstaAdaGore.Clear();
            
        }

        private void btnUstaAdaGore_Click(object sender, EventArgs e)
        {
            frmUstaSorgulama frm = new frmUstaSorgulama();
            frm.ShowDialog();
            txtUstaAdaGore.Text = cGenel.UstaAdi;
            txtUstaNo.Text = cGenel.UstaNo.ToString();
        }

        private void btnCariAdaGore_Click(object sender, EventArgs e)
        {
            frmCariSorgulama frm = new frmCariSorgulama();
            frm.ShowDialog();
            txtCariAdaGore.Text = cGenel.CariAdi;
            txtCariNo.Text = cGenel.CariNo.ToString();
        }
    }
}
