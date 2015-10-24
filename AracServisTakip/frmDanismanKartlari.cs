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
    public partial class frmDanismanKartlari : Form
    {
        public frmDanismanKartlari()
        {
            InitializeComponent();
        }

        public void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTCNO.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }

        private void frmDanismanKartlari_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cDanisman d = new cDanisman();
            d.DanismanlariGetir(lvDanismanlar);

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            txtKullaniciAdi.Enabled = true;
            txtSifre.Enabled = true;
            Temizle();
            txtAdi.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cDanisman d = new cDanisman();

            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTCNO.Text.Trim() != "" && txtKullaniciAdi.Text.Trim() != "" && txtSifre.Text.Trim() != "")
            {
                if (d.DanismanKontrol(txtTCNO.Text))
                {
                    MessageBox.Show("Danisman Kaydı Bulunmaktadır.", "***UYARI***");
                    txtAdi.Focus();
                }
                else
                {
                    d.DanismanAd = txtAdi.Text;
                    d.DanismanSoyad = txtSoyadi.Text;
                    d.TCNo = txtTCNO.Text;
                    d.Telefon = txtTelefon.Text;
                    d.Adres = txtAdres.Text;
                    d.KullaniciAdi = txtKullaniciAdi.Text;
                    d.Sifre = txtSifre.Text;
                    if (d.DanismanEkle(d))
                    {
                        MessageBox.Show("Danisman Başarıyla Eklendi.");
                        btnKaydet.Enabled = false;
                        d.DanismanlariGetir(lvDanismanlar);
                        txtKullaniciAdi.Enabled = false;
                        txtSifre.Enabled = false;
                        Temizle();
                    }
                    else MessageBox.Show("Danisman Kaydı EKLENEMEDİ !!", "***DİKKAT***");
                }
            }
            else MessageBox.Show("Adres ve telefon haricindeki alanlar boş geçilemez.", "***UYARI***");
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Değiştirmeyi İstiyor musunuz?", "DEĞİŞTİRİLSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                cDanisman d = new cDanisman();
                d.DanismanNo = Convert.ToInt32(txtDanismanNo.Text);
                d.DanismanAd = txtAdi.Text;
                d.DanismanSoyad = txtSoyadi.Text;
                d.TCNo = txtTCNO.Text;
                d.Telefon = txtTelefon.Text;
                d.Adres = txtAdres.Text;
                if (d.DanismanGuncelle(d))
                {
                    MessageBox.Show("Danisman Güncellenmiştir.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    d.DanismanlariGetir(lvDanismanlar);
                }
                else
                {
                    MessageBox.Show("Güncelleme yapılamadı!");
                }
            }
        }

        private void lvDanismanlar_DoubleClick(object sender, EventArgs e)
        {
            btnKaydet.Enabled = false;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;

            txtDanismanNo.Text = lvDanismanlar.SelectedItems[0].Text;
            txtAdi.Text = lvDanismanlar.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = lvDanismanlar.SelectedItems[0].SubItems[2].Text;
            txtTCNO.Text = lvDanismanlar.SelectedItems[0].SubItems[3].Text;
            txtTelefon.Text = lvDanismanlar.SelectedItems[0].SubItems[4].Text;
            txtAdres.Text = lvDanismanlar.SelectedItems[0].SubItems[5].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cDanisman d = new cDanisman();

            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (d.DanismanSil(Convert.ToInt32(txtDanismanNo.Text)))
                {
                    MessageBox.Show("Danisman silinmiştir.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    d.DanismanlariGetir(lvDanismanlar);
                }
                else MessageBox.Show("Danisman silmede HATA !", "*** DİKKAT ***");
            }
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cDanisman d = new cDanisman();
            d.DanismanlariGetirByAdaGore(txtAdaGore.Text, lvDanismanlar);
        }

        private void txtAdaGore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void txtTCNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       
    }
}
