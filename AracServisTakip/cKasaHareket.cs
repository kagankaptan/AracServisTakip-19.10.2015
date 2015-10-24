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
    class cKasaHareket
    {
        private int _hareketNo;
        private string _kasaTuru;
        private DateTime _tarih;
        private string _islemTuru;
        private int _cariNo;
        private string _belge;
        private decimal _giren;
        private decimal _cikan;
        private string _paraBirimi;

        #region Properties
        public int HareketNo
        {
            get { return _hareketNo; }
            set { _hareketNo = value; }
        }

        public string KasaTuru
        {
            get { return _kasaTuru; }
            set { _kasaTuru = value; }
        }

        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }

        public string IslemTuru
        {
            get { return _islemTuru; }
            set { _islemTuru = value; }
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

        public decimal Giren
        {
            get { return _giren; }
            set { _giren = value; }
        }

        public decimal Cikan
        {
            get { return _cikan; }
            set { _cikan = value; }
        }

        public string ParaBirimi
        {
            get { return _paraBirimi; }
            set { _paraBirimi = value; }
        }
        #endregion

        cGenel gnl = new cGenel();

        public void DevirlerGetirToTarih(string Tarih, TextBox DevirGiren, TextBox DevirCikan, TextBox DevirBakiye)
        {
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Select sum(Giren) as DevirGiren, sum(Cikan) as DevirCikan, sum(Giren - Cikan) as DevirBakiye from KasaHareket where Tarih<@Tarih and Silindi=0", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Convert.ToDateTime(Tarih);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    DevirGiren.Text = dr[0].ToString();
                    DevirCikan.Text = dr[1].ToString();
                    DevirBakiye.Text = dr[2].ToString();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public DataTable KasaHaraketleriGetirByTarih(string Tarih, TextBox GirenToplam, TextBox CikanToplam, TextBox Bakiye)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("Select HareketNo, IslemTuru, CariAd + ' ' + CariSoyad as AdıSoyadı, kh.CariNo, Belge, Giren, Cikan, ParaBirimi as Birim from KasaHareket kh inner join Cari c on c.CariNo=kh.CariNo where Convert(VarChar(20),Tarih, 104) = Convert(VarChar(20), @Tarih, 104) and kh.Silindi=0", conn);
            da.SelectCommand.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Convert.ToDateTime(Tarih);

            try
            {
                da.Fill(dt);
                decimal TGiren = 0;
                decimal TCikan = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    TGiren += Convert.ToDecimal(dr["Giren"]);
                    TCikan += Convert.ToDecimal(dr["Cikan"]);
                }
                GirenToplam.Text = TGiren.ToString();
                CikanToplam.Text = TCikan.ToString();
                Bakiye.Text = (TGiren - TCikan).ToString();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return dt;
        }

        public DataTable KasaHaraketleriGetirByTarihlerArasi(string Tarih1, string Tarih2)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("Select HareketNo, KasaTuru, Tarih, IslemTuru, kh.CariNo, CariAd + ' ' + CariSoyad as AdıSoyadı, Belge, Giren, Cikan, ParaBirimi as Birim  from KasaHareket kh inner join Cari c on c.CariNo=kh.CariNo where Convert(VarChar(20),Tarih, 104) >= Convert(VarChar(20), @Tarih1, 104) and Convert(VarChar(20),Tarih, 104) <= Convert(VarChar(20), @Tarih2, 104) and kh.Silindi=0", conn);
            da.SelectCommand.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = Convert.ToDateTime(Tarih1);
            da.SelectCommand.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = Convert.ToDateTime(Tarih2);

            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return dt;
        }

        public DataTable KasaHaraketleriGetir()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("Select HareketNo, KasaTuru, Tarih, IslemTuru, kh.CariNo, CariAd + ' ' + CariSoyad as AdıSoyadı, Belge, Giren, Cikan, ParaBirimi as Birim from KasaHareket kh inner join Cari c on c.CariNo=kh.CariNo where kh.Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return dt;
        }

        public DataTable KasaHaraketleriGetirByIslemTuru(string IslemTuru)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("Select HareketNo, KasaTuru, Tarih, IslemTuru, kh.CariNo, CariAd + ' ' + CariSoyad as AdıSoyadı, Belge, Giren, Cikan, ParaBirimi as Birim from KasaHareket kh inner join Cari c on c.CariNo=kh.CariNo where kh.Silindi=0 and IslemTuru like @IslemTuru + '%'", conn);
            da.SelectCommand.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = IslemTuru;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return dt;
        }

        public DataTable KasaHaraketleriGetirByBelge(string Belge)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("Select HareketNo, KasaTuru, Tarih, IslemTuru, kh.CariNo, CariAd + ' ' + CariSoyad as AdıSoyadı, Belge, Giren, Cikan, ParaBirimi as Birim from KasaHareket kh inner join Cari c on c.CariNo=kh.CariNo where kh.Silindi=0 and Belge like '%' + @Belge + '%'", conn);
            da.SelectCommand.Parameters.Add("@Belge", SqlDbType.VarChar).Value = Belge;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return dt;
        }

        public DataTable KasaHaraketleriGetirByMusteriAd(string MusteriAd)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("Select HareketNo, KasaTuru, Tarih, IslemTuru, kh.CariNo, CariAd + ' ' + CariSoyad as AdıSoyadı, Belge, Giren, Cikan, ParaBirimi as Birim from KasaHareket kh inner join Cari c on c.CariNo=kh.CariNo where kh.Silindi=0 and CariAd like @MusteriAd + '%'", conn);
            da.SelectCommand.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = MusteriAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return dt;
        }

        public int KasaHareketEkle(cKasaHareket kh)
        {
            int KayitNo = 0;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Insert into KasaHareket(Tarih, IslemTuru, CariNo, Belge, Giren, Cikan) values(@Tarih, @IslemTuru, @CariNo, @Belge, @Giren, @Cikan); Select Scope_Identity()", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = kh._tarih;
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = kh._islemTuru;
            comm.Parameters.Add("@CariNo", SqlDbType.Int).Value = kh._cariNo;
            comm.Parameters.Add("@Belge", SqlDbType.VarChar).Value = kh._belge;
            comm.Parameters.Add("@Giren", SqlDbType.Money).Value = kh._giren;
            comm.Parameters.Add("@Cikan", SqlDbType.Money).Value = kh._cikan;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                KayitNo = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return KayitNo;
        }

        //BENİM KOD

        public bool KasaHareketGuncelle(cKasaHareket kh)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("Update KasaHareket set Tarih=@Tarih, Belge=@Belge, Giren=@Giren, Cikan=@Cikan where HareketNo=@HareketNo", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.Date).Value = kh._tarih;
            comm.Parameters.Add("@Belge", SqlDbType.VarChar).Value = kh._belge;
            comm.Parameters.Add("@Giren", SqlDbType.Money).Value = kh._giren;
            comm.Parameters.Add("@Cikan", SqlDbType.Money).Value = kh._cikan;
            comm.Parameters.Add("@HareketNo", SqlDbType.Int).Value = kh._hareketNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }

        public bool KasaHareketSil(string hareketNo)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update KasaHareket set Silindi=1 where HareketNo = @HareketNo ", conn);
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
                MessageBox.Show("KasaHareketSil Silmede Veri Tabanı Hatası");
            }
            finally
            {
                conn.Close();
            }
            return Sonuc;
        }

    }
}
