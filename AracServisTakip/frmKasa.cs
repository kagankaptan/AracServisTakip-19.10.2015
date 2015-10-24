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
    public partial class frmKasa : Form
    {
        public frmKasa()
        {
            InitializeComponent();
        }

        private void frmKasa_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtGiren.Focus();
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }

        private void txtTarih_TextChanged(object sender, EventArgs e)
        {
            cKasaHareket kh = new cKasaHareket();
            kh.DevirlerGetirToTarih(txtTarih.Text, txtDevirGiren, txtDevirCikan, txtDevirBakiye);

            DataTable dt = new DataTable();
            dgvHareketler.DataSource = kh.KasaHaraketleriGetirByTarih(txtTarih.Text, txtGirenToplam, txtCikanToplam, txtBakiye);
            DgvDuzenle();
        }

        private void DgvDuzenle()
        {
            dgvHareketler.Columns[0].Visible = false;
            dgvHareketler.Columns[1].Width = 110;
            dgvHareketler.Columns[3].Visible = false;
            dgvHareketler.Columns[2].Width = 130;
            dgvHareketler.Columns[4].Width = 185;
            dgvHareketler.Columns[5].Width = 90;
            dgvHareketler.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHareketler.Columns[6].Width = 80;
            dgvHareketler.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvHareketler.Columns[7].Width = 37;
            dgvHareketler.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHareketler.Columns[7].HeaderText = "Para";
        }

        private void Temizle()
        {
            txtIslemTuru.Clear();
            txtCari.Clear();
            txtBelge.Clear();
            txtGiren.Text = "0";
            txtCikan.Text = "0";
            txtPara.Text = "TL";
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
            if (txtGiren.Text == "0" && txtCikan.Text == "0")
            {
                MessageBox.Show("İşlem Tutarını Girmelisiniz!", "Dikkat! Eksik Bilgi!");
                txtGiren.Focus();
            }
            else
            {
                cKasaHareket kh = new cKasaHareket();
                kh.Tarih = Convert.ToDateTime(txtTarih.Text);
                kh.IslemTuru = txtIslemTuru.Text;
                kh.CariNo = Convert.ToInt32(txtCariNo.Text);
                kh.Belge = txtBelge.Text;
                kh.Giren = Convert.ToDecimal(txtGiren.Text);
                kh.Cikan = Convert.ToDecimal(txtCikan.Text);
                int KayitNo = kh.KasaHareketEkle(kh);
                if (KayitNo > 0)
                {
                    MessageBox.Show("Kasa Hareketi İşlendi.");

                    DataTable dt = new DataTable();
                    dgvHareketler.DataSource = kh.KasaHaraketleriGetirByTarih(txtTarih.Text, txtGirenToplam, txtCikanToplam, txtBakiye);
                    DgvDuzenle();
                    btnKaydet.Enabled = false;
                    cCariHareket ch = new cCariHareket();
                    ch.TarihGiris = Convert.ToDateTime(txtTarih.Text);
                    ch.IslemTuru = txtIslemTuru.Text;
                    ch.CariNo = Convert.ToInt32(txtCariNo.Text);
                    ch.Belge = txtBelge.Text;
                    if (txtIslemTuru.Text == "Tahsilat")
                    {
                        ch.Alacak = Convert.ToDecimal(txtGiren.Text);
                        ch.Borc = 0;
                    }
                    else if (txtIslemTuru.Text == "Ödeme")
                    {
                        ch.Borc = Convert.ToDecimal(txtCikan.Text);
                        ch.Alacak = 0;
                    }
                    ch.UrunHareketNo = 0;
                    ch.KasaHareketNo = KayitNo;
                    ch.ServisHareketNo = 0;

                    if (ch.CariHareketEkle(ch))
                    {
                        MessageBox.Show("Cari Hareketleri Eklendi.");
                        cCari c = new cCari();
                        c.CariToplamlariGuncelleFromCariHareketEkle(ch.CariNo, ch.Borc, ch.Alacak);
                        MessageBox.Show("Cari Toplamlar Güncellendi.");
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cKasaHareket kh = new cKasaHareket();
            if (kh.KasaHareketSil(txtHareketNo.Text))
            {
                MessageBox.Show("Kasa Hareket Silindi.");
                cCariHareket ch = new cCariHareket();
                if (ch.CariHareketSilByKasaHareketNoGore(txtHareketNo.Text))
                {
                    MessageBox.Show("Cari Hareket Silindi.");
                    cCari c = new cCari();
                    c.CariToplamlariGuncelleFromCariHareketSilme(Convert.ToInt32(txtCariNo.Text), Convert.ToDecimal(txtCikan.Text), Convert.ToDecimal(txtGiren.Text));

                    btnSil.Enabled = false;
                    btnDegistir.Enabled = false;
                }
            }
            
        }

        private void cbIslemTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIslemTuru.Text = cbIslemTurleri.SelectedItem.ToString();
            if (txtIslemTuru.Text == "Tahsilat")
            {
                cGenel.CariTipi = "Alici";
                txtGiren.ReadOnly = false;
                txtCikan.ReadOnly = true;
            }
            else if (txtIslemTuru.Text == "Ödeme")
            {
                cGenel.CariTipi = "Satici";
                txtGiren.ReadOnly = true;
                txtCikan.ReadOnly = false;
            }

            frmCariSorgulama frm = new frmCariSorgulama();
            frm.ShowDialog();
            txtCariNo.Text = cGenel.CariNo.ToString();
            txtCari.Text = cGenel.CariAdi;
            txtBelge.Focus();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            cKasaHareket kh = new cKasaHareket();
            kh.HareketNo = Convert.ToInt32(txtHareketNo.Text);
            kh.Tarih = Convert.ToDateTime(txtTarih.Text);
            kh.Belge = txtBelge.Text;
            kh.Giren = Convert.ToDecimal(txtGiren.Text);
            kh.Cikan = Convert.ToDecimal(txtCikan.Text);

            bool Sonuc = kh.KasaHareketGuncelle(kh);
            if (Sonuc)
            {
                Temizle();
                btnKaydet.Enabled = false;
                btnDegistir.Enabled = false;
                btnSil.Enabled = false;
                kh.KasaHaraketleriGetir();
                MessageBox.Show("Kasa Hareket Bilgileri Güncellendi");
                dgvHareketler.DataSource = kh.KasaHaraketleriGetirByTarih(txtTarih.Text, txtGirenToplam, txtCikanToplam, txtBakiye);
                txtKasaTuru.Focus();
            }
        }

        private void dgvHareketler_DoubleClick(object sender, EventArgs e)
        {
            if (dgvHareketler.SelectedRows.Count > 0)
            {
                txtHareketNo.Text = (Convert.ToInt32(dgvHareketler.SelectedRows[0].Cells["HareketNo"].Value)).ToString();
                txtIslemTuru.Text = dgvHareketler.SelectedRows[0].Cells[1].Value.ToString();
                txtCari.Text = dgvHareketler.SelectedRows[0].Cells[2].Value.ToString();
                txtCariNo.Text = dgvHareketler.SelectedRows[0].Cells[3].Value.ToString();
                txtBelge.Text = dgvHareketler.SelectedRows[0].Cells[4].Value.ToString();
                txtGiren.Text = dgvHareketler.SelectedRows[0].Cells[5].Value.ToString();
                txtCikan.Text = dgvHareketler.SelectedRows[0].Cells[6].Value.ToString();
                txtParaBirimi.Text = dgvHareketler.SelectedRows[0].Cells[7].Value.ToString();
            }
            //HareketNo, IslemTuru, CariAd + ' ' + CariSoyad as AdıSoyadı, kh.CariNo, Belge, Giren, Cikan, ParaBirimi

            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
        }

        


    }
}
