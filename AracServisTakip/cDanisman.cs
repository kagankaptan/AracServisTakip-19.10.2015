using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracServisTakip
{
    class cDanisman
    {
        private int _danismanNo;
        private string _danismanAd;
        private string _danismanSoyad;
        private string _tCNo;
        private string _telefon;
        private string _adres;
        private string _kullaniciAdi;
        private string _sifre;

        #region Properties
        public int DanismanNo
        {
            get { return _danismanNo; }
            set { _danismanNo = value; }
        }

        public string DanismanAd
        {
            get { return _danismanAd; }
            set { _danismanAd = value; }
        }

        public string DanismanSoyad
        {
            get { return _danismanSoyad; }
            set { _danismanSoyad = value; }
        }

        public string TCNo
        {
            get { return _tCNo; }
            set { _tCNo = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public string KullaniciAdi
        {
            get { return _kullaniciAdi; }
            set { _kullaniciAdi = value; }
        }

        public string Sifre
        {
            get { return _sifre; }
            set { _sifre = value; }
        } 
        #endregion

        public bool DanismanGirisi(string kullaniciadi, string sifre)
        {
            bool sonuc=false;
            int i ;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Select DanismanNo from Danisman where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre and Silindi=0", conn);
            comm.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = kullaniciadi;
            comm.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = sifre;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                i = Convert.ToInt32(comm.ExecuteScalar());
                if (i > 0)
                {
                    cGenel.DanismanID = i;
                    sonuc = true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            return sonuc;
        }

        public void DanismanlariGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Select DanismanNo, DanismanAd, DanismanSoyad, TCNo, Telefon, Adres from Danisman where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                int i = 0;
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());
                    i++;

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        public void DanismanAdSoyadGetirByKullaniciGiriseGore(ToolStripStatusLabel danisman)
        {
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Select DanismanAd, DanismanSoyad from Danisman where DanismanNo=@DanismanNo", conn);
            comm.Parameters.Add("@DanismanNO", SqlDbType.Int).Value = cGenel.DanismanID;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    danisman.Text = dr["DanismanAd"].ToString() + " " + dr["DanismanSoyad"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        public bool DanismanKontrol(string TcNO)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select * from Danisman where TcNo = @TcNo", conn);
            comm.Parameters.Add("@TcNo", SqlDbType.VarChar).Value = TcNO;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    sonuc = true;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            return sonuc;
        }

        public bool DanismanEkle(cDanisman d)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("insert into Danisman(DanismanAd, DanismanSoyad,  TCNo, Adres, Telefon,  KullaniciAdi, Sifre) values (@DanismanAd, @DanismanSoyad, @TCNo, @Adres, @Telefon, @KullaniciAdi, @Sifre)", conn);
            comm.Parameters.Add("@DanismanAd", SqlDbType.VarChar).Value = d._danismanAd;
            comm.Parameters.Add("@DanismanSoyad", SqlDbType.VarChar).Value = d._danismanSoyad;
            comm.Parameters.Add("@TCNo", SqlDbType.VarChar).Value = d._tCNo;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = d._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = d._adres;
            comm.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = d._kullaniciAdi;
            comm.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = d._sifre;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                sonuc = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            return sonuc;
        }

        public bool DanismanSil(int DanismanNo)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update Danisman set Silindi = 1 where DanismanNo = @DanismanNo", conn);
            comm.Parameters.Add("@DanismanNo", SqlDbType.Int).Value = DanismanNo;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                comm.ExecuteNonQuery();
                sonuc = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            return sonuc;
        }

        public bool DanismanGuncelle(cDanisman d)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update Danisman set DanismanAd=@DanismanAd, DanismanSoyad=@DanismanSoyad, TCNo=@TCNo, Telefon=@Telefon, Adres=@Adres where DanismanNo=@DanismanNo", conn);
            comm.Parameters.Add("@DanismanAd", SqlDbType.VarChar).Value = d._danismanAd;
            comm.Parameters.Add("@DAnismanSoyad", SqlDbType.VarChar).Value = d._danismanSoyad;
            comm.Parameters.Add("@TCNo", SqlDbType.VarChar).Value = d._tCNo;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = d._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = d._adres;
            comm.Parameters.Add("@DanismanNo", SqlDbType.Int).Value = d._danismanNo;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            return sonuc;
        }

        public void DanismanlariGetirByAdaGore(string adi, ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select DanismanNo, DanismanAd, DanismanSoyad, TCNo, Telefon, Adres from Danisman where DanismanAd like @DanismanAd+'%' and Silindi=0", conn);
            comm.Parameters.Add("@DanismanAd", SqlDbType.VarChar).Value = adi;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                int i = 0;
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());
                    i++;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }


    }
}
