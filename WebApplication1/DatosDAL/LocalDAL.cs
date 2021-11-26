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
    public class LocalDAL
    {


        public static void GuardarLocalNuevo(Local lo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();


                    using (SqlCommand cmd = new SqlCommand("sp_insertLocal", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idLocal", lo.idLocal);
                            cmd.Parameters.AddWithValue("@entidad", lo.entidad);
                            cmd.Parameters.AddWithValue("@cuit", lo.cuit);
                            cmd.Parameters.AddWithValue("@iibb", lo.iibb);
                            cmd.Parameters.AddWithValue("@iva", lo.iva);
                           
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




        public static void ActualizarDatosLocal(Local lo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();


                    using (SqlCommand cmd = new SqlCommand("sp_cambioLocal", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idLocal", lo.idLocal);
                            cmd.Parameters.AddWithValue("@entidad", lo.entidad);
                            cmd.Parameters.AddWithValue("@cuit", lo.cuit);
                            cmd.Parameters.AddWithValue("@iibb", lo.iibb);
                            cmd.Parameters.AddWithValue("@iva", lo.iva);

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
       
        public static List<Local> ObtenerLocal()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {

                    List<Local> Local = new List<Local>();

                    using (SqlCommand cmd = new SqlCommand("sp_selectLocal", cn))
                    {
                        cn.Open();


                        using (SqlDataAdapter dr = new SqlDataAdapter(cmd))
                        {
                            SqlDataReader obt = cmd.ExecuteReader();
                            while (obt.Read())
                            {
                               
                                {
                                    Local lo = new Local();
                                    lo.idLocal = int.Parse(obt["idLocal"].ToString());
                                    lo.entidad = obt["Entidad"].ToString();
                                    lo.cuit = obt["CUIT"].ToString();
                                    lo.iibb = obt["IIBB"].ToString();
                                    lo.iva = obt["IVA"].ToString();
                                   Local.Add(lo);
                                }
                                

                            }
                        }
                    }
                    return Local;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }


        public static List<Local> ObtenerComboLocal()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {

                    List<Local> local = new List<Local>();

                    using (SqlCommand cmd = new SqlCommand("sp_selectLocal", cn))
                    {
                        cn.Open();


                        using (SqlDataAdapter dr = new SqlDataAdapter(cmd))
                        {
                            SqlDataReader obt = cmd.ExecuteReader();
                            while (obt.Read())
                            {
                                {
                                    Local lo = new Local();
                                    lo.idLocal = int.Parse(obt["idLocal"].ToString());
                                    lo.entidad = obt["Entidad"].ToString();
                                    local.Add(lo);
                                }

                            }
                        }
                    }
                    return local;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
