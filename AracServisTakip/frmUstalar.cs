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
    public partial class frmUstalar : Form
    {
        public frmUstalar()
        {
            InitializeComponent();
        }

        private void frmUstalar_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cUsta u = new cUsta();
            u.UstaGetir(lvUstalar);
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

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cUsta u = new cUsta();
            u.UstaGetirByAdaGore(lvUstalar, txtAdaGore.Text);
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
            cUsta u = new cUsta();
            //if(txtUstaNo.Text.Trim() != "")
            //u.UstaNo= Convert.ToInt32(txtUstaNo.Text);
            u.UstaAd = txtAdi.Text;
            u.UstaSoyad = txtSoyadi.Text;
            u.TCNo = txtTCNO.Text;
            u.Telefon = txtTelefon.Text;
            u.Adres = txtAdres.Text;
            u.KullaniciAdi = txtKullaniciAdi.Text;
            u.Sifre = txtSifre.Text;
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTCNO.Text.Trim() != "" && txtKullaniciAdi.Text.Trim() != "" && txtSifre.Text.Trim() != "")
            {
                if (u.UstaKontrol(u))
                {
                    MessageBox.Show("Usta zaten mevcut");
                }
                else
                {
                    bool Sonuc = u.UstaEkle(u);
                    if (Sonuc)
                    {
                        MessageBox.Show("Yeni Usta Kayıt edildi.");
                        Temizle();
                        btnKaydet.Enabled = false;
                        txtAdi.Focus();
                        u.UstaGetir(lvUstalar);
                        txtKullaniciAdi.Enabled = false;
                        txtSifre.Enabled = false;
                    }
                    else MessageBox.Show("Usta Kayıt EDİLEMEDİ !!!");
                }
            }
            else
            {
                MessageBox.Show("Zorunlu alanlar boş geçilemez!");
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            cUsta u = new cUsta();
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTCNO.Text.Trim() != "")
            {
                u.UstaNo = Convert.ToInt32(txtUstaNo.Text);
                u.UstaAd = txtAdi.Text;
                u.UstaSoyad = txtSoyadi.Text;
                u.TCNo = txtTCNO.Text;
                u.Adres = txtAdres.Text;
                u.Telefon = txtTelefon.Text;

                bool Sonuc = u.UstaGuncelle(u);
                if (Sonuc)
                {
                    MessageBox.Show("Usta Bilgileri Güncellendi.");
                    btnKaydet.Enabled = false;
                    btnDegistir.Enabled = true;
                    btnSil.Enabled = true;
                    u.UstaGetir(lvUstalar);
                    Temizle();
                    txtAdi.Focus();
                }
                else MessageBox.Show("Bilgiler Güncellenemedi !!!");
            }
            else
            {
                MessageBox.Show("Bilgiler Boş Geçilemez!!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                cUsta u = new cUsta();
                u.UstaNo = Convert.ToInt32(txtUstaNo.Text);
                bool Sonuc = u.UstaSil(u.UstaNo);
                if (Sonuc)
                {
                    Temizle();
                    btnKaydet.Enabled = false;
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    u.UstaGetir(lvUstalar);
                    MessageBox.Show("Usta Bilgileri Silindi");
                    txtAdi.Focus();
                }
                else MessageBox.Show("Usta bilgileri SİLİNEMEDİ !!", "UYARI");
            }
        }

        private void lvUstalar_DoubleClick(object sender, EventArgs e)
        {
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtUstaNo.Text = lvUstalar.SelectedItems[0].SubItems[0].Text;
            txtAdi.Text = lvUstalar.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = lvUstalar.SelectedItems[0].SubItems[2].Text;
            txtTCNO.Text = lvUstalar.SelectedItems[0].SubItems[3].Text;
            txtTelefon.Text = lvUstalar.SelectedItems[0].SubItems[4].Text;
            txtAdres.Text = lvUstalar.SelectedItems[0].SubItems[5].Text;
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

       

        private void txtTCNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
