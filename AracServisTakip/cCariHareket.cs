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
    class cCariHareket
    {
        private int _hareketNo;
        private string _islemTuru;
        private DateTime _tarihGiris;
        private DateTime _tarihCikis;
        private int _cariNo;
        private decimal _borc;
        private decimal _alacak;
        private string _belge;
        private int _kasaHareketNo;
        private int _urunHareketNo;
        private int _servisHareketNo;

        #region Properties
        public int HareketNo
        {
            get { return _hareketNo; }
            set { _hareketNo = value; }
        }

        public string IslemTuru
        {
            get { return _islemTuru; }
            set { _islemTuru = value; }
        }

        public DateTime TarihGiris
        {
            get { return _tarihGiris; }
            set { _tarihGiris = value; }
        }

        public DateTime TarihCikis
        {
            get { return _tarihCikis; }
            set { _tarihCikis = value; }
        }

        public int CariNo
        {
            get { return _cariNo; }
            set { _cariNo = value; }
        }

        public string Belge
        {
            get { return _belge; }
            set { _belge = value; }
        }

        public decimal Borc
        {
            get { return _borc; }
            set { _borc = value; }
        }

        public decimal Alacak
        {
            get { return _alacak; }
            set { _alacak = value; }
        }

        public int KasaHareketNo
        {
            get { return _kasaHareketNo; }
            set { _kasaHareketNo = value; }
        }

        public int UrunHareketNo
        {
            get { return _urunHareketNo; }
            set { _urunHareketNo = value; }
        }

        public int ServisHareketNo
        {
            get { return _servisHareketNo; }
            set { _servisHareketNo = value; }
        }
        #endregion


        public bool CariHareketEkle(cCariHareket ch)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("insert into CariHareket(TarihGiris, IslemTuru, CariNo, Borc, Alacak, KasaHareketNo, UrunHareketNo, ServisHareketNo) values (@TarihGiris, @IslemTuru, @CariNo, @Borc, @Alacak, @KasaHareketNo, @UrunHareketNo, @ServisHareketNo) ", conn);
            comm.Parameters.Add("@TarihGiris", SqlDbType.DateTime).Value = ch._tarihGiris;
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = ch._islemTuru;
            comm.Parameters.Add("@CariNo", SqlDbType.Int).Value = ch._cariNo;
            //comm.Parameters.Add("@Belge", SqlDbType.VarChar).Value = ch._belge;
            comm.Parameters.Add("@Borc", SqlDbType.Money).Value = ch._borc;
            comm.Parameters.Add("@Alacak", SqlDbType.Money).Value = ch._alacak;
            comm.Parameters.Add("@KasaHareketNo", SqlDbType.Int).Value = ch._kasaHareketNo;
            comm.Parameters.Add("@UrunHareketNo", SqlDbType.Int).Value = ch._urunHareketNo;
            comm.Parameters.Add("@ServisHareketNo", SqlDbType.Int).Value = ch._servisHareketNo;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string Hata = ex.Message;
                MessageBox.Show(Hata + " Cari Hareket");
            }
            finally
            {
                conn.Close();
            }
            return Sonuc;
        }

        public DataTable CariEkstre(int CariNo, DateTime tarih1, DateTime tarih2)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select TarihGiris,IslemTuru,Borc,Alacak from CariHareket where Silindi=0 and CariNo=@CariNo and TarihGiris between @Tarih1 and @Tarih2", conn);
            da.SelectCommand.Parameters.Add("@CariNo", SqlDbType.Int).Value = CariNo;
            da.SelectCommand.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = tarih1;
            da.SelectCommand.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = tarih2;
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

        public void CariHareketGetirByHareketSilmeyeGore(ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select HareketNo, TarihGiris, CariAd+' '+CariSoyad as Cari, Plaka, Borc, Alacak, UrunHareketNo,ServisHareketNo, Cari.CariNo  from CariHareket inner join Cari on Cari.CariNo = CariHareket.CariNo where CariHareket.Silindi = 0 and KasaHareketNo = 0", conn);
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
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    liste.Items[i].SubItems.Add(dr[8].ToString());
                    i++;

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + " CariHareketGetirByHareketSilmeyeGore  ");
            }
            finally { conn.Close(); }
        }

        public bool CariHareketSilByCariHareketNoGore(int hareketNo)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update CariHareket set Silindi=1 where HareketNo = @HareketNo ", conn);
            comm.Parameters.Add("@HareketNo", SqlDbType.Int).Value = hareketNo;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string Hata = ex.Message;
                MessageBox.Show("Cari hareket silde Veri Tabanı Hatası");
            }
            finally
            {
                conn.Close();
            }
            return Sonuc;
        }

        public void ServisIslemiIptalByPlakayaGore(string plaka, ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select HareketNo, TarihGiris, CariAd+' '+CariSoyad as Cari, Plaka, Borc, Alacak, UrunHareketNo,ServisHareketNo, Cari.CariNo  from CariHareket inner join Cari on Cari.CariNo = CariHareket.CariNo where Plaka like @Plaka+'%' and CariHareket.Silindi = 0", conn);
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
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    liste.Items[i].SubItems.Add(dr[8].ToString());
                    i++;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }


        public void ServisIslemiIptalByBaslangicTariheGore(DateTime Tarih, ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select HareketNo, TarihGiris, CariAd+' '+CariSoyad as Cari, Plaka, Borc, Alacak, UrunHareketNo,ServisHareketNo, Cari.CariNo  from CariHareket inner join Cari on Cari.CariNo = CariHareket.CariNo where TarihGiris> @Tarih and CariHareket.Silindi = 0", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Tarih;
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
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    liste.Items[i].SubItems.Add(dr[8].ToString());
                    i++;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        
        }

        public bool CariHareketSilByKasaHareketNoGore(string kasaHareketNo)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update CariHareket set Silindi=1 where KasaHareketNo = @KasaHareketNo ", conn);
            comm.Parameters.Add("@KasaHareketNo", SqlDbType.Int).Value = kasaHareketNo;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string Hata = ex.Message;
                MessageBox.Show("CariHareketSilByKasaHareketNoGore Silmede Veri Tabanı Hatası");
            }
            finally
            {
                conn.Close();
            }
            return Sonuc;
        }
    }
}
