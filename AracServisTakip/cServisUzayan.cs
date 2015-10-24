using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AracServisTakip
{
    class cServisUzayan
    {
        private int _hareketNo;
        private string _cariAd;
        private string _plaka;
        private string _servisAd;
        private string _urunAd;

        #region Properties
        public int HareketNo
        {
            get { return _hareketNo; }
            set { _hareketNo = value; }
        }

        public string CariAd
        {
            get { return _cariAd; }
            set { _cariAd = value; }
        }

        public string Plaka
        {
            get { return _plaka; }
            set { _plaka = value; }
        }

        public string ServisAd
        {
            get { return _servisAd; }
            set { _servisAd = value; }
        }

        public string UrunAd
        {
            get { return _urunAd; }
            set { _urunAd = value; }
        } 
        #endregion


        public bool IslemUzayanEkle(cServisUzayan su)
        {
            bool sonuc = false;
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlCommand comm = new SqlCommand("insert into ServisUzayan (CariAd,Plaka,ServisAd,UrunAd) values (@CariAd, @Plaka, @ServisAd, @UrunAd)", conn);
            comm.Parameters.Add("@CariAd",SqlDbType.VarChar).Value=su._cariAd;
            comm.Parameters.Add("@Plaka", SqlDbType.VarChar).Value = su._plaka;
            comm.Parameters.Add("@ServisAd", SqlDbType.VarChar).Value = su._servisAd;
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = su._urunAd;
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

        public DataTable IslemUzayanDanismanGoster()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(cGenel.connstr);
            SqlDataAdapter da = new SqlDataAdapter("select * from ServisUzayan", conn);
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
