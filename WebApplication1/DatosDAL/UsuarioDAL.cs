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
    public class UsuarioDAL
    {
        public static void GuardarUserNuevo(Usuario usu)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_insertuser", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@nameUser", usu.nameUser);
                            cmd.Parameters.AddWithValue("@password", usu.password);
                            cmd.Parameters.AddWithValue("state", usu.state);

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

        public static void ActualizarUser(Usuario usu)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_cambiosUser", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idUser", usu.idUser);
                            cmd.Parameters.AddWithValue("@nameUser", usu.nameUser);
                            cmd.Parameters.AddWithValue("@password", usu.password);


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
        public static void EliminarUser(Usuario u)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_eliminarUser", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idUser", u.idUser);
                            cmd.Parameters.AddWithValue("@nameUser", u.nameUser);
                            cmd.Parameters.AddWithValue("@password", u.password);
                            cmd.Parameters.AddWithValue("@state", u.state);

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


        public static List<Usuario> ObtenerUser()
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {

                    List<Usuario> usuario = new List<Usuario>();

                    using (SqlCommand cmd = new SqlCommand("sp_selectUser", cn))
                    {
                        cn.Open();
              
                        using (SqlDataAdapter dr = new SqlDataAdapter(cmd))
                        {
                            SqlDataReader obt = cmd.ExecuteReader();
                            
                            while (obt.Read())
                            {
                                Usuario usu = new Usuario();
                                usu.idUser = Convert.ToInt32(obt["idUser"].ToString());
                                usu.nameUser = obt["NameUser"].ToString();
                                usu.password = obt["Contraseña"].ToString();
                                usuario.Add(usu);
                            }
                        }
                    }
                    return usuario;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

     


        public static bool VerificarUsuario(string nameUser, string password)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_verificarUsuario";

                cn.Open();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameUser", nameUser);
                cmd.Parameters.AddWithValue("@password", password);
                
                int user = Convert.ToInt32(cmd.ExecuteScalar());
                if (user == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      

    }
}
