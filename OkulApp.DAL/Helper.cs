using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulApp.DAL
{
    public class Helper
    {

        public int ExecuteNonQuery(string cmdtext,SqlParameter [] p=null)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdtext, cn))
                {
                    if (p!=null)
                    {
                        cmd.Parameters.AddRange(p);
                      
                    }

                    cn.Open();
                    return cmd.ExecuteNonQuery() ;

                }


            }


           
        }
    }
}
