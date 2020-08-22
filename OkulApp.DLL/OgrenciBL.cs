using OkulApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulApp.DLL
{
    public class OgrenciBL
    {
        public bool Kaydet(Ogrenci ogr)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Insert into tblogrenciler Values(@Ad,@Numara,@Soyad)", cn))
                {

                    SqlParameter[] p =
                    {
                        new SqlParameter("@Ad",ogr.Ad),
                        new SqlParameter("@Soyad", ogr.Soyad),
                        new SqlParameter("@Numara", ogr.Numara) };
                    cmd.Parameters.AddRange(p);
                    cn.Open();

                    return cmd.ExecuteNonQuery() > 0;

                }


            }
        }
    }
}
