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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtKullaniciAdi.Focus();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //frmDanisman frm = new frmDanisman();
            //frm.Show();
            //this.Hide();

            if (cbSecim.Text == "DANIŞMAN")
            {
                cDanisman d = new cDanisman();
                if (d.DanismanGirisi(txtKullaniciAdi.Text, txtSifre.Text))
                {
                    frmDanisman frm = new frmDanisman();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınızı veya şifrenizi kontrol ediniz.", "*** UYARI ***");
                    txtKullaniciAdi.Focus();
                }
            }
            else if (cbSecim.Text == "USTA")
            {
                cUsta u = new cUsta();
                if (u.UstaGirisi(txtKullaniciAdi.Text, txtSifre.Text))
                {
                    frmUstaEkran frm = new frmUstaEkran();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınızı veya şifrenizi kontrol ediniz.", "*** UYARI ***");
                    txtKullaniciAdi.Focus();
                }
            }
            else
                MessageBox.Show("Lütfen Seçim Yapınız.", "*** UYARI ***");
            
        }

        
    }
}
