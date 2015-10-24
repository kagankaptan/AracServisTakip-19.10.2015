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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            txtUrunAdi.Clear();
            txtUrunKodu.Clear();
            txtMiktar.Clear();
            txtBirimFiyat.Clear();
            txtUrunNo.Clear();
            txtKritikSeviye.Clear();
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            btnKaydet.Enabled = false;
            btnSil.Enabled = false;
            btnDegistir.Enabled = false;
            cUrunler u = new cUrunler();
            u.UrunleriGetir(lvUrunler);
            txtUrunKodu.Focus();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            Temizle();
            txtUrunKodu.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();
            if (txtUrunKodu.Text.Trim() != "" && txtUrunAdi.Text.Trim() != "" && txtMiktar.Text.Trim() != "" && txtBirimFiyat.Text.Trim() != "")
            {
                if (u.UrunKontrol(txtUrunKodu.Text))
                {
                    MessageBox.Show("Ürün daha önce kayıt edildi");
                    Temizle();
                }
                else
                {
                    u.UrunKodu = txtUrunKodu.Text;
                    u.UrunAd = txtUrunAdi.Text;
                    u.Miktar = Convert.ToInt32(txtMiktar.Text);
                    if (txtKritikSeviye.Text.Trim() == "")
                    {
                        u.KritikSeviye = 5;
                    }
                    else
                        u.KritikSeviye = Convert.ToInt32(txtKritikSeviye.Text);
                    u.BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text);

                    if (u.UrunEkle(u))
                    {
                        MessageBox.Show("Ürün kaydedildi");
                        u.UrunleriGetir(lvUrunler);
                        Temizle();
                        txtUrunKodu.Focus();
                        btnKaydet.Enabled = false;
                        btnSil.Enabled = false;
                        btnDegistir.Enabled = false;
                    }
                }

            }
            else
                MessageBox.Show("Lütfen Alanları Doldurunuz");
        }

        private void lvUrunler_DoubleClick(object sender, EventArgs e)
        {
            txtUrunNo.Text = lvUrunler.SelectedItems[0].SubItems[0].Text;
            txtUrunKodu.Text = lvUrunler.SelectedItems[0].SubItems[1].Text;
            txtUrunAdi.Text = lvUrunler.SelectedItems[0].SubItems[2].Text;
            txtMiktar.Text = lvUrunler.SelectedItems[0].SubItems[3].Text;
            txtBirimFiyat.Text = lvUrunler.SelectedItems[0].SubItems[5].Text;
            txtKritikSeviye.Text = lvUrunler.SelectedItems[0].SubItems[4].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();
            if (u.UrunSil(Convert.ToInt32(txtUrunNo.Text)))
            {
                MessageBox.Show("Ürün Silindi");
                u.UrunleriGetir(lvUrunler);
                btnSil.Enabled = false;
                btnKaydet.Enabled = false;
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();
            u.UrunKodu = txtUrunKodu.Text;
            u.UrunAd = txtUrunAdi.Text;
            u.Miktar = Convert.ToInt32(txtMiktar.Text);
            if (txtKritikSeviye.Text.Trim() == "")
            {
                u.KritikSeviye = 5;
            }
            else
                u.KritikSeviye = Convert.ToInt32(txtKritikSeviye.Text);
            u.BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text);

            if (u.UrunDegistir(u))
            {
                MessageBox.Show("Ürün Güncellendi");
                u.UrunleriGetir(lvUrunler);
                Temizle();
                txtUrunKodu.Focus();
                btnDegistir.Enabled = false;
                btnSil.Enabled = false;

            }
        }

        private void txtKodaGoreArama_TextChanged(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();
            u.UrunAramaByUrunKodaGore(txtKodaGoreArama.Text, lvUrunler); 
        }

        private void txtAdaGoreArama_TextChanged(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();
            u.UrunAramaByUrunAdaGore(txtAdaGoreArama.Text, lvUrunler);
        }

        private void txtUrunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKritikSeviye_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdaGoreArama_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

    }
}
