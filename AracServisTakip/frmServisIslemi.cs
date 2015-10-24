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
    public partial class frmServisIslemi : Form
    {
        public frmServisIslemi()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            txtCari.Clear();
            txtCariNo.Clear();
            txtServisTuru.Clear();
            txtUrunler.Clear();
            txtServisBedeli.Clear();
            txtUrunBedeli.Clear();
            txtToplam.Clear();
            txtServisNo.Clear();
            txtUrunNo.Clear();
            txtUsta.Clear();
            txtUstaNo.Clear();
        }

        private void frmServisIslemi_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtIslemTarihi.Text = DateTime.Now.ToShortDateString();
            txtUrunBedeli.Text = "0";
            txtServisBedeli.Text = "0";
            cServisIslemleri si = new cServisIslemleri();
            si.ServisleriGetirForServisIslemleri(cbServisTurleri);
            cUrunler u = new cUrunler();
            u.UrunleriGetirForServisIslemleri(cbUrunler);

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            cServisUzayan su = new cServisUzayan();
            DataTable dt = new DataTable();
            dt = su.IslemUzayanDanismanGoster();
            dgvIslemUzayan.DataSource = dt;
        }

        private void txtUrunBedeli_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplam.Text = (Convert.ToDecimal(txtServisBedeli.Text) + Convert.ToDecimal(txtUrunBedeli.Text)).ToString();
            }
            catch (Exception)
            {
                txtToplam.Text = "0";
            }
        }

        private void txtServisBedeli_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplam.Text = (Convert.ToDecimal(txtServisBedeli.Text) + Convert.ToDecimal(txtUrunBedeli.Text)).ToString();
            }
            catch (Exception)
            {
                txtToplam.Text = "0";
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtIslemTarihi.Text = DateTime.Now.ToShortDateString();
            Temizle();
            btnKaydet.Enabled = true;
            txtUrunBedeli.Text = "0";
            txtServisBedeli.Text = "0";
        }

        private void btnCariBul_Click(object sender, EventArgs e)
        {
            frmCariSorgulama frm = new frmCariSorgulama();
            frm.ShowDialog();
            txtCari.Text = cGenel.CariAdi;
            txtCariNo.Text= (cGenel.CariNo).ToString();

        }

        private void cbServisTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            cServisIslemleri si = new cServisIslemleri();
            si.ServisNoVeServisBedeliniGetir(cbServisTurleri.SelectedItem.ToString(), txtServisNo, txtServisBedeli);
            //txtServisNo.Text = Convert.ToString(si.ServisNoGetirByServisIslemineGore(cbServisTurleri.SelectedItem.ToString()));
            txtServisTuru.Text = cbServisTurleri.SelectedItem.ToString();
        }

        private void cbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();
            u.UrunNoGetirByUrunSecimineGore(cbUrunler.SelectedItem.ToString(), txtUrunNo, txtUrunBedeli);
            //txtUrunNo.Text = Convert.ToString(u.UrunNoGetirByUrunSecimineGore(cbUrunler.SelectedItem.ToString()));
            txtUrunler.Text = cbUrunler.SelectedItem.ToString();
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtIslemTarihi.Text = dtpTarih.Value.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUstaSorgulamaByMesgulDurumuna frm = new frmUstaSorgulamaByMesgulDurumuna();
            frm.ShowDialog();
            txtUsta.Text = cGenel.UstaAdi;
            txtUstaNo.Text = cGenel.UstaNo.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cUrunHareket uh = new cUrunHareket();
            uh.Adet = 1;
            uh.Belge = "";
            uh.BirimFiyat = Convert.ToDecimal(txtUrunBedeli.Text);
            uh.CariNo = Convert.ToInt32(txtCariNo.Text);
            uh.IslemTuru = "Stok Çıkış";
            uh.Tarih = Convert.ToDateTime(txtIslemTarihi.Text);
            uh.Tutar = Convert.ToDecimal(txtUrunBedeli.Text);
            uh.UrunNo = Convert.ToInt32(txtUrunNo.Text);
            uh.UstaNo = Convert.ToInt32(txtUstaNo.Text);

            cServisHareket sh = new cServisHareket();
            sh.CariNo = Convert.ToInt32(txtCariNo.Text);
            sh.Fiyat = Convert.ToDecimal(txtServisBedeli.Text);
            sh.ServisNo = Convert.ToInt32(txtServisNo.Text);
            sh.Tarih = Convert.ToDateTime(txtIslemTarihi.Text);
            sh.Tutar = Convert.ToDecimal(txtServisBedeli.Text);
            sh.UstaNo = Convert.ToInt32(txtUstaNo.Text);

            int urunhareketid = uh.UrunHareketEkle(uh);
            int servishareketid = sh.ServisHareketEkle(sh);

            if (urunhareketid > 0 && servishareketid > 0)
            {
                MessageBox.Show("Ürün Hareketleri ve Servis Hareketleri kayıtları edildi.");
                cUrunler u = new cUrunler();
                if (u.StokGuncelleFromUrunHareketEkle(uh.UrunNo, uh.Adet, uh.IslemTuru))
                {
                    MessageBox.Show("Stok bilgileri güncellendi.");
                    cCariHareket ch = new cCariHareket();
                    ch.TarihGiris = Convert.ToDateTime(txtIslemTarihi.Text);
                    ch.IslemTuru = "Stok Çıkış";
                    ch.CariNo = Convert.ToInt32(txtCariNo.Text);
                    ch.Belge = "";
                    ch.Alacak = 0;
                    ch.Borc = Convert.ToDecimal(txtToplam.Text);
                    ch.KasaHareketNo = 0;
                    ch.ServisHareketNo = servishareketid;
                    ch.UrunHareketNo = urunhareketid;
                    if (ch.CariHareketEkle(ch))
                    {
                        MessageBox.Show("Cari Hareketleri eklendi.");
                        cCari c = new cCari();
                        c.CariToplamlariGuncelleFromCariHareketEkle(ch.CariNo, ch.Borc, ch.Alacak);
                        MessageBox.Show("Cari Toplamlar güncellendi.");
                        cUsta us = new cUsta();
                        us.UstaGuncelleByMesgulYap(Convert.ToInt32(txtUstaNo.Text));
                        btnKaydet.Enabled = false;
                    }

                }

            }
        }


    }
}
