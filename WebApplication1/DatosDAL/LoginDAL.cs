using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace DatosDAL
{
    public class LoginDAL

    {
        public static void Usuario(Login lo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_insertLogin", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idUser",lo.idUser);
                            cmd.Parameters.AddWithValue("@usuario",lo.user);
                            cmd.Parameters.AddWithValue("@contraseña",lo.pass);
                           
                        }
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
