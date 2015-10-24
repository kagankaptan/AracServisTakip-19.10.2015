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
    class cServisHareket
    {
        private int _hareketNo;
        private DateTime _tarih;
        private int _ustaNo;
        private int _servisNo;
        private int _cariNo;
        private decimal _fiyat;
        private decimal _tutar;

        #region Properties
        public int HareketNo
        {
            get { return _hareketNo; }
            set { _hareketNo = value; }
        }

        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }

        public int UstaNo
        {
            get { return _ustaNo; }
            set { _ustaNo = value; }
        }

        public int ServisNo
        {
            get { return _servisNo; }
            set { _servisNo = value; }
        }

        public int CariNo
        {
            get { return _cariNo; }
            set { _cariNo = value; }
        }

        public decimal Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }

        public decimal Tutar
        {
            get { return _tutar; }
            set { _tutar = value; }
        } 
        #endregion

        public DataTable ServisHareketGetirByUstayaGore()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select CariAd, Plaka, Tarih, ServisAd from ServisHareket inner join ServisIslemleri on ServisIslemleri.ServisNo=ServisHareket.ServisNo inner join Cari on Cari.CariNo = ServisHareket.CariNo where UstaNo=@UstaID", conn);
            da.SelectCommand.Parameters.Add("@UstaID", SqlDbType.Int).Value = cGenel.UstaID;
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

        public int ServisHareketEkle(cServisHareket sh)
        {
            int kayitno = 0;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("insert into ServisHareket(Tarih,UstaNo,ServisNo,CariNo,Fiyat,Tutar) values (@Tarih, @UstaNo, @ServisNo, @CariNo, @Fiyat, @Tutar) ; select Scope_Identity() ", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = sh._tarih;
            comm.Parameters.Add("@UstaNo", SqlDbType.Int).Value = sh._ustaNo;
            comm.Parameters.Add("@CariNo", SqlDbType.Int).Value = sh._cariNo;
            comm.Parameters.Add("@ServisNo", SqlDbType.Int).Value = sh._servisNo;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = sh._fiyat;
            comm.Parameters.Add("@Tutar", SqlDbType.Money).Value = sh._tutar;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                kayitno = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string Hata = ex.Message;
                MessageBox.Show(Hata + " servis hareket");
            }
            finally
            {
                conn.Close();
            }
            return kayitno;
        }

        public DataTable CariAdaGoreRaporlama(int CariNo, DateTime IlkTarih, DateTime SonTarih)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select CariAd,CariSoyad,Plaka,ServisHareket.Tarih,ServisNo,ServisHareket.UstaNo, ServisHareket.Tutar, UrunHareket.Tutar from Cari inner join UrunHareket on UrunHareket.CariNo=Cari.CariNo inner join ServisHareket on ServisHareket.CariNo=Cari.CariNo where Cari.CariNo=@CariNo and ServisHareket.Tarih between @IlkTarih and @SonTarih ", conn);
            da.SelectCommand.Parameters.Add("@CariNo", SqlDbType.Int).Value = CariNo;
            da.SelectCommand.Parameters.Add("@IlkTarih", SqlDbType.DateTime).Value = IlkTarih;
            da.SelectCommand.Parameters.Add("@SonTarih", SqlDbType.DateTime).Value = SonTarih;
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

        public DataTable ServisAdaGoreRaporlama(string ServisAd, DateTime IlkTarih, DateTime SonTarih)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select ServisIslemleri.ServisAd,Tarih from ServisIslemleri inner join  Servishareket on ServisHareket.ServisNo=ServisIslemleri.ServisNo where ServisIslemleri.ServisAd=@ServisAd and Tarih between @IlkTarih and @SonTarih", conn);
            da.SelectCommand.Parameters.Add("@ServisAd", SqlDbType.VarChar).Value = ServisAd;
            da.SelectCommand.Parameters.Add("@IlkTarih", SqlDbType.DateTime).Value = IlkTarih;
            da.SelectCommand.Parameters.Add("@SonTarih", SqlDbType.DateTime).Value = SonTarih;
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

        public DataTable UrunAdaGoreRaporlama(string UrunAd, DateTime IlkTarih, DateTime SonTarih)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select UrunAd,UrunKodu,IslemTuru,UrunHareket.Tarih,Adet,UrunHareket.BirimFiyat,UrunHareket.Tutar from Urunler inner join UrunHareket on UrunHareket.UrunNo=Urunler.UrunNo inner join Cari on Cari.CariNo=UrunHareket.CariNo inner join ServisHareket on ServisHareket.CariNo=Cari.CariNo where UrunAd=@UrunAd and UrunHareket.Tarih between @IlkTarih and @SonTarih ", conn);
            da.SelectCommand.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = UrunAd;
            da.SelectCommand.Parameters.Add("@IlkTarih", SqlDbType.DateTime).Value = IlkTarih;
            da.SelectCommand.Parameters.Add("@SonTarih", SqlDbType.DateTime).Value = SonTarih;
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

        public bool ServisHareketSil(int hareketNo)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update ServisHareket set Silindi = 1 where HareketNo = @HareketNo", conn);
            comm.Parameters.Add("@HareketNo", SqlDbType.Int).Value = hareketNo;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string Hata = ex.Message;
                MessageBox.Show("ServisHareket de hata");
                MessageBox.Show(Hata);
            }
            finally
            {
                conn.Close();
            }
            return sonuc;
        }

        public DataTable UstaAdaGoreRaporlama(int UstaNo, DateTime IlkTarih, DateTime SonTarih)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select ServisAd,CariAd + ' ' + CariSoyad as CariAdıSoyadı,Aciklama, ServisHareket.Fiyat, ServisHareket.Tutar from ServisHareket inner join ServisIslemleri on ServisIslemleri.ServisNo=ServisHareket.ServisNo inner join Cari on Cari.CariNo=ServisHareket.CariNo where UstaNo=@UstaNo and Tarih between @IlkTarih and @SonTarih", conn);
            da.SelectCommand.Parameters.Add("@UstaNo", SqlDbType.Int).Value = UstaNo;
            da.SelectCommand.Parameters.Add("@IlkTarih", SqlDbType.DateTime).Value = IlkTarih;
            da.SelectCommand.Parameters.Add("@SonTarih", SqlDbType.DateTime).Value = SonTarih;
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

        public DataTable ServisUstaAdaGoreRaporlama(int UstaNo, string ServisAd, DateTime IlkTarih, DateTime SonTarih)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select ServisAd, Aciklama, ServisHareket.Fiyat, ServisHareket.Tutar from ServisHareket inner join ServisIslemleri on ServisIslemleri.ServisNo=ServisHareket.ServisNo where UstaNo=@UstaNo and ServisAd=@ServisAd and Tarih between @IlkTarih and @SonTarih", conn);
            da.SelectCommand.Parameters.Add("@ServisAd", SqlDbType.VarChar).Value = ServisAd;
            da.SelectCommand.Parameters.Add("@UstaNo", SqlDbType.Int).Value = UstaNo;
            da.SelectCommand.Parameters.Add("@IlkTarih", SqlDbType.DateTime).Value = IlkTarih;
            da.SelectCommand.Parameters.Add("@SonTarih", SqlDbType.DateTime).Value = SonTarih;
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

        public DataTable CariServisAdaGoreRaporlama(string ServisAd, int CariNo, DateTime IlkTarih, DateTime SonTarih)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select ServisHareket.Fiyat,ServisHareket.Tutar,Aciklama from ServisHareket inner join ServisIslemleri on ServisIslemleri.ServisNo=ServisHareket.ServisNo where ServisIslemleri.ServisAd=@ServisAd and ServisHareket.CariNo=@CariNo and  Tarih between @IlkTarih and @SonTarih", conn);
            da.SelectCommand.Parameters.Add("@ServisAd", SqlDbType.VarChar).Value = ServisAd;
            da.SelectCommand.Parameters.Add("@CariNo", SqlDbType.Int).Value = CariNo;
            da.SelectCommand.Parameters.Add("@IlkTarih", SqlDbType.DateTime).Value = IlkTarih;
            da.SelectCommand.Parameters.Add("@SonTarih", SqlDbType.DateTime).Value = SonTarih;
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

        public DataTable CariUstaAdaGoreRaporlama(int UstaNo, int CariNo, DateTime IlkTarih, DateTime SonTarih)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select Plaka, Aciklama, ServisHareket.Fiyat,ServisHareket.Tutar, Bakiye from ServisHareket inner join ServisIslemleri on ServisIslemleri.ServisNo=ServisHareket.ServisNo inner join Cari on Cari.CariNo=ServisHareket.CariNo where ServisHareket.CariNo=@CariNo and ServisHareket.UstaNo=@UstaNo and Tarih between @IlkTarih and @SonTarih", conn);
            da.SelectCommand.Parameters.Add("@CariNo", SqlDbType.Int).Value = CariNo;
            da.SelectCommand.Parameters.Add("@UstaNo", SqlDbType.Int).Value = UstaNo;
            da.SelectCommand.Parameters.Add("@IlkTarih", SqlDbType.DateTime).Value = IlkTarih;
            da.SelectCommand.Parameters.Add("@SonTarih", SqlDbType.DateTime).Value = SonTarih;
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

        public DataTable ServisCariUstaAdaGoreRaporlama(string ServisAd, int CariNo, int UstaNo, DateTime IlkTarih, DateTime SonTarih)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select Plaka,Aciklama,ServisHareket.Fiyat,ServisHareket.Tutar,Bakiye from ServisHareket inner join ServisIslemleri on ServisIslemleri.ServisNo=ServisHareket.ServisNo inner join Cari on Cari.CariNo=ServisHareket.CariNo where ServisHareket.CariNo=@CariNo and ServisHareket.UstaNo=@UstaNo and ServisIslemleri.ServisAd=@ServisAd and Tarih between @IlkTarih and @SonTarih", conn);
            da.SelectCommand.Parameters.Add("@ServisAd", SqlDbType.VarChar).Value = ServisAd;
            da.SelectCommand.Parameters.Add("@CariNo", SqlDbType.Int).Value = CariNo;
            da.SelectCommand.Parameters.Add("@UstaNo", SqlDbType.Int).Value = UstaNo;
            da.SelectCommand.Parameters.Add("@IlkTarih", SqlDbType.DateTime).Value = IlkTarih;
            da.SelectCommand.Parameters.Add("@SonTarih", SqlDbType.DateTime).Value = SonTarih;
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

        public DataTable ServisUrunAdaGoreRaporlama(string ServisAd, string UrunAd, DateTime IlkTarih, DateTime SonTarih)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select  CariAd + ' ' + CariSoyad as AdıSoyadı, Plaka, Aciklama, Adet, UrunHareket.BirimFiyat, UrunHareket.Tutar from UrunHareket inner join Cari on Cari.CariNo=UrunHareket.CariNo inner join ServisHareket on ServisHareket.CariNo=Cari.CariNo inner join ServisIslemleri on ServisIslemleri.ServisNo=ServisHareket.ServisNo inner join Urunler on Urunler.UrunNo=UrunHareket.UrunNo where UrunAd=@UrunAd and ServisAd=@ServisAd and UrunHareket.Tarih between @IlkTarih and @SonTarih ", conn);
            da.SelectCommand.Parameters.Add("@ServisAd", SqlDbType.VarChar).Value = ServisAd;
            da.SelectCommand.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = UrunAd;
            da.SelectCommand.Parameters.Add("@IlkTarih", SqlDbType.DateTime).Value = IlkTarih;
            da.SelectCommand.Parameters.Add("@SonTarih", SqlDbType.DateTime).Value = SonTarih;
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

        public DataTable UstaUrunAdaGoreRaporlama(int UstaNo, string UrunAd, DateTime IlkTarih, DateTime SonTarih)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select CariAd + ' ' + CariSoyad as AdıSoyadı, Adet, UrunHareket.BirimFiyat, UrunHareket.Tutar from UrunHareket inner join Cari on Cari.CariNo=UrunHareket.CariNo inner join ServisHareket on ServisHareket.CariNo=Cari.CariNo inner join ServisIslemleri on ServisIslemleri.ServisNo=ServisHareket.ServisNo inner join Urunler on Urunler.UrunNo=UrunHareket.UrunNo where UrunHareket.UstaNo=@UstaNo and UrunAd=@UrunAd and UrunHareket.Tarih between @IlkTarih and @SonTarih ", conn);
            da.SelectCommand.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = UrunAd;
            da.SelectCommand.Parameters.Add("@UstaNo", SqlDbType.Int).Value = UstaNo;
            da.SelectCommand.Parameters.Add("@IlkTarih", SqlDbType.DateTime).Value = IlkTarih;
            da.SelectCommand.Parameters.Add("@SonTarih", SqlDbType.DateTime).Value = SonTarih;
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

    }
}
