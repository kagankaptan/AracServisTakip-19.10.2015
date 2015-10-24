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
    class cCari
    {
        private int _cariNo;
        private string _cariAd;
        private string _cariSoyad;
        private string _plaka;
        private string _tCNo;
        private string _telefon;
        private string _adres;
        private decimal _toplamBorc;
        private decimal _toplamAlacak;

        #region Properties
        public int CariNo
        {
            get { return _cariNo; }
            set { _cariNo = value; }
        }

        public string CariAd
        {
            get { return _cariAd; }
            set { _cariAd = value; }
        }

        public string CariSoyad
        {
            get { return _cariSoyad; }
            set { _cariSoyad = value; }
        }

        public string Plaka
        {
            get { return _plaka; }
            set { _plaka = value; }
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

        public decimal ToplamBorc
        {
            get { return _toplamBorc; }
            set { _toplamBorc = value; }
        }

        public decimal ToplamAlacak
        {
            get { return _toplamAlacak; }
            set { _toplamAlacak = value; }
        } 
        #endregion

        public DataTable CarileriGetir()
        { 
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select * from Cari where Silindi=0", conn);
            
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public void CarileriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select CariNo, CariAd, CariSoyad, Plaka, TCNo, Telefon, Adres from Cari where Silindi=0",conn);
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
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    i++;

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            
        }

        public bool CariKontrol(string Plaka)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select * from Cari where Plaka = @Plaka",conn);
            comm.Parameters.Add("@Plaka", SqlDbType.VarChar).Value = Plaka;
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

        public bool CariEkle(cCari c)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("insert into Cari(CariAd, CariSoyad, Plaka, TCNo, Telefon, Adres) values (@CariAd, @CariSoyad, @Plaka, @TCNo, @Telefon, @Adres)", conn);
            comm.Parameters.Add("@CariAd", SqlDbType.VarChar).Value = c._cariAd;
            comm.Parameters.Add("@CariSoyad", SqlDbType.VarChar).Value = c._cariSoyad;
            comm.Parameters.Add("@Plaka", SqlDbType.VarChar).Value = c._plaka;
            comm.Parameters.Add("@TCNo", SqlDbType.VarChar).Value = c._tCNo;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = c._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = c._adres;
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

        public bool CariSil(int CariID)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update Cari set Silindi = 1 where CariNo = @CariNo", conn);
            comm.Parameters.Add("@CariNo", SqlDbType.Int).Value = CariID;
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

        public bool FilmGuncelle(cCari c)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update Cari set CariAd=@CariAd, CariSoyad=@CariSoyad, Plaka=@Plaka, TCNo=@TCNo, Telefon=@Telefon, Adres=@Adres where CariNo=@CariNo", conn);
            comm.Parameters.Add("@CariAd", SqlDbType.VarChar).Value = c._cariAd;
            comm.Parameters.Add("@CariSoyad", SqlDbType.VarChar).Value = c._cariSoyad;
            comm.Parameters.Add("@Plaka", SqlDbType.VarChar).Value = c._plaka;
            comm.Parameters.Add("@TCNo", SqlDbType.VarChar).Value = c._tCNo;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = c._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = c._adres;
            comm.Parameters.Add("@CariNo", SqlDbType.Int).Value = c._cariNo;

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

        public void CarileriGetirByPlakayaGore(string plaka, ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select CariNo, CariAd, CariSoyad, Plaka, TCNo, Telefon, Adres from Cari where Plaka like @Plaka+'%' and Silindi=0", conn);
            comm.Parameters.Add("@Plaka", SqlDbType.VarChar).Value = plaka;
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
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    i++;

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        public void CarileriGetirByAdaGore(string adi, ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select CariNo, CariAd, CariSoyad, Plaka, TCNo, Telefon, Adres from Cari where CariAd like @CariAd+'%' and Silindi=0", conn);
            comm.Parameters.Add("@CariAd", SqlDbType.VarChar).Value = adi;
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
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    i++;

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        public void CariToplamlariGuncelleFromCariHareketEkle(int CariNo, decimal Borc, decimal Alacak)
        {
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update Cari set ToplamBorc = ToplamBorc + @Borc, ToplamAlacak = ToplamAlacak + @Alacak where CariNo = @CariNo", conn);
            comm.Parameters.Add("@CariNo", SqlDbType.Int).Value = CariNo;
            comm.Parameters.Add("@Borc", SqlDbType.Money).Value = Borc;
            comm.Parameters.Add("@Alacak", SqlDbType.Money).Value = Alacak;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string Hata = ex.Message;
                MessageBox.Show("Veri Tabanı Hatası");
            }
            finally
            {
                conn.Close();
            }
        }

        public void CarileriGetirRaporlama(ComboBox liste)
        {
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select CariAd + ' ' + CariSoyad as AdıSoyadı from Cari where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    liste.Items.Add(dr["AdıSoyadı"].ToString());
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void CariToplamlariGuncelleFromCariHareketSilme(int cariNo, decimal borc, decimal alacak)
        {
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update Cari set ToplamBorc = ToplamBorc - @Borc, ToplamAlacak = ToplamAlacak - @Alacak where CariNo = @CariNo", conn);
            comm.Parameters.Add("@CariNo", SqlDbType.Int).Value = cariNo;
            comm.Parameters.Add("@Borc", SqlDbType.Money).Value = borc;
            comm.Parameters.Add("@Alacak", SqlDbType.Money).Value = alacak;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string Hata = ex.Message;
                MessageBox.Show("Veri Tabanı Hatası");
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
