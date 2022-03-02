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
   public class ArticuloDAL
    {
        public static void GuardarArticulo(Articulo ar)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_insertArticulos", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@nameArticulo", ar.nameArticulo);
                            cmd.Parameters.AddWithValue("@cantidad", ar.cantidad);
                            cmd.Parameters.AddWithValue("@idRubro", ar.idRubro);
                            cmd.Parameters.AddWithValue("@precio", ar.precio);
                            cmd.Parameters.AddWithValue("@state", ar.estado);
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
        public static void ActualizarArticulo(Articulo ar)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();
                 

                    using (SqlCommand cmd = new SqlCommand("sp_cambioArticulo", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@numdeArticulo", ar.idArticulo);
                            cmd.Parameters.AddWithValue("@nameArticulo", ar.nameArticulo);
                            cmd.Parameters.AddWithValue("@cantidad", ar.cantidad);
                            cmd.Parameters.AddWithValue("@idRubro", ar.idRubro);
                            cmd.Parameters.AddWithValue("@precio", ar.precio);
                            cmd.Parameters.AddWithValue("@estado", ar.estado);
                                
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

        public static void DescArticulo(int cantidad, int idTicket)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();


                    using (SqlCommand cmd = new SqlCommand("sp_descArticulo", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idTicket", idTicket );
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                          

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
  
        public static void EliminarArticulo (Articulo ar)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                    cn.Open();
                  

                    using (SqlCommand cmd = new SqlCommand("sp_eliminarArticulo", cn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@numdeArticulo", ar.idArticulo);
                            cmd.Parameters.AddWithValue("@idRubro", ar.idRubro);
                            cmd.Parameters.AddWithValue("@cantidad", ar.cantidad);
                            cmd.Parameters.AddWithValue("@precio", ar.precio);
                            cmd.Parameters.AddWithValue("@estado", ar.estado);
                            cmd.Parameters.AddWithValue("@nameArticulo", ar.nameArticulo);

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

        public static string ObtenerPrecio(int idArticulo)
        {
            try
            {
                string resultado = "";
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {
                   

                    using (SqlCommand cmd = new SqlCommand("sp_selectDescription", cn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idArticulo", idArticulo);
                        cn.Open();


                        using (SqlDataAdapter dr = new SqlDataAdapter(cmd))
                        {
                            SqlDataReader obt = cmd.ExecuteReader();
                            while (obt.Read())
                            {
                                
                                resultado = float.Parse(obt["Precio"].ToString()).ToString();
                                
                            }return resultado;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Articulo> ObtenerComboArticulo()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {

                    List<Articulo> articulo = new List<Articulo>();

                    using (SqlCommand cmd = new SqlCommand("sp_selectArticulo", cn))
                    {
                        cn.Open();


                        using (SqlDataAdapter dr = new SqlDataAdapter(cmd))
                        {
                            SqlDataReader obt = cmd.ExecuteReader();
                            while (obt.Read())
                            {
                                {
                                    Articulo ar = new Articulo();
                                    ar.idArticulo = int.Parse(obt["idArticulo"].ToString());
                                    ar.nameArticulo = obt["NombreArticulo"].ToString();
                                    articulo.Add(ar);
                                }

                            }
                        }
                    }
                    return articulo;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<Articulo> ObtenerArticulo()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString))
                {

                    List<Articulo> articu = new List<Articulo>();

                    using (SqlCommand cmd = new SqlCommand("sp_selectArticulo", cn))
                    {
                        cn.Open();
                       

                        using (SqlDataAdapter dr = new SqlDataAdapter(cmd))
                        {
                            SqlDataReader obt = cmd.ExecuteReader();
                            while (obt.Read())
                            {
                                {
                                    Articulo art = new Articulo();
                                    art.idArticulo = Convert.ToInt32(obt["idArticulo"].ToString());
                                    art.idRubro = Convert.ToInt32(obt["idRubro"].ToString());
                                    art.nameArticulo = obt["NombreArticulo"].ToString();
                                    art.cantidad = Convert.ToInt32(obt["Cantidad"].ToString());
                                    art.precio = float.Parse(obt["Precio"].ToString());
                                    art.rubro = new Rubro();
                                    art.rubro.idRubro = Convert.ToInt32(obt["idRubro"].ToString());
                                    art.rubro.nameRubro = obt["NombreRubro"].ToString();

                                    articu.Add(art);
                                }
                              
                            }
                        }
                    }
                    return articu;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
