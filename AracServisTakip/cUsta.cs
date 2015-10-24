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
    class cUsta
    {

        private int _ustaNo;
        private string _ustaAd;
        private string _ustaSoyad;
        private string _tCNo;
        private string _telefon;
        private string _adres;
        private bool _mesgul;
        private string _kullaniciAdi;
        private string _sifre;

       
        #region Properties
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

        public int UstaNo
        {
            get { return _ustaNo; }
            set { _ustaNo = value; }
        }

        public string UstaAd
        {
            get { return _ustaAd; }
            set { _ustaAd = value; }
        }

        public string UstaSoyad
        {
            get { return _ustaSoyad; }
            set { _ustaSoyad = value; }
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

        public bool Mesgul
        {
            get { return _mesgul; }
            set { _mesgul = value; }
        }
        #endregion


        public bool UstaGirisi(string kullaniciadi, string sifre)
        {
            bool sonuc = false;
            int i;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Select UstaNo from Usta where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre and Silindi=0", conn);
            comm.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = kullaniciadi;
            comm.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = sifre;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                i = Convert.ToInt32(comm.ExecuteScalar());
                if (i > 0)
                {
                    cGenel.UstaID = i;
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

        public DataTable UstalariGetir()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select * from Usta where Silindi=0", conn);

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

        public void UstaGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Select UstaNo, UstaAd, UstaSoyad, TCNo, Telefon, Adres, Mesgul from Usta where Silindi=0", conn);
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

        public bool UstaKontrol(cUsta u)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Select UstaAd, UstaSoyad from Usta where UstaAd = @UstaAd and UstaSoyad = @UstaSoyad", conn);
            comm.Parameters.Add("@UstaAd", SqlDbType.VarChar).Value = u._ustaAd;
            comm.Parameters.Add("@UstaSoyad", SqlDbType.VarChar).Value = u._ustaSoyad;
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

        public DataTable UstalariGetirByMesgulDurumunaGore()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select * from Usta where Mesgul=0 and Silindi=0", conn);

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

        public bool UstaEkle(cUsta u)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("insert into Usta(UstaAd, UstaSoyad, TCNo, Telefon, Adres, KullaniciAdi, Sifre) values (@UstaAd, @UstaSoyad, @TCNo, @Telefon, @Adres, @KullaniciAdi, @Sifre)", conn);
            comm.Parameters.Add("@UstaAd", SqlDbType.VarChar).Value = u._ustaAd;
            comm.Parameters.Add("@UstaSoyad", SqlDbType.VarChar).Value = u._ustaSoyad;
            comm.Parameters.Add("@TCNo", SqlDbType.VarChar).Value = u._tCNo;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = u._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = u._adres;
            comm.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = u._kullaniciAdi;
            comm.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = u._sifre;
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

        public bool UstaGuncelle(cUsta u)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Update Usta Set UstaAd=@UstaAd, UstaSoyad=@UstaSoyad, TCNo=@TCNo, Telefon=@Telefon, Adres=@Adres where UstaNo=@UstaNo", conn);
            comm.Parameters.Add("@UstaNo", SqlDbType.Int).Value = u._ustaNo;
            comm.Parameters.Add("@UstaAd", SqlDbType.VarChar).Value = u._ustaAd;
            comm.Parameters.Add("@UstaSoyad", SqlDbType.VarChar).Value = u._ustaSoyad;
            comm.Parameters.Add("@TCNo", SqlDbType.VarChar).Value = u._tCNo;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = u._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = u._adres;
            //comm.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = u._kullaniciAdi;
            //comm.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = u._sifre;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return Sonuc;
        }

        public bool UstaSil(int UstaNO)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Update Usta Set Silindi=1 where UstaNO = @UstaNO", conn);
            comm.Parameters.Add("@UstaNO", SqlDbType.Int).Value = UstaNO;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return Sonuc;
        }

        public void UstaGetirByAdaGore(ListView liste, string AdaGore)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Select UstaNO, UstaAd, UstaSoyad, TCNo, Telefon, Adres from Usta where Silindi=0 and UstaAd like @UstaAd + '%'", conn);
            comm.Parameters.Add("@UstaAd", SqlDbType.VarChar).Value = AdaGore;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            int i = 0;
            try
            {
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
                } dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        public void UstalarıGetirRaporlama(ComboBox liste)
        {
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select UstaAd + ' ' + UstaSoyad as AdıSoyadı from Usta where Silindi=0", conn);
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

        public void UstaGuncelleByMesgulYap(int ustano)
        {
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Update Usta Set Mesgul = 1 where UstaNo=@UstaNo", conn);
            comm.Parameters.Add("@UstaNo", SqlDbType.Int).Value = ustano;
            

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        public void UstaGuncelleByMesgulKaldir(int ustano)
        {
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Update Usta Set Mesgul = 0 where UstaNo=@UstaNo", conn);
            comm.Parameters.Add("@UstaNo", SqlDbType.Int).Value = ustano;


            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

    }
}
