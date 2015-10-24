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
    public partial class frmCariler : Form
    {
        public frmCariler()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            txtAdi.Clear();
            txtAdres.Clear();
            txtCariNo.Clear();
            txtPlaka.Clear();
            txtSoyadi.Clear();
            txtTCNo.Clear();
            txtTelefon.Clear();
            txtPlakayaGore.Clear();
            txtAdaGore.Clear();
            txtAdi.Focus();
        }

        private void frmCariler_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cCari c = new cCari();
            c.CarileriGetir(lvCariler);

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cCari c = new cCari();
            
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtPlaka.Text.Trim() != "" && txtTCNo.Text.Trim() != "" && txtTelefon.Text.Trim() != "")
            {
                if (c.CariKontrol(txtPlaka.Text))
                {
                    MessageBox.Show("Cari Kaydı Bulunmaktadır.","***UYARI***");
                    txtAdi.Focus();
                }
                else
                {
                    c.CariAd = txtAdi.Text;
                    c.CariSoyad = txtSoyadi.Text;
                    c.Plaka = txtPlaka.Text;
                    c.TCNo = txtTCNo.Text;
                    c.Telefon = txtTelefon.Text;
                    c.Adres = txtAdres.Text;
                    if (c.CariEkle(c))
                    {
                        MessageBox.Show("Cari Başarıyla Eklendi.");
                        btnKaydet.Enabled = false;
                        c.CarileriGetir(lvCariler);
                        Temizle();
                    }
                    else MessageBox.Show("Cari Kaydı EKLENEMEDİ !!", "***DİKKAT***");
                }
            }
            else MessageBox.Show("Adres haricindeki alanlar boş geçilemez.", "***UYARI***");

        }

        private void lvCariler_DoubleClick(object sender, EventArgs e)
        {
            btnKaydet.Enabled = false;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;

            txtCariNo.Text = lvCariler.SelectedItems[0].Text;
            txtAdi.Text = lvCariler.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = lvCariler.SelectedItems[0].SubItems[2].Text;
            txtPlaka.Text = lvCariler.SelectedItems[0].SubItems[3].Text;
            txtTCNo.Text = lvCariler.SelectedItems[0].SubItems[4].Text;
            txtTelefon.Text = lvCariler.SelectedItems[0].SubItems[5].Text;
            txtAdres.Text = lvCariler.SelectedItems[0].SubItems[6].Text;


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cCari c = new cCari();
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (c.CariSil(Convert.ToInt32(txtCariNo.Text)))
                {
                    MessageBox.Show("Cari silinmiştir.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    c.CarileriGetir(lvCariler);
                }
                else MessageBox.Show("Cari silmede HATA !", "*** DİKKAT ***");
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Değiştirmeyi İstiyor musunuz?", "DEĞİŞTİRİLSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                cCari c = new cCari();
                c.CariNo = Convert.ToInt32(txtCariNo.Text);
                c.CariAd = txtAdi.Text;
                c.CariSoyad = txtSoyadi.Text;
                c.Plaka = txtPlaka.Text;
                c.TCNo = txtTCNo.Text;
                c.Telefon = txtTelefon.Text;
                c.Adres = txtAdres.Text;
                if (c.FilmGuncelle(c))
                {
                    MessageBox.Show("Film Güncellenmiştir.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    c.CarileriGetir(lvCariler);
                }
                else { MessageBox.Show("Güncelleme yapılamadı!"); }

            }
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            txtAdi.Text = txtAdi.Text.ToUpper();
            txtAdi.Select(20, 20);
        }

        private void txtPlakayaGore_TextChanged(object sender, EventArgs e)
        {
            cCari c = new cCari();
            c.CarileriGetirByPlakayaGore(txtPlakayaGore.Text, lvCariler);
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cCari c = new cCari();
            c.CarileriGetirByAdaGore(txtAdaGore.Text, lvCariler);
        }

        private void txtSoyadi_TextChanged(object sender, EventArgs e)
        {
            txtSoyadi.Text = txtSoyadi.Text.ToUpper();
            txtSoyadi.Select(20, 20);
        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            txtPlaka.Text = txtPlaka.Text.ToUpper();
            txtPlaka.Select(20, 20);
        }

        private void txtTCNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            txtAdres.Text = txtAdres.Text.ToUpper();
            txtAdres.Select(150, 150);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
                e.Handled = false;//eğer 47 -58 arasındaysa tuşu yazdır.
            else if ((int)e.KeyChar == 8)
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            else
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
        }

        private void txtTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
                e.Handled = false;//eğer 47 -58 arasındaysa tuşu yazdır.
            else if ((int)e.KeyChar == 8)
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            else
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
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

        private void txtAdaGore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }


    }
}
