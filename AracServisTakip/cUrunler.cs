using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace AracServisTakip
{
    class cUrunler
    {
        private int _urunNo;
        private string _urunAd;
        private int _servisNo;
        private int _miktar;
        private decimal _birimFiyat;
        private int _kritikSeviye;

        #region Properties
        public int UrunNo
        {
            get { return _urunNo; }
            set { _urunNo = value; }
        }
        private string _urunKodu;

        public string UrunKodu
        {
            get { return _urunKodu; }
            set { _urunKodu = value; }
        }

        public string UrunAd
        {
            get { return _urunAd; }
            set { _urunAd = value; }
        }

        public int ServisNo
        {
            get { return _servisNo; }
            set { _servisNo = value; }
        }

        public int Miktar
        {
            get { return _miktar; }
            set { _miktar = value; }
        }

        public decimal BirimFiyat
        {
            get { return _birimFiyat; }
            set { _birimFiyat = value; }
        }

        public int KritikSeviye
        {
            get { return _kritikSeviye; }
            set { _kritikSeviye = value; }
        }
        #endregion

        public void UrunleriGetirForServisIslemleri(ComboBox liste)
        {
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select * from Urunler where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    liste.Items.Add(dr["UrunAd"].ToString());
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

        public void UrunleriGetir(ListView Liste)
        {
            Liste.Items.Clear();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select UrunNo,UrunKodu,UrunAd,Miktar,BirimFiyat,KritikSeviye from Urunler where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    Liste.Items.Add(dr["UrunNo"].ToString());
                    Liste.Items[i].SubItems.Add(dr["UrunKodu"].ToString());
                    Liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                    Liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                    Liste.Items[i].SubItems.Add(dr["KritikSeviye"].ToString());
                    Liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                    i++;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                MessageBox.Show(hata);
            }
            finally { conn.Close(); }
        }

        public DataTable UrunleriGetir()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select UrunNo,UrunKodu,UrunAd,Miktar,BirimFiyat,KritikSeviye from Urunler where Silindi=0", conn);

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

        public bool UrunEkle(cUrunler u)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("insert into Urunler (UrunAd,UrunKodu,Miktar,BirimFiyat,KritikSeviye) values(@UrunAd, @UrunKodu, @Miktar, @BirimFiyat, @KritikSeviye)", conn);
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = u._urunAd;
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = u._urunKodu;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = u._miktar;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = u._birimFiyat;
            comm.Parameters.Add("@KritikSeviye", SqlDbType.Int).Value = u._kritikSeviye;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                MessageBox.Show(hata);
            }
            finally { conn.Close(); }
            return sonuc;
        }

        public bool UrunKontrol(string UrunKodu)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select UrunKodu from Urunler where UrunKodu=@UrunKodu", conn);
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = UrunKodu;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                    sonuc = true;
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                MessageBox.Show(hata);
            }
            finally { conn.Close(); }
            return sonuc;
        }

        public bool UrunSil(int UrunNo)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update Urunler set Silindi=1 where UrunNo=@UrunNo", conn);
            comm.Parameters.Add("@UrunNo", SqlDbType.Int).Value = UrunNo;
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
            finally
            {
                conn.Close();
            }
            return sonuc;
        }

        public bool UrunDegistir(cUrunler u)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update Urunler set UrunKodu=@UrunKodu,UrunAd=@UrunAd,Miktar=@Miktar,BirimFiyat=@BirimFiyat,KritikSeviye=@KritikSeviye where Silindi=0", conn);
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = u._urunKodu;
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = u._urunAd;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = u._miktar;
            comm.Parameters.Add("@KritikSeviye", SqlDbType.Int).Value = u._kritikSeviye;
            comm.Parameters.Add("@Birimfiyat", SqlDbType.Money).Value = u._birimFiyat;

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
            finally
            {
                conn.Close();
            }
            return sonuc;
        }

        public DataTable UrunAramaByUrunAdaGore(string UrunAd)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select UrunNo,UrunKodu,UrunAd,Miktar,BirimFiyat,KritikSeviye from Urunler where UrunAd like @UrunAdi + '%' and Silindi=0 ", conn);
            da.SelectCommand.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = UrunAd;
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

        public DataTable UrunAramaByUrunKodaGore(string UrunKodu)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select UrunNo,UrunKodu,UrunAd,Miktar,BirimFiyat,KritikSeviye from Urunler where UrunKodu like @UrunKodu + '%' and Silindi=0 ", conn);
            da.SelectCommand.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = UrunKodu;
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

        public bool UrunAramaByUrunKodaGore(string UrunKodu, ListView Liste)
        {
            Liste.Items.Clear();
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select UrunNo,UrunKodu,UrunAd,Miktar,BirimFiyat,KritikSeviye from Urunler where UrunKodu like @UrunKodu + '%' and Silindi=0 ", conn);
            comm.Parameters.Add("@UrunKodu", SqlDbType.VarChar).Value = UrunKodu;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            int i = 0;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Liste.Items.Add(dr["UrunNo"].ToString());
                    Liste.Items[i].SubItems.Add(dr["UrunKodu"].ToString());
                    Liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                    Liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                    Liste.Items[i].SubItems.Add(dr["KritikSeviye"].ToString());
                    Liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                    i++;
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
            return sonuc;
        }

        public bool UrunAramaByUrunAdaGore(string UrunAdi, ListView Liste)
        {
            Liste.Items.Clear();
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select UrunNo,UrunKodu,UrunAd,Miktar,BirimFiyat,KritikSeviye from Urunler where UrunAd like @UrunAdi + '%' and Silindi=0 ", conn);
            comm.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = UrunAdi;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            int i = 0;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Liste.Items.Add(dr["UrunNo"].ToString());
                    Liste.Items[i].SubItems.Add(dr["UrunKodu"].ToString());
                    Liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                    Liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                    Liste.Items[i].SubItems.Add(dr["KritikSeviye"].ToString());
                    Liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                    i++;
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
            return sonuc;
        }

        public bool KritikSeviyeSorgulama(ListView Liste)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select UrunNo,UrunKodu,UrunAd,Miktar,BirimFiyat,KritikSeviye from Urunler where Miktar<KritikSeviye and Silindi=0", conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int i = 0;
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Liste.Items.Add(dr["UrunNo"].ToString());
                    Liste.Items[i].SubItems.Add(dr["UrunKodu"].ToString());
                    Liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                    Liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                    Liste.Items[i].SubItems.Add(dr["KritikSeviye"].ToString());
                    Liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                    i++;
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
            return sonuc;
        }

        public void UrunleriGetirRaporlama(ComboBox liste)
        {
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select UrunAd from Urunler where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
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

        public int UrunNoGetirByUrunSecimineGore(string urunadi, TextBox urunno, TextBox urunbedeli)
        {
            int sonuc = 0;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select UrunNo, BirimFiyat from Urunler where UrunAd=@UrunAd", conn);
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = urunadi;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    urunno.Text = Convert.ToString(dr["UrunNo"]);
                    urunbedeli.Text = Convert.ToString(dr["BirimFiyat"]);
                } dr.Close();
                //sonuc = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return sonuc;
        }

        public bool StokGuncelleFromUrunHareketEkle(int UrunNo, int Adet, string IslemTuru)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update Urunler set Miktar = Miktar - @Adet where UrunNo = @UrunNo", conn);
            comm.Parameters.Add("@UrunNo", SqlDbType.Int).Value = UrunNo;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = Adet;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string Hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return Sonuc;
        }

        public bool StokGuncelleFromUrunHareketSil(int urunNo)
        {
            bool Sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("update Urunler set Miktar = Miktar + 1 where UrunNo = @UrunNo", conn);

            comm.Parameters.Add("@UrunNo", SqlDbType.Int).Value = urunNo;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string Hata = ex.Message;
                MessageBox.Show("StokGuncelleFromUrunHareketSil de hata");
                MessageBox.Show(Hata);
            }
            finally
            {
                conn.Close();
            }
            return Sonuc;
        }

    }
}
