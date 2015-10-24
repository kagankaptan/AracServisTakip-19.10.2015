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
    public partial class frmKasaSorgulama : Form
    {
        public frmKasaSorgulama()
        {
            InitializeComponent();
        }

        private void frmKasaSorgulama_Load(object sender, EventArgs e)
        {
            cKasaHareket kh = new cKasaHareket();
            dgvHareketler.DataSource = kh.KasaHaraketleriGetir();
            DgvDuzenle();
        }

        public void DgvDuzenle()
        {
            dgvHareketler.Columns[0].Visible = false;
            dgvHareketler.Columns[1].Width = 70;
            dgvHareketler.Columns[2].Width = 100;
            dgvHareketler.Columns[3].Width = 70;
            dgvHareketler.Columns[4].Width = 50;
            dgvHareketler.Columns[5].Width = 100;
            dgvHareketler.Columns[6].Width = 100;
            dgvHareketler.Columns[7].Width = 60;
            dgvHareketler.Columns[8].Width = 60;
            dgvHareketler.Columns[9].Width = 30;
        }

        private void txtIslemTuruneGore_TextChanged(object sender, EventArgs e)
        {
            cKasaHareket kh = new cKasaHareket();
            dgvHareketler.DataSource = kh.KasaHaraketleriGetirByIslemTuru(txtIslemTuruneGore.Text);
        }

        private void txtBelgeyeGore_TextChanged(object sender, EventArgs e)
        {
            cKasaHareket kh = new cKasaHareket();
            dgvHareketler.DataSource = kh.KasaHaraketleriGetirByBelge(txtBelgeyeGore.Text);
        }

        private void txtMusteriAdinaGore_TextChanged(object sender, EventArgs e)
        {
            cKasaHareket kh = new cKasaHareket();
            dgvHareketler.DataSource = kh.KasaHaraketleriGetirByMusteriAd(txtMusteriAdinaGore.Text);
        }

        private void txtTarih1_TextChanged(object sender, EventArgs e)
        {
            cKasaHareket kh = new cKasaHareket();
            if (txtTarih2.Text.Trim() != "")
                dgvHareketler.DataSource = kh.KasaHaraketleriGetirByTarihlerArasi(txtTarih1.Text, txtTarih2.Text);
        }

        private void txtTarih2_TextChanged(object sender, EventArgs e)
        {
            cKasaHareket kh = new cKasaHareket();
            if (txtTarih1.Text.Trim() != "")
                dgvHareketler.DataSource = kh.KasaHaraketleriGetirByTarihlerArasi(txtTarih1.Text, txtTarih2.Text);
        }

        private void dtpTarih1_ValueChanged(object sender, EventArgs e)
        {
            txtTarih1.Text = dtpTarih1.Value.ToString();
        }

        private void dtpTarih2_ValueChanged(object sender, EventArgs e)
        {
            txtTarih2.Text = dtpTarih2.Value.ToString();
        }

        private void txtMusteriAdinaGore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

    }
}
