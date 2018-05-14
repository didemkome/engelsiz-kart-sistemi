using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EngelsizKartSistemi
{
    class SQL
    {
        SqlCommand komut = new SqlCommand();
        SqlConnection baglanti = new SqlConnection("server=DESKTOP-R4TJ1GG;Initial Catalog=EngelsizKartSistemi;Integrated Security=true");

        public SqlConnection baglantıadresi()
        {
            return baglanti;
        }
        public void baglanticontrol()
        {
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglantıacmak();
            }
        }
        public string baglantıacmak()
        {
            try
            {
                baglanti.Open();
                return "BAGLANTI OLUSTURULDU";

            }
            catch (Exception)
            {
                return "BAGLANTI OLUSTURULAMADI ! ";
            }
        }

        public void baglantıkapamak()
        {
            try
            {

                baglanti.Close();

            }
            catch (Exception)
            {

            }
        }
        public string KullaniciSil(int TC)
        {
            try
            {
                baglanticontrol();
                string sql = "DELETE FROM Kullanici WHERE TC=@TC";
                komut = new SqlCommand(sql, baglantıadresi());
                komut.Parameters.AddWithValue("@TC", TC);
                komut.ExecuteNonQuery();
                return "Kullanıcı Silindi ! ";
            }
            catch (Exception)
            {
                return "Hata olustu !\nLutfen tekrar deneyiniz .";
            }
            finally

            {
                baglantıkapamak();
            }
        }
    }
}
