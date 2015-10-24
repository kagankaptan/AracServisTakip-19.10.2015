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
    public partial class frmServisIslemiIptal : Form
    {
        public frmServisIslemiIptal()
        {
            InitializeComponent();
        }

        private void frmServisIslemiIptal_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cCariHareket ch = new cCariHareket();
            ch.CariHareketGetirByHareketSilmeyeGore(lvHareketler);
            btnSil.Enabled = false;
            txtTarih1.Text = DateTime.Now.ToShortDateString();

        }

        private void lvHareketler_DoubleClick(object sender, EventArgs e)
        {
            txtCariHareketNo.Text = lvHareketler.SelectedItems[0].SubItems[0].Text;
            txtMusteri.Text = lvHareketler.SelectedItems[0].SubItems[2].Text;
            txtPlaka.Text = lvHareketler.SelectedItems[0].SubItems[3].Text;
            txtBorc.Text = lvHareketler.SelectedItems[0].SubItems[4].Text;
            txtAlacak.Text = lvHareketler.SelectedItems[0].SubItems[5].Text;
            txtUrunHareketNo.Text = lvHareketler.SelectedItems[0].SubItems[6].Text;
            txtServisHareketNo.Text = lvHareketler.SelectedItems[0].SubItems[7].Text;
            txtCariNo.Text = lvHareketler.SelectedItems[0].SubItems[8].Text;
            btnSil.Enabled = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinizden Emin misiniz ?", "UYARI !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cUrunHareket uh = new cUrunHareket();
                cServisHareket sh = new cServisHareket();

                if (sh.ServisHareketSil(Convert.ToInt32(txtServisHareketNo.Text)))
                {
                    MessageBox.Show("Servis Hareketi Silindi.");
                    int i = uh.UrunHareketSil(Convert.ToInt32(txtUrunHareketNo.Text));
                    if (i > 0)
                    {
                        MessageBox.Show("Ürün Hareket silindi.");
                        cUrunler u = new cUrunler();
                        if (u.StokGuncelleFromUrunHareketSil(i))
                        {
                            MessageBox.Show("Stok bilgileri silme işlemine göre güncellendi.");
                            cCariHareket ch = new cCariHareket();
                            if (ch.CariHareketSilByCariHareketNoGore(Convert.ToInt32(txtCariHareketNo.Text)))
                            {
                                MessageBox.Show("Cari Hareketi silindi.");
                                cCari c = new cCari();
                                c.CariToplamlariGuncelleFromCariHareketSilme(Convert.ToInt32(txtCariNo.Text), Convert.ToDecimal(txtBorc.Text), 0);
                                MessageBox.Show("Cari Toplamlar Güncellendi.");
                                ch.CariHareketGetirByHareketSilmeyeGore(lvHareketler);
                                btnSil.Enabled = false;
                            }
                            else MessageBox.Show("Cari Hareket Silme BAŞARISIZ.");
                        }
                        else MessageBox.Show("Stok Güncelleme BAŞARISIZ.");
                    }
                    else MessageBox.Show(" Ürün Hareket silme BAŞARISIZ.");
                }
                else MessageBox.Show("Servis Hareket Silme İşlemi BAŞARISIZ.");
            }
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih1.Text = dtpTarih.Value.ToShortDateString();
            cCariHareket ch = new cCariHareket();
            ch.ServisIslemiIptalByBaslangicTariheGore(Convert.ToDateTime(txtTarih1.Text), lvHareketler);
        }

        private void txtPlakayaGore_TextChanged(object sender, EventArgs e)
        {
            cCariHareket ch = new cCariHareket();
            ch.ServisIslemiIptalByPlakayaGore(txtPlakayaGore.Text, lvHareketler);
        }

    }
}
