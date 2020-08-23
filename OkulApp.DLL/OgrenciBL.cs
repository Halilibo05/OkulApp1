using OkulApp.DAL;
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
            Helper hlpr = new Helper();
            //using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand("Insert into tblogrenciler Values(@Ad,@Numara,@Soyad)", cn))
            //    {

            //        SqlParameter[] p =
            //        {
            //            new SqlParameter("@Ad",ogr.Ad),
            //            new SqlParameter("@Soyad", ogr.Soyad),
            //            new SqlParameter("@Numara", ogr.Numara) };



            //        return hlpr.ExecuteNonQuery() > 0;

            //    }
            SqlParameter[] p =
                    {
                        new SqlParameter("@Ad",ogr.Ad),
                        new SqlParameter("@Soyad", ogr.Soyad),
                        new SqlParameter("@Numara", ogr.Numara) };

            return hlpr.ExecuteNonQuery("Insert into tblOgrenciler Values(@Ad,@Soyad,@Numara)", p) > 0;

            }
        }
    }


