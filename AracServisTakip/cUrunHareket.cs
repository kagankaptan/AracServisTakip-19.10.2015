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
    class cUrunHareket
    {
        private int _hareketNo;
        private DateTime _tarih;
        private string _islemTuru;
        private int _ustaNo;
        private int _cariNo;
        private int _urunNo;
        private string _belge;
        private int _adet;
        private decimal _birimFiyat;
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

        public string IslemTuru
        {
            get { return _islemTuru; }
            set { _islemTuru = value; }
        }

        public int UstaNo
        {
            get { return _ustaNo; }
            set { _ustaNo = value; }
        }

        public int CariNo
        {
            get { return _cariNo; }
            set { _cariNo = value; }
        }

        public int UrunNo
        {
            get { return _urunNo; }
            set { _urunNo = value; }
        }

        public string Belge
        {
            get { return _belge; }
            set { _belge = value; }
        }

        public int Adet
        {
            get { return _adet; }
            set { _adet = value; }
        }

        public decimal BirimFiyat
        {
            get { return _birimFiyat; }
            set { _birimFiyat = value; }
        }

        public decimal Tutar
        {
            get { return _tutar; }
            set { _tutar = value; }
        } 
        #endregion

        public DataTable UrunleriGetirByUstayaGore()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select CariAd, Plaka, Tarih, UrunAd from UrunHareket inner join Urunler on Urunler.UrunNo=UrunHareket.UrunNo inner join Cari on Cari.CariNo = UrunHareket.CariNo where UstaNo=@UstaID", conn);
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

        public int UrunHareketEkle(cUrunHareket uh)
        {
            int kayitno = 0;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("insert into UrunHareket(Tarih,IslemTuru,UstaNo,CariNo,UrunNo,Belge,Adet,BirimFiyat,Tutar) values (@Tarih, @IslemTuru, @UstaNo, @CariNo, @UrunNo, @Belge, @Adet, @BirimFiyat, @Tutar) ; select Scope_Identity() ", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = uh._tarih;
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = uh._islemTuru;
            comm.Parameters.Add("@UstaNo", SqlDbType.Int).Value = uh._ustaNo;
            comm.Parameters.Add("@CariNo", SqlDbType.Int).Value = uh._cariNo;
            comm.Parameters.Add("@UrunNo", SqlDbType.Int).Value = uh._urunNo;
            comm.Parameters.Add("@Belge", SqlDbType.VarChar).Value = uh._belge;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = uh._adet;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = uh._birimFiyat;
            comm.Parameters.Add("@Tutar", SqlDbType.Money).Value = uh._tutar;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                kayitno = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string Hata = ex.Message;
                MessageBox.Show(Hata + " Ürün hareket");
            }
            finally
            {
                conn.Close();
            }
            return kayitno;
        }

        public int UrunHareketSil(int hareketNo)
        {
            int sonuc = 0;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select Urunler.UrunNo from Urunler inner join UrunHareket on UrunHareket.UrunNo=Urunler.UrunNo where UrunHareket.HareketNo=@HareketNo and UrunHareket.Silindi=0 ; update UrunHareket set Silindi = 1 where HareketNo = @HareketNo ", conn);
            comm.Parameters.Add("@HareketNo", SqlDbType.Int).Value = hareketNo;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                sonuc = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string Hata = ex.Message;
                MessageBox.Show("UrunHareketSil de hata");
                MessageBox.Show(Hata);
            }
            finally
            {
                conn.Close();
            }
            return sonuc;
        }

    }
}
