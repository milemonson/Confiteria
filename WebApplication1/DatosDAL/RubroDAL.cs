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
   public class RubroDAL
    {
        public static void GuardarRubroNuevo(Rubro ru)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_insertDatosRubrodeArticulo", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@numdeArticulo", ru.idRubro);
                            cmd.Parameters.AddWithValue("@idRubro", ru.nameRubro);
                            cmd.Parameters.AddWithValue("@cantidad", ru.descripcion);
                            cmd.Parameters.AddWithValue("@estado", ru.estado);
                    
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

        public static void ActualizarRubro(Rubro ru)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_cambiosRubro", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@numdeArticulo", ru.idRubro);
                            cmd.Parameters.AddWithValue("@idRubro", ru.nameRubro);
                            cmd.Parameters.AddWithValue("@cantidad", ru.descripcion);
                            cmd.Parameters.AddWithValue("@estado", ru.estado);

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
        public static void EliminarRubro(Rubro ru)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_eliminarRubro", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@numdeArticulo", ru.idRubro);
                            cmd.Parameters.AddWithValue("@idRubro", ru.nameRubro);
                            cmd.Parameters.AddWithValue("@cantidad", ru.descripcion);
                            cmd.Parameters.AddWithValue("@estado", ru.estado);

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
        public static List<Rubro> ObtenerCombo()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {

                    List<Rubro> rubro = new List<Rubro>();

                    using (SqlCommand cmd = new SqlCommand("sp_selectRubro", cn))
                    {
                        cn.Open();


                        using (SqlDataAdapter dr = new SqlDataAdapter(cmd))
                        {
                            SqlDataReader obt = cmd.ExecuteReader();
                            while (obt.Read())
                            {
                                {
                                    Rubro ru = new Rubro();
                                    ru.idRubro = int.Parse(obt["idRubro"].ToString());
                                    ru.nameRubro = obt["NombreRubro"].ToString();
                                    rubro.Add(ru);
                                }

                            }
                        }
                    }
                    return rubro;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<Rubro> ObtenerRubro()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {

                    List<Rubro> rubro = new List<Rubro>();

                    using (SqlCommand cmd = new SqlCommand("sp_selectRubro", cn))
                    {
                        cn.Open();

                        using (SqlDataAdapter dr = new SqlDataAdapter(cmd))
                        {
                            SqlDataReader obt = cmd.ExecuteReader();
                           
                            while (obt.Read())
                            {
                                Rubro ru = new Rubro();
                                ru.idRubro = int.Parse(obt["idRubro"].ToString());
                                ru.nameRubro = obt["NombreRubro"].ToString();
                                ru.descripcion = obt["Descripcion"].ToString();
                                
                                rubro.Add(ru);

                            }
                        }
                    }
                    return rubro;
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
