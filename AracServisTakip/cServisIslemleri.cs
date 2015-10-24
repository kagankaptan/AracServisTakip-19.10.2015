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
    class cServisIslemleri
    {
        private int _hareketNo;
        private DateTime _tarih;
        private int _servisNo;
        private int _ustaNo;
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

        public int ServisNo
        {
            get { return _servisNo; }
            set { _servisNo = value; }
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

        public void ServisleriGetirForServisIslemleri(ComboBox liste)
        {
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select * from ServisIslemleri where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    liste.Items.Add(dr["ServisAd"].ToString());
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

        public int ServisNoVeServisBedeliniGetir(string servisadi, TextBox servisno, TextBox servisbedeli)
        {
            int sonuc = 0;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select ServisNo, Fiyat from ServisIslemleri where ServisAd=@ServisAd", conn);
            comm.Parameters.Add("@ServisAd", SqlDbType.VarChar).Value = servisadi;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    servisno.Text = Convert.ToString(dr["ServisNo"]);
                    servisbedeli.Text = Convert.ToString(dr["Fiyat"]);
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

        //public decimal ServisBedeliniGetirByServisIslemineGore(int servisno)
        //{
        //    decimal sonuc = 0;
        //    SqlConnection conn = new SqlConnection(cGenel.connstr);
        //    SqlCommand comm = new SqlCommand("select ServisNo from ServisIslemleri where ServisNo=@ServisNo", conn);
        //    comm.Parameters.Add("@ServisAd", SqlDbType.VarChar).Value = servisno;
        //    if (conn.State == ConnectionState.Closed)
        //        conn.Open();
        //    try
        //    {
        //        sonuc = Convert.ToInt32(comm.ExecuteScalar());
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //    return sonuc;
        //}

        public void ServisGetirRaporlama(ComboBox liste)
        {
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("select ServisAd from ServisIslemleri where Silindi=0", conn);
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
    }
}
