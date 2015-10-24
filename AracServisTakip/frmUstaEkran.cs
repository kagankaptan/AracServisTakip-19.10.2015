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
    public partial class frmUstaEkran : Form
    {
        cClient client;
        public frmUstaEkran()
        {
            InitializeComponent();
        }

        private void frmUstaEkran_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmUstaEkran_Load(object sender, EventArgs e)
        {
            client = new cClient();

            

            cServisIslemleri si = new cServisIslemleri();
            si.ServisleriGetirForServisIslemleri(cbServisIslemleri);
            cUrunler u = new cUrunler();
            u.UrunleriGetirForServisIslemleri(cbUrunler);

            cServisHareket sh = new cServisHareket();
            dgvUstaIslemleri.DataSource = sh.ServisHareketGetirByUstayaGore();

            cUrunHareket uh = new cUrunHareket();
            dgvUrunHareket.DataSource = uh.UrunleriGetirByUstayaGore();

        }

        private void btnIslemUzadi_Click(object sender, EventArgs e)
        {
            btnGonder.Enabled = true;
            btnCariBul.Enabled = true;
            cbServisIslemleri.Enabled = true;
            cbUrunler.Enabled = true;
        }

        private void cbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUrunler.Text = cbUrunler.SelectedItem.ToString();
        }

        private void cbServisIslemleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtServisIslemleri.Text = cbServisIslemleri.SelectedItem.ToString();
        }

        private void btnIslemBitti_Click(object sender, EventArgs e)
        {
            cUsta us = new cUsta();
            if (MessageBox.Show("İşlem bitirildi mi?", "UYARI?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                us.UstaGuncelleByMesgulKaldir(cGenel.UstaID);
                MessageBox.Show("Son İşlem bitmiştir.");
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            
            cbServisIslemleri.Enabled = false;
            cbUrunler.Enabled = false;
            cServisUzayan su = new cServisUzayan();
            su.CariAd = txtCari.Text;
            su.Plaka = txtPlaka.Text;
            su.ServisAd = txtServisIslemleri.Text;
            su.UrunAd = txtUrunler.Text;
            if (txtCari.Text.Trim() != "" && txtPlaka.Text.Trim() != "" && txtServisIslemleri.Text.Trim() != "" && txtUrunler.Text.Trim() != "")
            {
                if (MessageBox.Show("İşlem gönderilsin mi?", "UYARI?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    client.SendBildirim();

                    if (su.IslemUzayanEkle(su))
                    {
                        MessageBox.Show("Mesajınız Danışmana İletilmiştir");
                    }
                    else
                        MessageBox.Show("Mesajınız Danışmana İletilemedi !!!!");
                    btnCariBul.Enabled = false;
                    cbServisIslemleri.Enabled = false;
                    cbUrunler.Enabled = false;
                    btnGonder.Enabled = false;
                    cUsta us = new cUsta();
                    us.UstaGuncelleByMesgulKaldir(cGenel.UstaID);
                    MessageBox.Show("Son İşlem bitmiştir.");
                }
            }
            else
                MessageBox.Show("Lütfen Boş Alanların Doluluğunu Kontrol Ediniz");

            txtServisIslemleri.Clear();
            txtUrunler.Clear();

        }

        private void btnCariBul_Click(object sender, EventArgs e)
        {
            frmCariSorgulama frm = new frmCariSorgulama();
            frm.ShowDialog();
            txtCari.Text = cGenel.CariAdi;
            txtPlaka.Text = cGenel.Plaka;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            cServisHareket sh = new cServisHareket();
            dgvUstaIslemleri.DataSource = sh.ServisHareketGetirByUstayaGore();

            cUrunHareket uh = new cUrunHareket();
            dgvUrunHareket.DataSource = uh.UrunleriGetirByUstayaGore();
        }
    }
}
