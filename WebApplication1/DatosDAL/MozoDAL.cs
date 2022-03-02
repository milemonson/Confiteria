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
   public class MozoDAL
    {

        public static void GuardarMozoNuevo(Mozo mo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();
                   

                    using (SqlCommand cmd = new SqlCommand("sp_insertDatosMozo", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@nombre", mo.name);
                            cmd.Parameters.AddWithValue("@apellido", mo.lastname);
                            cmd.Parameters.AddWithValue("@telefono", mo.cellphone);
                            cmd.Parameters.AddWithValue("@email", mo.email);
                            cmd.Parameters.AddWithValue("@idUser", mo.usuario.idUser);
                            cmd.Parameters.AddWithValue("@state", mo.estado);
                            cmd.Parameters.AddWithValue("@comision", mo.comision);
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


        public static int TraerNameUser(string nameUser)
        {
            try
            {
                int iduser = 0;
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();


                    using (SqlCommand cmd = new SqlCommand("sp_selectNameUser", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@nameUser", nameUser);

                        }
                       iduser = int.Parse(cmd.ExecuteScalar().ToString());
                    }

                }
                return iduser;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
            
        public static void ActualizarDatosMozo(Mozo mo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();
                    

                    using (SqlCommand cmd = new SqlCommand("sp_cambioMozo", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@mozo", mo.mozo);
                            cmd.Parameters.AddWithValue("@nombre", mo.name);
                            cmd.Parameters.AddWithValue("@apellido", mo.lastname);
                            cmd.Parameters.AddWithValue("@telefono", mo.cellphone);
                            cmd.Parameters.AddWithValue("@email", mo.email);
                            cmd.Parameters.AddWithValue("@comision", mo.comision);

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
        public  static void EliminarDatosMozo(Mozo mo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();
                   

                    using (SqlCommand cmd = new SqlCommand("sp_eliminarMozo", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@mozo", mo.mozo);
                            cmd.Parameters.AddWithValue("@nombre", mo.name);
                            cmd.Parameters.AddWithValue("@apellido", mo.lastname);
                            cmd.Parameters.AddWithValue("@telefono", mo.cellphone);
                            cmd.Parameters.AddWithValue("@email", mo.email);
                            cmd.Parameters.AddWithValue("@state", mo.estado);
                            cmd.Parameters.AddWithValue("@comision", mo.comision);

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
        public static List<Mozo> ObtenerComboMozo()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {

                    List<Mozo> mozo = new List<Mozo>();

                    using (SqlCommand cmd = new SqlCommand("sp_selectMozo", cn))
                    {
                        cn.Open();


                        using (SqlDataAdapter dr = new SqlDataAdapter(cmd))
                        {
                            SqlDataReader obt = cmd.ExecuteReader();
                            while (obt.Read())
                            {
                                {
                                    Mozo mo = new Mozo();
                                    mo.mozo = int.Parse(obt["idMozo"].ToString());
                                    mo.name = obt["Nombre"].ToString();
                                    mozo.Add(mo);
                                }

                            }
                        }
                    }
                    return mozo;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static List<Mozo> ObtenerMozo()
        {
            try
            {
            

                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {

                    List<Mozo> mozos = new List<Mozo>();

                    using (SqlCommand cmd = new SqlCommand("sp_selectMozo", cn))
                    {
                        cn.Open();
          
                        using (SqlDataAdapter dr = new SqlDataAdapter(cmd))
                        {
                            SqlDataReader obt = cmd.ExecuteReader();
                           

                            while (obt.Read())
                            {
                                Mozo mo = new Mozo();
                                mo.mozo = Convert.ToInt32(obt["idMozo"].ToString());
                                mo.name = obt["Nombre"].ToString();
                                mo.lastname = obt["Apellido"].ToString();
                                mo.cellphone = obt["Telefono"].ToString();
                                mo.email = obt["Email"].ToString();
                                mo.estado = Convert.ToInt32(obt["Estado"].ToString());
                                mo.comision = float.Parse(obt["Comision"].ToString());
                                mo.usuario = new Usuario();
                                mo.usuario.idUser = Convert.ToInt32(obt["idUser"].ToString());
                                mo.usuario.nameUser = obt["NameUser"].ToString();
                                mozos.Add(mo);

                            }
                        }
                    }
                    return mozos;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static SqlDataReader VentasPorMozo(DateTime fecha)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString);

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.CommandText = "sp_ventasxmozo";
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cn.Open();
                SqlDataReader obt = cmd.ExecuteReader();
                return obt;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
